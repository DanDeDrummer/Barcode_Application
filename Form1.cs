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
using OfficeOpenXml;
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
        List<String> GLASSES = new List<string> { "Adidas",
"Adrian Silver",
"Ana Hickmann",
"Barbie",
"Bavino",
"Bcando",
"Beyond",
"BluBay",
"Cando",
"Carrera",
"Centrostyle",
"CEO",
"Carolina Herrera",
"Charles Stone",
"Charmant",
"Chelsea",
"Chloe",
"Cooper",
"Cube",
"Daniel Hechter",
"De Panther",
"Disney",
"Dolce & Gabana",
"Dutz",
"Emporio Armani",
"Eco",
"Essikids",
"Etnia",
"Fede",
"Fossil",
"Fysh",
"Grant",
"Guess",
"Hello Kitty",
"Hugo Boss",
"Humphreys",
"Invu",
"Jean",
"Jeep",
"Knex",
"Koali",
"Lacoste",
"Lady Art",
"Lamatta",
"Laura Ashley",
"Levi's",
"Mango",
"Max Mara",
"Modo",
"Moleskin",
"Nano",
"NHI",
"Nickelodeon Kiddies",
"Nike",
"New York",
"Nomad",
"Oakly",
"Oliviero",
"Outspoken",
"Perrier Gun",
"Pierre Cardin",
"Polaroid",
"Polo",
"Prada",
"Pro Design",
"Pull&Bear",
"Puma",
"Quicksilver",
"RayBan",
"Raydon",
"Ripple",
"Rondenstock",
"Rudy",
"Safilo",
"Seventh Street",
"Silhouette",
"Sightique",
"SOS",
"Soviet",
"Splash",
"Star Wars",
"Stone Cherrie",
"Superflex",
"Ted Baker",
"Tom Tailor",
"Tomato",
"Tommy Hilfiger",
"Tommy Jeans",
"Tokyo Tek",
"Trend",
"United Colours of Benetton",
"Under Armour",
"Vogue",
"WOOW"};

        List<String> SOLUTIONS = new List<string>
        {
            "Aosept",
            "Artelac",
            "BioTrue",
            "Boston",
            "Delta",
            "Derma",
            "Easysept",
            "Eye Cleanse Foam",
            "Lid & Lash",
            "Naviblef",
            "Optive",
            "Oxysept",
            "Polyrinse",
            "Purilense",
            "Renu",
            "Sabax",
            "Systane",
            "Ultra",
            "Visu",
            "Vitasight",
            "Xailin",
        };

            //List <InventoryItemModel> inventoryItems = new List<InventoryItemModel>();
        public frmBarcodeApplication()
        {
            InitializeComponent();

            //LoadInventoryItemsList();
        }


        #region Database Code
        //https://www.youtube.com/watch?v=ayp3tHEkRc0 31:55

        private void LoadInventoryItemsList()
        {
            /*inventoryItems = SqliteDataAccess.LoadInventoryStockItems();
            WireUpInventoryItemListBox();*/
        }

        private void WireUpInventoryItemListBox()
        {
            /*listItemsListBox.DataSource = null;
            listItemsListBox.DataSource = inventoryItems;
            listItemsListBox.DisplayMember = "ItemName";*/
        }

        private void cbbARItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*switch (cbbARItemType.SelectedIndex)
            {
                //Frame
                case 0:
                    //Empty Existing cbb
                    cbbARItemBrand.Items.Clear();
                    for (int i = 0; i < GLASSES.Count; i++)
                    {
                        //Populate from list
                        cbbARItemBrand.Items.Add(GLASSES[i]);
                    }
                    //Add bottom text
                    cbbARItemBrand.Items.Add("Add a new Brand");
                    break;

                //Sunglass
                case 1:
                    //Empty Existing cbb
                    cbbARItemBrand.Items.Clear();
                    for (int i = 0; i < GLASSES.Count; i++)
                    {
                        //Populate from list
                        cbbARItemBrand.Items.Add(GLASSES[i]);
                    }
                    //Add bottom text
                    cbbARItemBrand.Items.Add("Add a new Brand");
                    break;

                //Solution
                case 2:
                    //Empty Existing cbb
                    cbbARItemBrand.Items.Clear();
                    for (int i = 0; i < SOLUTIONS.Count; i++)
                    {
                        //Populate from list
                        cbbARItemBrand.Items.Add(SOLUTIONS[i]);
                    }
                    //Add bottom text
                    cbbARItemBrand.Items.Add("Add a new Brand");
                    break;

                default:
                    MessageBox.Show("Invalid Item Type Selected.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }*/
        }

        string generatedItemCode;
        private void btnARGenerateItemCode_Click(object sender, EventArgs e)
        {
            /*T*/
            //tbxARItemCodeT.Text = "T";
            /*FRA/SUN/SOL*/
            //tbxARItemCodeType.Text = cbbARItemType.Text.Substring(0, 1) + cbbARItemType.Text.Substring(1, 1) + cbbARItemType.Text.Substring(2, 1);
            /*RAY*/
            //tbxARItemCodeBrand.Text = cbbARItemType.Text.Substring(0, 1) + cbbARItemType.Text.Substring(1, 1) + cbbARItemType.Text.Substring(2, 1);
            /*DESCRIPTION*/
            //tbxARItemCodeName.Text = tbxARItemName.Text;
            /*COLOR*/
            //tbxARItemCodeColor.Text = tbxARItemColor.Text;

            //generatedItemCode = tbxARItemCodeT.Text + "-" + tbxARItemCodeType.Text + "-" + tbxARItemCodeBrand.Text + "-" + tbxARItemCodeName.Text + "-" + tbxARItemCodeColor.Text;

            //btnARAddToDB.Enabled = true;
        }

        private void btnARAddToDB_Click(object sender, EventArgs e)
        {
            /*string confirmMessage = "Are you sure you want to add the item " + "\"" + generatedItemCode + "\"" + " to the database?"
                + "\n" + "\n" + lblARItemType.Text + " " + cbbARItemType.Text
                + "\n" + lblARItemBrand.Text + " " + cbbARItemBrand.Text
                + "\n" + lblARItemName.Text + " " + tbxARItemName.Text
                + "\n" + lblARItemColor.Text + " " + tbxARItemColor.Text
                + "\n" + lblARItemQuantity.Text + " " + numUDARItemQuantity.Value.ToString();

            if ((MessageBox.Show(confirmMessage, "Confirmation", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                //Add to SQL Database
                InventoryItemModel inventoryItemModel = new InventoryItemModel();

                inventoryItemModel.ItemName = tbxARItemName.Text;
                inventoryItemModel.ItemColor = tbxARItemColor.Text;
                inventoryItemModel.ItemType = cbbARItemType.Text;
                inventoryItemModel.ItemQuantity = Convert.ToInt32(numUDARItemQuantity.Value);
                inventoryItemModel.ItemCode = generatedItemCode;//GenerateItemCode(type, name, color);

                SqliteDataAccess.SaveInventoryStockItem(inventoryItemModel);

                //Clear TextBoxes
                tbxARItemName.Text = "";
                tbxARItemColor.Text = "";
                cbbARItemType.SelectedIndex = -1;
                numUDARItemQuantity.Value = 0;

                MessageBox.Show("Item " + inventoryItemModel.ItemCode + "\"" + inventoryItemModel.ItemName + "\"" + " was added to the Database.");
                btnARAddToDB.Enabled = false;
            }
            else
            {
                MessageBox.Show("Item was not added to the database.", "Abort Generate", MessageBoxButtons.OK);
            }*/
        }

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

        private void btnWelAddRemoveDB_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void btnWelStocktake_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 5;
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

                    //Search DB for code
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
