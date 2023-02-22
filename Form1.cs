using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using Demo_Library;
using OfficeOpenXml;
using QRCoder;
using ZXing;
using Microsoft.VisualBasic;
using System.Drawing.Printing;

namespace Barcode_Application
{
    //Generate QR Code: https://www.youtube.com/watch?v=32u7kb9DYEk
    //Scan QR Code: https://www.youtube.com/watch?v=pKjct-DXL0w
    public partial class frmBarcodeApplication : Form
    {
        List<String> Months = new List<string>{"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
        List<ExcelWorksheet> worksheets = new List<ExcelWorksheet>();
        List<int> worksheetsRows = new List<int>();
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

            #if DEBUG
            string TODOListString = "Code Continue Stock take button." + "\n" + "Next TODO" + "\n" + "Next TODO" + "\n" + "Next TODO" + "\n";
            MessageBox.Show(TODOListString, "TODO LIST", MessageBoxButtons.OK);
            #endif
            #if !DEBUG
            cbxSTDebugMode.Checked = false;
            cbxSTDebugMode.Visible = false;
            button1.Visible = false;
            btnBugStockTake.Visible = false;
            #endif

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
            tabControl.SelectedTab = tbsSale;
        }

        private void btnWelGenerate_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbsGenerateQR;
            //Clear QR Lists
            QRImages.Clear();
            ItemCodes.Clear();
        }

        private void btnWelScan_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbsScanQR;
        }

        private void btnWelAddRemoveDB_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbsAddRemoveFromDatabase;
        }

        private void btnWelStocktake_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbsStockTake;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void btnWelClose_Click(object sender, EventArgs e)
        {
            TerminateApplication();
        }

        #endregion

        #region Generate QR Code
        List<string> textFileList = new List<string>();
        string[] textFileArray;
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(cbxLoadFromFile.Checked == true) 
            {
                //Disable textbox
                txtGenQRCode.Enabled = true;
                //Open File Expolorer to get textfile
                if(openFileDialog1.ShowDialog() == DialogResult.OK) 
                {
                    //Select the correct text File
                    fileName = openFileDialog1.FileName;

                    int k = fileName.Length - 1;
                    string fileExtension = "";

                    for (int i = 1; i < fileName.Length; i++)
                    {
                        if (fileName[i] == '.')
                        {
                            for (int extensionCount = i; extensionCount < fileName.Length; extensionCount++)
                            {
                                fileExtension += fileName[extensionCount];
                            }
                        }
                    }

                    if(fileExtension == ".txt") 
                    {
                        //Iterate trough textfile and save all that isn't blank to a list
                        textFileArray = System.IO.File.ReadAllLines(fileName);

                        foreach (var item in textFileArray)
                        {
                            if(item != "" && item != " ") 
                            {
                                textFileList.Add(item);
                            }
                        }

                        //textFileList = new List<string>(textFileArray);
                        MessageBox.Show("Textfile items added to the list.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("\"" + fileExtension + "\"" + "Wrong File Extension only .txt allowed", "FileType Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                //Run throught the list and generate the codes (1)
                //LoadFromTextFileWithDelay(2000);
                LoadFromTextFileWithoutDelay();
            }
            else 
            {
                if(txtGenQRCode.Text == "" || txtGenQRCode.Text == " ") 
                {
                    MessageBox.Show("Input cannot be blank!" + "\n" + "Enter a valid input.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                lblGenQRCodeOut.Text = "";
                picbxGenImage.Image = null;
                lblGenQRCodeOut.Visible = false;
                string qrCodeInput = txtGenQRCode.Text;
                if ((MessageBox.Show("Are you sure you want to create a QR Code for : " + "\"" + qrCodeInput + "\"", "Confirmation", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                {
                    QRCodeGenerator qr = new QRCodeGenerator();
                    QRCodeData data = qr.CreateQrCode(qrCodeInput, QRCodeGenerator.ECCLevel.Q);
                    QRCode code = new QRCode(data);
                    int pixelsPerModule = 2; //5
                    picbxGenImage.Image = code.GetGraphic(5);
                    AddToPrintQueue(code.GetGraphic(pixelsPerModule), qrCodeInput); //Uses BitMap: (code.GetGraphic(5), code) //Uses Image: (picbxGenImage.Image, code)

                    //Display QRCode Above picture
                    lblGenQRCodeOut.Visible = true;
                    lblGenQRCodeOut.Text = qrCodeInput;

                    btnGenSaveToPDF.Enabled = true;
                    txtGenQRCode.Clear();
                }
                else
                {
                    MessageBox.Show("QR Code was not generated.", "Abort Generate", MessageBoxButtons.OK);
                }
            }
        }

        private void LoadFromTextFileWithoutDelay()
        {
            foreach (var item in textFileList)
            {
                UseWaitCursor = true;
                //(1) Update the picturebox and label.
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(item, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                int pixelsPerModule = 2; //5
                AddToPrintQueue(code.GetGraphic(pixelsPerModule), item); //Uses BitMap: (code.GetGraphic(5), code) //Uses Image: (picbxGenImage.Image, code)

                //Display QRCode Above picture
                lblGenQRCodeOut.Visible = true;
                lblGenQRCodeOut.Text = item;
                picbxGenImage.Image = code.GetGraphic(5);
            }

            btnGenSaveToPDF.Enabled = true;
            UseWaitCursor = false;
        }

        async void LoadFromTextFileWithDelay(int delayTime)
        {
            foreach (var item in textFileList)
            {
                UseWaitCursor = true;
                //(1) Update the picturebox and label.
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(item, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                int pixelsPerModule = 2; //5
                AddToPrintQueue(code.GetGraphic(pixelsPerModule), item); //Uses BitMap: (code.GetGraphic(5), code) //Uses Image: (picbxGenImage.Image, code)

                //Display QRCode Above picture
                lblGenQRCodeOut.Visible = true;
                lblGenQRCodeOut.Text = item;
                picbxGenImage.Image = code.GetGraphic(5);
                await Task.Delay(delayTime);//Wait a bit then continue{Coroutine/IEnumerable}
            }

            btnGenSaveToPDF.Enabled = true;
            UseWaitCursor = false;
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
            RefreshCameraList();

            //Hide Unnessisary Tabsheets
            tabControl.TabPages.Remove(tbsAddRemoveFromDatabase);
            tabControl.TabPages.Remove(tbsSale);
        }

        private void btnPrimeScanner_Click(object sender, EventArgs e)
        {
            //Refresh Camera List
            RefreshCameraList();
            isBusyScanning = false;

            //Check if there are cameras in the dropdown
            if (cbbScanCameraList.Items.Count <= 0)
            {
                MessageBox.Show("No cameras active. Activate camera's to continue." + "\n" + "Then press the " + "\"" + "Prime Camera" + "\"" + " button.", "Cannot locate camera", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Change PictureFrame Color
            //Use "DeleteMe" code

            //Enable the Scan button
            btnScanScan.Enabled = true;
            btnPrimeScanner.Enabled = false;
        }

        bool isBusyScanning = false;//TODO Figure out how to incorperate this
        private void btnScan_Click(object sender, EventArgs e)
        {
            //If there is no camera in the dropdown, ask to enable camera
            /*if (cbbScanCameraList.Items.Count <= 0)
            {
                MessageBox.Show("No cameras active. Activate camera's to continue.", "Cannot locate camera", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }*/
           
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbbScanCameraList.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            
            videoCaptureDevice.Start();

            btnScanScan.Enabled = false;
            btnPrimeScanner.Enabled = true;
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            //Code that constantly checks if there is a QR Code infront of the camera
            if (isBusyScanning == true) { /*MessageBox.Show("Scanning busy NewFrame");*/ return; }
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);

            if (result != null)
            {
                txtScanQRCode.Invoke(new MethodInvoker(delegate ()
                {
                    txtScanQRCode.Text = result.ToString();

                    //Search DB for code
                    FromStockTakeOrScanner("Scanner", result.ToString());
                    isBusyScanning = true;
                }));
            }
            picbxScanImage.Image = null;
            picbxScanImage.Image = bitmap;
        }

        
        private void tbsScanQR_Enter(object sender, EventArgs e)
        {
            //If there is no camera in the dropdown, ask to enable camera
            if (cbbScanCameraList.Items.Count <= 0)
            {
                MessageBox.Show("No cameras active. Activate camera's to continue." + "\n" + "Then press the " + "\"" + "Prime Camera" + "\"" + " button.", "Cannot locate camera", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //When combobox is populated and camera variable isn't null acttivate camera
            //TODO how to set the image of a 
        }

        private void RefreshCameraList()
        {
            cbbScanCameraList.Items.Clear();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
            {
                cbbScanCameraList.Items.Add(device.Name);
                cbbScanCameraList.SelectedIndex = 0;
            }
        }

        private void frmBarcodeApplication_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
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
            MessageBox.Show("prntDoc_PrintPage are running ");
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

                if ((e.MarginBounds.Y + printedImageY >= 900) || (e.MarginBounds.Y + itemCodesY >= 900) && (i < QRImages.Count))
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

        private Font printFont;
        DateTime printStartTime;
        private void btnGenPrint_Click(object sender, EventArgs e)
        {
            if (QRImages.Count > 0)
            {
                int textSize = 8;
                try
                {
                    printStartTime = DateTime.Now;
                    printFont = new Font("Arial", textSize);//8
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler
                       (this.pd_PrintPageQR); //(this.pd_PrintPage);
                    pd.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(QRImages.Count + " QR Code(s) were not printed.", "Aborted Print", MessageBoxButtons.OK);
            }
        }

        int listIndex = 0;
        int pageNum = 0;
        private void pd_PrintPageQR(object sender, PrintPageEventArgs ev)
        {
            pageNum++;
            //MessageBox.Show("Start of pd_PrintPageQR");
            float linesPerPage = 0;
            float yPos = 0;
            float yPosPadding = 0;
            int count = 0;//Sets to 0 every time a new page gets created
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;//100
            string line = ItemCodes[listIndex];//Initial while variable commit
            float leftMarginPadding = 0;//Initial while variable commit
            int itemsInRow = 0;
            bool newPage;


            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               (QRImages[listIndex].Height + 15);//Max 5 QR code lines per page

            //Yes 5 codes get displayed, but it does not take into accout  that some of those codes are next to eachother.

            /*First attempt: QR gets draw then space of 15 units between QR images.
             String gets drawn then space of 15 units + QR height gets left for the next row
            yPos + QRImages[count].Height + 15*/

            //Van die eerste een af plus 3 kry die totale breedte deel deaur 3
            int columnQRWidthChecker = 0;
            int testItemsInRow = 4;//3
            int rowImagesWidth = 0, rowTextWidth = 0, rowTotalWhiteSpace = 200;
            int lastIndex = 0;
            if (listIndex % testItemsInRow == 0)
            {
                for (int i = 0; i < testItemsInRow; i++)
                {
                    
                    if (i < QRImages.Count()) 
                    {
                        rowImagesWidth += QRImages[listIndex + i].Width;
                        rowTextWidth += TextRenderer.MeasureText(ItemCodes[listIndex + i], printFont).Width;
                        lastIndex = i;
                    }
                    else //Add whaitespace the size of some "ghost items"
                    {
                        rowImagesWidth += QRImages[listIndex + lastIndex].Width;
                        rowTextWidth += TextRenderer.MeasureText(ItemCodes[listIndex + lastIndex], printFont).Width;
                    }
                }
                //var rowImagesWidth = QRImages[listIndex].Width + QRImages[listIndex + 1].Width + QRImages[listIndex + 2].Width + QRImages[listIndex + 3].Width;
                //var rowTextWidth = TextRenderer.MeasureText(ItemCodes[listIndex], printFont).Width + TextRenderer.MeasureText(ItemCodes[listIndex + 1], printFont).Width + TextRenderer.MeasureText(ItemCodes[listIndex + 2], printFont).Width;

                if (rowImagesWidth >= rowTextWidth)
                {
                    columnQRWidthChecker = (rowImagesWidth + rowTotalWhiteSpace) / testItemsInRow; //100 was 45
                }
                else
                {
                    columnQRWidthChecker = (rowTextWidth + rowTotalWhiteSpace) / testItemsInRow; //100 was 45
                }
                int columnQRWidth = columnQRWidthChecker / testItemsInRow;

                #if DEBUG
                MessageBox.Show("rowImagesWidth: " + rowImagesWidth + "\n" +
                "rowTextWidth: " + rowTextWidth + "\n" +
                "columnQRWidthChecker: " + columnQRWidthChecker + "\n" +
                "testItemsInRow: " + testItemsInRow + "\n" +
                "columnQRWidth: " + columnQRWidth + "\n");
                #endif


            }

            // Print each line of the file.
            yPos = topMargin + (0 * printFont.GetHeight(ev.Graphics));
            yPosPadding = yPos + QRImages[listIndex].Height + 15;
            int staggerAmount = 0;
            while (yPos < ev.MarginBounds.Height/*count < linesPerPage*/ && (line != null) && listIndex < QRImages.Count())//lines per page is 56.4???? which caused the bug with not making the other 3
            {
                /*//Makes it a new line in the PDF the height of the text graphic
                yPos = topMargin + (count *printFont.GetHeight(ev.Graphics));*/


                //QR Image at yPos, item Code at ypos + padding
                ev.Graphics.DrawImage(QRImages[listIndex], leftMargin + leftMarginPadding, yPos);//8,13,15
                ev.Graphics.DrawString((listIndex + 1) + ". " + line, printFont, Brushes.Black, leftMargin + leftMarginPadding /*+ 15*/, yPosPadding + staggerAmount, new StringFormat());
                //ev.Graphics.DrawString((listIndex + 1) + ". " + line, printFont, Brushes.Black, new PointF(leftMargin + leftMarginPadding + 15, yPosPadding + staggerAmount));
                listIndex++;
                itemsInRow++;
                if (listIndex < QRImages.Count())
                {
                    line = ItemCodes[listIndex];//Increment variable in loop
                    Size textSize = TextRenderer.MeasureText(line, printFont);
                    float codeLength = line.Length * textSize.Width; //The characters in the string multiplied by the size of one character
                    int imageWidth = QRImages[listIndex].Width + 15;
                    //leftMarginPadding = leftMarginPadding + QRImages[listIndex].Width + 15;//Increment variable in loop

                    if (listIndex % 2 == 0)
                    {
                        staggerAmount = 0;
                        //leftmarginpadding = leftmarginpadding + imagewidth;//increment variable in loop
                        //messagebox.show(listindex + " image larger than codelength leftmarginpadding: " + leftmarginpadding);*/
                    }
                    else
                    {
                        staggerAmount = textSize.Height + 5;
                        //image width plus (the width of the text - the width of the image)
                        //leftmarginpadding = leftmarginpadding + textsize.width;//increment variable in loop
                        //messagebox.show(line + " text width: " + textsize.width);
                    }

                    leftMarginPadding = leftMarginPadding + columnQRWidthChecker;

                    if (/*leftMargin + leftMarginPadding >= ev.MarginBounds.Width*/itemsInRow == testItemsInRow)
                    {
                        itemsInRow = 0;
                        //increase y position.
                        yPos += topMargin + (QRImages[listIndex].Height + 15 + textSize.Height/*printFont.GetHeight(ev.Graphics)*/);//(count * printFont.GetHeight(ev.Graphics));
                        yPosPadding = yPos + QRImages[listIndex].Height + 15;
                        leftMargin = ev.MarginBounds.Left;
                        leftMarginPadding = 0;
                        //MessageBox.Show("Reset leftMarginPadding for item: " + (listIndex + 1));
                        //MessageBox.Show("Y position: " + yPos + "\n" + "Y position padding: " + yPosPadding);
                        count++;//total line counter
                    }
                }
            }


            // If more lines exist, print another page.
            if (yPos >= ev.MarginBounds.Height/*line != null*/ && listIndex < QRImages.Count())
            {
                ev.HasMorePages = true;
                newPage = false;
                //MessageBox.Show("New Page after " + count);
                /*MessageBox.Show("Array count: " + QRImages.Count());
                MessageBox.Show("var listCount: " + listIndex);*/
            }
            else
            {
                ev.HasMorePages = false;
                DateTime endTime = DateTime.Now;

                TimeSpan durationTime = endTime - printStartTime;
                MessageBox.Show("Finished Printing " + QRImages.Count + " items." + "\n" + "On " + pageNum + " pages.");

                MessageBox.Show("Population took: " + durationTime);
            }

        }
        #endregion

        #region Stock Take

        protected virtual bool IsFileLocked(FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }

            //file is not locked
            return false;
        }

        ExcelWorksheet stocktakeWorksheet;
        ExcelPackage excelPackage;

        //string scannedQR = "T-FRA-AHI-1431-07A";
        bool fromStocktake = false;
        string stockWBName, fileName;
        int stocktakeSheetIndex, stockRow;
        private void btnSTNewStocktake_Click(object sender, EventArgs e)
        {
            stockWBName = "Stocktake " + DateTime.Today.Day + " " + Months[DateTime.Today.Month - 1] + " " + DateTime.Today.Year;
            StockTake(stockWBName, "Added to Sheet!", 0);
        }

        private void btnSTContinue_Click(object sender, EventArgs e)
        {
            stockWBName = "Stocktake " + dtpSTPreviousStocktake.Value.Day + " " + Months[dtpSTPreviousStocktake.Value.Month - 1] + " " + dtpSTPreviousStocktake.Value.Year;
            StockTake(stockWBName, "Added to Continued Sheet!" , 1);
        }


        /*TODO add cell formatting for header on line before adding text.*/
        int headerFontSize = 11;
        int contentFontSize = 10;

        private void StockTake(string stockTakeWorkbookName, string recordAddedMessage, int newContinue)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Select the correct excell File
                fileName = openFileDialog1.FileName;

                int k = fileName.Length - 1;
                string fileExtension = "";

                for (int i = 1; i < fileName.Length; i++)
                {
                    if (fileName[i] == '.')
                    {
                        for (int extensionCount = i; extensionCount < fileName.Length; extensionCount++)
                        {
                            fileExtension += fileName[extensionCount];
                        }
                    }
                }


                //fileExtension = ".xlsx"; //Debug

                if (fileExtension == ".xlsx")
                {
                    excelPackage = new ExcelPackage(fileName);
                    using (excelPackage)
                    {
                        //Set Excel Variables
                        ExcelWorkbook excelWorkBook = excelPackage.Workbook;
                        ExcelWorksheet excelWorksheetInventoryItemSummary = excelWorkBook.Worksheets["Inventory Item Summary"];
                        ExcelWorksheet excelWorksheetFrames = excelWorkBook.Worksheets["FRAMES"];
                        ExcelWorksheet excelWorksheetSunglasses = excelWorkBook.Worksheets["SUN"];
                        ExcelWorksheet excelWorksheetSolutions = excelWorkBook.Worksheets["SOLUTION"];
                        ExcelWorksheet excelWorksheetStocktake = excelWorkBook.Worksheets[stockTakeWorkbookName];

                        worksheets.Add(excelWorksheetInventoryItemSummary);
                        worksheets.Add(excelWorksheetFrames);
                        worksheets.Add(excelWorksheetSunglasses);
                        worksheets.Add(excelWorksheetSolutions);

                        worksheetsRows.Add(excelWorksheetInventoryItemSummary.Dimension.End.Row);
                        worksheetsRows.Add(excelWorksheetFrames.Dimension.End.Row);
                        worksheetsRows.Add(excelWorksheetSunglasses.Dimension.End.Row);
                        worksheetsRows.Add(excelWorksheetSolutions.Dimension.End.Row);


                        /*MessageBox.Show("Worksheet 0 : " + excelWorksheetInventoryItemSummary.Name + "\n" + "Worksheet 1 : " + excelWorksheetFrames.Name
                            + "\n" + "Worksheet 2 : " + excelWorksheetSunglasses.Name + "\n" + "Worksheet 3 : " + excelWorksheetSolutions.Name);*/

                        #region New Stocktake
                        if (newContinue == 0)
                        {
                            if (MessageBox.Show("Is this the first stocktake this month?", "New Stocktake or Continue", MessageBoxButtons.YesNo) == DialogResult.Yes) //It is the first time this stocktake is happening
                            {
                                //If the sheet doesn't exist then add it.
                                if (excelWorksheetStocktake == null)
                                {
                                    excelWorksheetStocktake = excelWorkBook.Worksheets.Add(stockTakeWorkbookName);
                                    stocktakeSheetIndex = excelWorkBook.Worksheets.Count() - 1;
                                }
                                else
                                {
                                    if (cbxSTDebugMode.Checked)
                                    {
                                        //Remove the sheet
                                        excelWorkBook.Worksheets.Delete(stockTakeWorkbookName);
                                        MessageBox.Show("Sheet Deleted!");
                                        excelWorksheetStocktake = excelWorkBook.Worksheets.Add(stockTakeWorkbookName);
                                        stocktakeSheetIndex = excelWorkBook.Worksheets.Count() - 1;
                                    }
                                    else
                                    {
                                        MessageBox.Show("A Stocktake sheet for selected date already exists." + "\n" + "Use the " + "\"" + btnSTContinue.Text + "\"" + " button instead.");
                                        return;
                                    }
                                }

                                //Set Column Widths
                                excelWorksheetStocktake.Column(1).Width = 46;//Column A
                                excelWorksheetStocktake.Column(2).Width = 36;//Column B
                                excelWorksheetStocktake.Column(3).Width = 16;//Column C
                                excelWorksheetStocktake.Column(4).Width = 21;//Column D
                                excelWorksheetStocktake.Column(5).Width = 45;//Column E

                                excelWorksheetStocktake.Cells["A1"].StyleName = "Arial";
                                excelWorksheetStocktake.Cells["A1"].Style.Font.Size = headerFontSize;
                                excelWorksheetStocktake.Cells["A1"].Style.Font.Bold = true;
                                excelWorksheetStocktake.Cells["A1"].Value = "Stocktake " + DateTime.Today;

                                excelWorksheetStocktake.Cells["A2"].StyleName = "Arial";
                                excelWorksheetStocktake.Cells["A2"].Style.Font.Size = headerFontSize;
                                excelWorksheetStocktake.Cells["A2"].Style.Font.Bold = true;
                                excelWorksheetStocktake.Cells["A2"].Value = excelWorksheetFrames.Cells["A2"].Value;

                                excelWorksheetStocktake.Cells["A3"].StyleName = "Arial";
                                excelWorksheetStocktake.Cells["A3"].Style.Font.Size = headerFontSize;
                                excelWorksheetStocktake.Cells["A3"].Style.Font.Bold = true;
                                string periodStart = DateTime.Today.Day + " " + Months[DateTime.Today.Month - 1] + " " + DateTime.Today.Year;
                                string periodEnd = DateTime.Today.Day + " " + Months[DateTime.Today.Month - 1] + " " + DateTime.Today.Year;
                                excelWorksheetStocktake.Cells["A3"].Value = "For the period " + periodStart + " to " + periodEnd;

                                excelWorksheetStocktake.Cells["A4"].StyleName = "Arial";
                                excelWorksheetStocktake.Cells["A4"].Style.Font.Size = headerFontSize;
                                excelWorksheetStocktake.Cells["A4"].Style.Font.Bold = true;
                                excelWorksheetStocktake.Cells["A4"].Value = excelWorksheetFrames.Cells["A4"].Value;

                                excelWorksheetStocktake.Cells["B4"].StyleName = "Arial";
                                excelWorksheetStocktake.Cells["B4"].Style.Font.Size = headerFontSize;
                                excelWorksheetStocktake.Cells["B4"].Style.Font.Bold = true;
                                excelWorksheetStocktake.Cells["B4"].Value = excelWorksheetFrames.Cells["B4"].Value;

                                excelWorksheetStocktake.Cells["C4"].StyleName = "Arial";
                                excelWorksheetStocktake.Cells["C4"].Style.Font.Size = headerFontSize;
                                excelWorksheetStocktake.Cells["C4"].Style.Font.Bold = true;
                                excelWorksheetStocktake.Cells["C4"].Value = excelWorksheetFrames.Cells["C4"].Value;

                                excelWorksheetStocktake.Cells["D4"].StyleName = "Arial";
                                excelWorksheetStocktake.Cells["D4"].Style.Font.Size = headerFontSize;
                                excelWorksheetStocktake.Cells["D4"].Style.Font.Bold = true;
                                excelWorksheetStocktake.Cells["D4"].Value = "Counted/Shelf Number";

                                excelWorksheetStocktake.Cells["E4"].StyleName = "Arial";
                                excelWorksheetStocktake.Cells["E4"].Style.Font.Size = headerFontSize;
                                excelWorksheetStocktake.Cells["E4"].Style.Font.Bold = true;
                                excelWorksheetStocktake.Cells["E4"].Value = "Found on Sheet:";




                                /*if (File being used) 
                                {
                                    MessageBox.Show("File being used by another program, close the file to continue.");
                                }
                                else 
                                {
                                    excelPackage.Save();
                                }*/
                                //CHECK IF THE FILE IS OPEN IF IT IS, CLOSE IT
                                try
                                {
                                    excelPackage.Save();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message + "\n" + "File may be open or in use by another program.", "File Saving Error");
                                    return;
                                }



                                worksheets.Add(excelWorksheetStocktake);
                                worksheetsRows.Add(excelWorksheetStocktake.Dimension.End.Row);

                                MessageBox.Show("Stocktake will begin.");
                                /*MessageBox.Show("Returning...");
                                return;*/
                                //DoStocktake(true, worksheets, null);
                                fromStocktake = false;


                                int stockRow = 5;//worksheets[4].Rows.Count() + 1;
                                stockOrScanStocktakeWorksheet = excelWorksheetStocktake;
                                stockOrScanRecordAddedMessage = recordAddedMessage;
                                FromStockTakeOrScanner("StockTake");
                            }
                            else
                            {
                                MessageBox.Show("Use the " + "\"" + btnSTContinue.Text + "\"" + " button. To continue a previous stocktake");
                            }
                        }
                        #endregion

                        #region Continue Stocktake
                        //Search if there is a stocktake sheet for the chosen date
                        if (newContinue == 1)
                        {
                            //TODO CHECK IF THE SHEET ACTUALLY EXISTS
                            bool sheetExists = false;
                            excelWorksheetStocktake = excelWorkBook.Worksheets[stockTakeWorkbookName];
                            if (excelWorksheetStocktake != null)
                            {
                                sheetExists = true;
                            }

                            //Show MessageBox once.
                            var messageBoxResult = (MessageBox.Show("Are you continuing the stocktake for " + dtpSTPreviousStocktake.Text + "?", "New Stocktake or Continue", MessageBoxButtons.YesNo));

                            if ((messageBoxResult == DialogResult.Yes) && (sheetExists == true))
                            {
                                //Update the Stocktake period
                                excelWorksheetStocktake.Cells["A3"].StyleName = "Arial";
                                excelWorksheetStocktake.Cells["A3"].Style.Font.Size = headerFontSize;
                                excelWorksheetStocktake.Cells["A3"].Style.Font.Bold = true;

                                string periodStart = stockTakeWorkbookName.Substring(10); //What was on the existing thing [Name of sheet][Stocktake 16 February 2023]
                                string periodEnd = DateTime.Today.Day + " " + Months[DateTime.Today.Month - 1] + " " + DateTime.Today.Year;

                                excelWorksheetStocktake.Cells["A3"].Value = "For the period " + periodStart + " to " + periodEnd;


                                //CHECK IF THE FILE IS OPEN IF IT IS, CLOSE IT
                                try
                                {
                                    excelPackage.Save();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message + "\n" + "File may be open or in use by another program.", "File Saving Error");
                                    return;
                                }

                                MessageBox.Show("Stocktake will continue...");
                                fromStocktake = false;


                                int stockRow = 5;//worksheets[4].Rows.Count() + 1;
                                stockOrScanStocktakeWorksheet = excelWorksheetStocktake;
                                stockOrScanRecordAddedMessage = recordAddedMessage;
                                FromStockTakeOrScanner("StockTake");
                            }
                            else if((messageBoxResult == DialogResult.Yes) && (sheetExists == false))
                            {
                                MessageBox.Show("A Stocktake sheet for selected date doesn't exists." + "\n" +"Use the " + "\"" + btnSTNewStocktake.Text + "\"" + " button. To start a new Stocktake.", "Sheet not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else 
                            {
                                MessageBox.Show("Stocktake aborted", "Process Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        #endregion


                        //string periodCellValue = stocktakeWorksheet.Cells["A3"].Value;

                    }
                }
                else
                {
                    MessageBox.Show("\"" + fileExtension + "\"" + "Wrong File Extension only .xlsx allowed", "FileType Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        
        ExcelWorksheet stockOrScanStocktakeWorksheet;
        string stockOrScanRecordAddedMessage;
        int debugItemCount = 0;
        private void FromStockTakeOrScanner(string location,  string localScannedQR = "")
        {
            if (location == "StockTake") 
            {
                //Display the Scannerscreen
                //Navigating from stocktake tabsheet
                TabPage previousTab = tabControl.SelectedTab;
                tabControl.SelectedTab = tbsScanQR;
            }
            else if (location == "Scanner")
            {
              
                excelPackage = new ExcelPackage(fileName);
                using (excelPackage)
                {
                    //Set Excel Variables
                    ExcelWorkbook excelWorkBook = excelPackage.Workbook;
                    ExcelWorksheet excelWorksheetInventoryItemSummary = excelWorkBook.Worksheets["Inventory Item Summary"];
                    ExcelWorksheet excelWorksheetFrames = excelWorkBook.Worksheets["FRAMES"];
                    ExcelWorksheet excelWorksheetSunglasses = excelWorkBook.Worksheets["SUN"];
                    ExcelWorksheet excelWorksheetSolutions = excelWorkBook.Worksheets["SOLUTION"];
                    ExcelWorksheet excelWorksheetStocktake = excelWorkBook.Worksheets[stockOrScanStocktakeWorksheet.Name];

                    worksheets.Clear();
                    worksheets.Add(excelWorksheetInventoryItemSummary);
                    worksheets.Add(excelWorksheetFrames);
                    worksheets.Add(excelWorksheetSunglasses);
                    worksheets.Add(excelWorksheetSolutions);
                    worksheets.Add(excelWorksheetStocktake);
                    stocktakeSheetIndex = 4;

                    worksheetsRows.Clear();
                    worksheetsRows.Add(excelWorksheetInventoryItemSummary.Dimension.End.Row);
                    worksheetsRows.Add(excelWorksheetFrames.Dimension.End.Row);
                    worksheetsRows.Add(excelWorksheetSunglasses.Dimension.End.Row);
                    worksheetsRows.Add(excelWorksheetSolutions.Dimension.End.Row);
                    worksheetsRows.Add(excelWorksheetStocktake.Dimension.End.Row);

                    if (MessageBox.Show("Is the code you are scanning " + "\"" + txtScanQRCode.Text +"\"" + "?", "Itemcode Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                    {
                        int sheetCounter = 0;
                        bool isBlank = false;
                        int rowCounter;
                        int totalRows = worksheetsRows[sheetCounter];
                        string currentCell = "";

                        string foundedSheets = "";
                        string itemName = "";
                        float closingQuantity = -1f;
                        bool foundOnStocktake = false;


                        //Search 4 sheets for itemcode
                        for (int i = 0; i < worksheets.Count; i++)
                        {
                            bool hasFoundQR = false;
                            currentCell = "";

                            rowCounter = 1;
                            while (rowCounter < totalRows && hasFoundQR == false)
                            {
                                currentCell = "A" + rowCounter.ToString();
                                string nameCell = "B" + rowCounter.ToString();
                                string closingQuantityCell = "C" + rowCounter.ToString();
                                //Have found the Item code
                                if (worksheets[i].Cells[currentCell].Value == null)
                                {
                                    rowCounter++;
                                    continue;
                                }
                                if (worksheets[i].Cells[currentCell].Value.ToString() == localScannedQR)
                                {
                                    hasFoundQR = true;
                                    itemName = worksheets[i].Cells[nameCell].Value.ToString();
                                    string seperator;

                                    if (foundedSheets == "")
                                    {
                                        seperator = "";
                                    }
                                    else
                                    {
                                        seperator = "/";
                                    }

                                    //POSSIBLE TODO GET THE REGIONAL FORMAT SEPERATOR FOR THE CLOSINGQUANTITYCELL
                                    if (sheetCounter == 0)
                                    {
                                        foundedSheets = foundedSheets + seperator + "InventoryItemSummary";
                                        worksheets[i].Cells[closingQuantityCell].Style.Numberformat.Format = "#,##0.0000";
                                        worksheets[i].Cells[closingQuantityCell].StyleName = "Arial";
                                        worksheets[i].Cells[closingQuantityCell].Style.Font.Size = contentFontSize;
                                        closingQuantity = float.Parse(worksheets[i].Cells[closingQuantityCell].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);//ToString() does not allow for formatting
                                        //closingQuantity = worksheets[i].Cells[closingQuantityCell].Value;//ToString() does not allow for formatting
                                    }
                                    else if (sheetCounter == 1)
                                    {
                                        foundedSheets = foundedSheets + seperator + "Frames";
                                        worksheets[i].Cells[closingQuantityCell].Style.Numberformat.Format = "#,##0.0000";
                                        worksheets[i].Cells[closingQuantityCell].StyleName = "Arial";
                                        worksheets[i].Cells[closingQuantityCell].Style.Font.Size = contentFontSize;
                                        closingQuantity = float.Parse(worksheets[i].Cells[closingQuantityCell].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);//ToString() does not allow for formatting
                                        //closingQuantity = worksheets[i].Cells[closingQuantityCell].Value;//ToString() does not allow for formatting
                                    }
                                    else if (sheetCounter == 2)
                                    {
                                        foundedSheets = foundedSheets + seperator + "Sunglasses";
                                        worksheets[i].Cells[closingQuantityCell].Style.Numberformat.Format = "#,##0.0000";
                                        worksheets[i].Cells[closingQuantityCell].StyleName = "Arial";
                                        worksheets[i].Cells[closingQuantityCell].Style.Font.Size = contentFontSize;
                                        closingQuantity = float.Parse(worksheets[i].Cells[closingQuantityCell].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);//ToString() does not allow for formatting
                                        //closingQuantity = worksheets[i].Cells[closingQuantityCell].Value;//ToString() does not allow for formatting
                                    }
                                    else if (sheetCounter == 3)
                                    {
                                        foundedSheets = foundedSheets + seperator + "Solutions";
                                        worksheets[i].Cells[closingQuantityCell].Style.Numberformat.Format = "#,##0.0000";
                                        worksheets[i].Cells[closingQuantityCell].StyleName = "Arial";
                                        worksheets[i].Cells[closingQuantityCell].Style.Font.Size = contentFontSize;
                                        closingQuantity = float.Parse(worksheets[i].Cells[closingQuantityCell].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);//ToString() does not allow for formatting
                                    }

                                    //Found on Stocktake Sheet
                                    else if (sheetCounter == stocktakeSheetIndex)
                                    {
                                        //Increase counted quantity
                                        excelWorksheetStocktake.Cells["D" + rowCounter].Value = Convert.ToInt32(excelWorksheetStocktake.Cells["D" + rowCounter].Value) + 1;//Counted Quantity
                                        worksheets[i].Cells[closingQuantityCell].Style.Numberformat.Format = "#,##0.0000";
                                        worksheets[i].Cells[closingQuantityCell].StyleName = "Arial";
                                        worksheets[i].Cells[closingQuantityCell].Style.Font.Size = contentFontSize;
                                        closingQuantity = Convert.ToInt32(worksheets[i].Cells[closingQuantityCell].Value);//ToString() does not allow for formatting
                                        foundOnStocktake = true;
                                        //MessageBox.Show("Item already on stocktake sheet. " + "\n" + "\"" + "foundOnStocktake variable is: " + "\"" + foundOnStocktake);
                                        //TODO TOGGLE A BOOL THAT STOPS THE "i == stockTakeIndex" INNER IF STATEMENT FROM RUNNING
                                    }
                                }
                                rowCounter++;
                            }
                            sheetCounter++;
                        }

                        //Populate the new Row to the stocktake sheet
                        if (foundOnStocktake == false)
                        {
                            //Search for Blank Row
                            rowCounter = 1;
                            currentCell = "A" + rowCounter.ToString();
                            //Add a new Row to the stocktake sheet
                            while (rowCounter <= totalRows + 1 && isBlank == false)
                            {
                                currentCell = "A" + rowCounter.ToString();
                                if (excelWorksheetStocktake.Cells[currentCell].Value == null && rowCounter > 4) //TODO revisit rowCounter > 4 parameter
                                {
                                    isBlank = true;
                                    stockRow = rowCounter;
                                    //MessageBox.Show("Found blank Row at: " + stockRow);
                                }
                                rowCounter++;
                            }

                            //add all details to stocktake worksheet and a tab that says what rack, if it was fiund on another sheet.
                            excelWorksheetStocktake.Cells["A" + stockRow].StyleName = "Arial";
                            excelWorksheetStocktake.Cells["A" + stockRow].Style.Font.Size = contentFontSize;
                            excelWorksheetStocktake.Cells["A" + stockRow].Value = localScannedQR;//itemCode

                            excelWorksheetStocktake.Cells["B" + stockRow].StyleName = "Arial";
                            excelWorksheetStocktake.Cells["B" + stockRow].Style.Font.Size = contentFontSize;
                            excelWorksheetStocktake.Cells["B" + stockRow].Value = itemName;//ItemName

                            excelWorksheetStocktake.Cells["C" + stockRow].Style.Numberformat.Format = "#.####0,0000";//Closing Quantity Formatting
                            string closingQuantityString = "";
                            if (closingQuantity == -1f) 
                            {
                                closingQuantityString = Interaction.InputBox("Enter the closing quantity for " + itemName, "Closing Quantity", "0");
                                closingQuantity = float.Parse(closingQuantityString, CultureInfo.InvariantCulture.NumberFormat);//ToString() does not allow for formatting
                            }
                            else 
                            {
                                excelWorksheetStocktake.Cells["C" + stockRow].StyleName = "Arial";
                                excelWorksheetStocktake.Cells["C" + stockRow].Style.Font.Size = contentFontSize;
                                excelWorksheetStocktake.Cells["C" + stockRow].Value = closingQuantity;//Closing Quantity
                            }

                            excelWorksheetStocktake.Cells["D" + stockRow].StyleName = "Arial";
                            excelWorksheetStocktake.Cells["D" + stockRow].Style.Font.Size = contentFontSize;
                            excelWorksheetStocktake.Cells["D" + stockRow].Value = Convert.ToInt32(worksheets[4].Cells["D" + stockRow].Value) + 1;//Counted Quantity

                            //excelWorksheetStocktake.Cells["E" + stockRow].Value = worksheets[4].Cells["E" + stockRow].Value /*+ Interaction.InputBox("On what rack number was " + itemName + " found?" , "Rack Number", "1");//Rack/Shelf
                            excelWorksheetStocktake.Cells["E" + stockRow].StyleName = "Arial";
                            excelWorksheetStocktake.Cells["E" + stockRow].Style.Font.Size = contentFontSize;
                            excelWorksheetStocktake.Cells["E" + stockRow].Value = foundedSheets;//Found on other sheet
                        }

                        //CHECK IF THE FILE IS OPEN IF IT IS, CLOSE IT
                        try
                        {
                            excelPackage.Save();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\n" + "File may be open or in use by another program.", "File Saving Error");
                            return;
                        }
                        MessageBox.Show(stockOrScanRecordAddedMessage);
                    }
                    else 
                    {
                        //MessageBox Message, MessageBox Caption, MessageBox Buttons, MessageBox Icon
                        MessageBox.Show("\"" + txtScanQRCode.Text + "\"" + " not added to the database. Press the " + "\"" + "Prime Scanner" + "\"" + " button and rescan the correct QR code to continue.", "QR scan cancelled.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    

                    debugItemCount++;
                }

            }
        }

        private void TerminateApplication()
        {
            try { excelPackage.Save(); }
            catch { }
            
            Application.Exit();
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
            btnGenSaveToPDF.Enabled = true;
        }

        private void btnBugStockTake_Click(object sender, EventArgs e)
        {
            string result = "T-FRA-CUB-3127-002";
            //DoStocktake(false, worksheets, result);
        }





#endregion


    }
}
