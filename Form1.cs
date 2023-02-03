using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using Demo_Library;
using QRCoder;
using ZXing;

namespace Barcode_Application
{
    //Generate QR Code: https://www.youtube.com/watch?v=32u7kb9DYEk
    //Scan QR Code: https://www.youtube.com/watch?v=pKjct-DXL0w
    public partial class frmBarcodeApplication : Form
    {
        List<Image> QRImages = new List<Image>();
        List<String> ItemCodes = new List<String>();

        List<InventoryItemModel> inventoryItems = new List<InventoryItemModel>();
        public frmBarcodeApplication()
        {
            InitializeComponent();

            LoadInventoryItemsList();
        }


        #region Database Code
        //https://www.youtube.com/watch?v=ayp3tHEkRc0 31:55

        private void LoadInventoryItemsList()
        {
            inventoryItems = SqliteDataAcess.LoadInventoryStockItems();
            WireUpInventoryItemListBox();
        }

        private void WireUpInventoryItemListBox()
        {
            /*listItemsListBox.DataSource = null;
            listItemsListBox.DataSource = inventoryItems;
            listItemsListBox.DisplayMember = "ItemName";*/
        }

        //Add Inventory Item Button
        /*InventoryItemModel inventoryItemModel = new InventoryItemModel();

            inventoryItemModel.ItemName = txtItemName.Text;
            inventoryItemModel.ItemColor = ItemColor.Text;
            inventoryItemModel.ItemType = cbbItemType.SelectedIndex.Text;
            inventoryItemModel.ItemQuantity = Convert.ToInt32(numUDItemQuantity.Value);
            inventoryItemModel.ItemCode = "";//GenerateItemCode(type, name, color);

            SqliteDataAcess.SaveInventoryStockItem(inventoryItemModel);

            //Clear TextBoxes
            txtItemName.Text = "";
            ItemColor.Text = "";
            cbbItemType.SelectedIndex = -1;
            numUDItemQuantity.Value = 0;

            MessageBox.Show("Item " + inventoryItemModel.ItemCode + "\"" + inventoryItemModel.ItemName + "\"" + " was added to the Database.");*/

        #endregion

        #region Welcome
        private void btnWelSale_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void btnWelGenerate_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
            //Clear QR Lists
            QRImages.Clear();
            ItemCodes.Clear();
        }

        private void btnWelScan_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }
        #endregion

        #region Generate QR Code
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lblGenQRCodeOut.Text = "";
            picbxGenImage.Image = null;
            lblGenQRCodeOut.Visible = false;
            string qrCodeInput = txtGenQRCode.Text;
            if ((MessageBox.Show("Are you sure you want to create a QR Code for : " /*MAKE TEXT BOLD*/+ "\"" + qrCodeInput + "\"", "Confirmation", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(qrCodeInput, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                picbxGenImage.Image = code.GetGraphic(5);
                AddToPrintQueue(picbxGenImage.Image, qrCodeInput); //Uses BitMap: (code.GetGraphic(5), code) //Uses Image: (picbxGenImage.Image, code)

                //Display QRCode Above picture
                lblGenQRCodeOut.Visible = true;
                lblGenQRCodeOut.Text = qrCodeInput;

                btnGenPrint.Enabled = true;
                txtGenQRCode.Clear();
            }
            else 
            {
                MessageBox.Show("QR Code was not generated.", "Abort Generate", MessageBoxButtons.OK);
            }
        }

        private void AddToPrintQueue(Image image, String code)
        {
            QRImages.Add(image);
            ItemCodes.Add(code);
            //MessageBox.Show("\"" + code + "\"" + " added to ItemCode, now " + ItemCodes.Count + " items.");
        }

        private void btnGenBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }
        #endregion

        #region Scan QR Code
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void frmBarcodeApplication_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach(FilterInfo device in filterInfoCollection) 
            {
                cbbScanCameraList.Items.Add(device.Name);
                cbbScanCameraList.SelectedIndex = 0;
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbbScanCameraList.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);

            if(result != null) 
            {
                txtScanQRCode.Invoke(new MethodInvoker(delegate ()
                {
                    txtScanQRCode.Text = result.ToString();
                }));
            }
            picbxScanImage.Image = bitmap;
        }

        private void frmBarcodeApplication_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice != null) 
            {
                if(videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
        }

        private void btnScanBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        #endregion

        #region Sale


        #endregion

        #region Printing
        Bitmap bmp;
        Image printedImage;
        String drawnString;
        private void prntDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //MessageBox.Show("Start Margins are: " + e.MarginBounds/*x=100, y=100, width=650, height=900*/);
            int printedImageX = 0;
            int printedImageY = 0;
            int itemCodesX = 0;
            int itemCodesY = 0;
            int codeCounter = 0;
            for (int i = 0; i < QRImages.Count; i++)
            {
                //Print QRImages[i]
                printedImage = QRImages[i];
                drawnString = ItemCodes[i];
                e.Graphics.DrawImage(printedImage, printedImageX, printedImageY);//Print QR Image
                itemCodesX = printedImageX;
                printedImageX += 150;

                itemCodesY = printedImageY + printedImage.Height;
                e.Graphics.DrawString(drawnString, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, itemCodesX, itemCodesY);//150,125

                //Get Size of string in pixels, calculate new position based on the length
                SizeF stringSize = e.Graphics.MeasureString(drawnString, new Font("Arial", 16, FontStyle.Regular));

                if (printedImage.Width > stringSize.Width)
                {
                    itemCodesX = printedImageX;
                    //MessageBox.Show("Image bigger.");
                }
                else if (stringSize.Width > printedImage.Width)
                {
                    //This block pf code is causing the second and further rows to start 1 cell to the left.
                    printedImageX = itemCodesX + printedImage.Width + 100;
                    //MessageBox.Show("Image " + i + " Code bigger.");
                }

                if (((e.MarginBounds.X + printedImageX >= 650) || (e.MarginBounds.X + itemCodesX >= 650))) 
                {
                    //MessageBox.Show("Incresing Y value.");
                    printedImageX = 0;
                    itemCodesX = 0;
                    printedImageY += printedImage.Height + Convert.ToInt32(stringSize.Height);
                }

                if((e.MarginBounds.Y + printedImageY >= 900) || (e.MarginBounds.Y + itemCodesY >= 900) && (i < QRImages.Count)) 
                {
                    //Add new pdf page
                    MessageBox.Show("Add new page.");
                    e.HasMorePages = true;
                    printedImageX = 0;
                    printedImageY = 0;
                    itemCodesX = 0;
                    itemCodesY = 0;
                }
                else 
                {
                    e.HasMorePages = false;
                }
                   
                codeCounter++;
                // MessageBox.Show("QR Code Width: " + printedImage.Width + "\nQR Code Height: " + printedImage.Height);

            }
            //e.HasMorePages = false;
            MessageBox.Show("Printed " + codeCounter + " QR code(s) and the corresponding Item code(s)", "Printing Complete", MessageBoxButtons.OK);


        }

        private void btnGenPrint_Click(object sender, EventArgs e)
        {
            prntDlg.Document = prntDoc;
            //printedImage = QRImages[0];
           
            if(QRImages.Count > 0) 
            {
                if (prntDlg.ShowDialog() == DialogResult.OK && prntPrvDlg.ShowDialog() == DialogResult.OK)
                {
                    prntDoc.Print();
                }
            }
            else 
            {
                MessageBox.Show(QRImages.Count + " QR Code(s) were not printed.", "Aborted Print", MessageBoxButtons.OK);
            }



            /*//FoxLearnCode
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Height, this.Size.Width, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            prntPrvDlg.ShowDialog(); */
        }
        #endregion

        #region Debugging
        private void button1_Click(object sender, EventArgs e)
        {
            //T-FRA-AHI-1431-07A
            //Generate QR
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                if (i > 12)
                {
                    QRCodeGenerator qr = new QRCodeGenerator();
                    QRCodeData data = qr.CreateQrCode("T-FRA-AHI-1431-07A", QRCodeGenerator.ECCLevel.Q);
                    QRCode code = new QRCode(data);
                    AddToPrintQueue(code.GetGraphic(5), "T-FRA-AHI-1431-07A");
                }
                else
                {
                    QRCodeGenerator qr = new QRCodeGenerator();
                    QRCodeData data = qr.CreateQrCode("T-FRA-CUB-3127-002", QRCodeGenerator.ECCLevel.Q);
                    QRCode code = new QRCode(data);
                    AddToPrintQueue(code.GetGraphic(5), "T-FRA-CUB-3127-002");
                }

            }
            MessageBox.Show("Quick created QR. Length: " + QRImages.Count);
            btnGenPrint.Enabled = true;
        }

        #endregion

    }
}
