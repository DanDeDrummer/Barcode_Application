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
        List<String> Months = new List<string> { "j", "f", "m", "a", "m", "jun", "jul", "aug", "Septem", "Oct", "Nov", "Dec"};
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

            foreach (FilterInfo device in filterInfoCollection)
            {
                cbbScanCameraList.Items.Add(device.Name);
                cbbScanCameraList.SelectedIndex = 0;
            }

            //Hide Unnessisary Tabsheets
            tabControl.TabPages.Remove(tbsAddRemoveFromDatabase);
            tabControl.TabPages.Remove(tbsSale);
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

            if (result != null)
            {
                txtScanQRCode.Invoke(new MethodInvoker(delegate ()
                {
                    txtScanQRCode.Text = result.ToString();

                    //Search DB for code
                    DoStocktake(false, worksheets, result.ToString());
                }));
            }
            picbxScanImage.Image = bitmap;
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

        private void btnGenPrint_Click(object sender, EventArgs e)
        {
            prntDlg.Document = prntDoc;
            //printedImage = QRImages[0];

            if (QRImages.Count > 0)
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

        #region Stock Take

        private void btnSTOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Select the correct excell File
                string fileName = openFileDialog1.FileName;

                int k = fileName.Length;
                string fileExtension = "";

                while (fileName[k] != '.')
                {
                    fileExtension = fileExtension + fileName[k];
                }

                if (fileExtension == ".xlsx")
                {
                    using (ExcelPackage excelPackage = new ExcelPackage(fileName))
                    {
                        //Set Excel Variables
                        ExcelWorkbook excelWorkBook = excelPackage.Workbook;
                        ExcelWorksheet excelWorksheetInventoryItemSummary = excelWorkBook.Worksheets[0];
                        ExcelWorksheet excelWorksheetFrames = excelWorkBook.Worksheets[1];
                        ExcelWorksheet excelWorksheetSunglasses = excelWorkBook.Worksheets[2];
                        ExcelWorksheet excelWorksheetSolutions = excelWorkBook.Worksheets[3];

                        MessageBox.Show("Worksheet 0 : " + excelWorksheetInventoryItemSummary.Name + "\n" + "Worksheet 1 : " + excelWorksheetFrames.Name
                            + "\n" + "Worksheet 2 : " + excelWorksheetSunglasses.Name + "\n" + "Worksheet 3 : " + excelWorksheetSolutions.Name);

                        if (MessageBox.Show("Is this the first stocktake this month?", "New Stocktake or Continue", MessageBoxButtons.YesNo) == DialogResult.Yes) //It is the first time this stocktake is happening
                        {
                            stocktakeWorksheet = excelWorkBook.Worksheets.Add("Stocktake " + DateTime.Today);
                            stocktakeWorksheet.Cells["A1"].Value = "Stocktake " + DateTime.Today;
                        }
                        //else
                        //Set last sheet as active sheet

                        //Scan with phone
                        //Search 4 sheets for itemcode
                        //add all details to stocktake worksheet and a tab that says what rack, if it was fiund on another sheet.
                    }
                }
                else
                {
                    MessageBox.Show("Wrong File Type only .xlsx allowed", "FileType Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }




            }

            /*
             * OpenFileDialog openfileDialog1 = new OpenFileDialog();
  if (openfileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
  {
    this.btnChoose2.Text = openfileDialog1.FileName;
    String filename = DialogResult.ToString();

    var excelApp = new Excel.Application();
    excelApp.Visible = true;
    excelApp.Workbooks.Open(btnChoose2.Text);
            //The excel does not show without excelApp.Visible = true. 
  }
             */
        }

        ExcelWorksheet stocktakeWorksheet;
        string scannedQR = "T-FRA-AHI-1431-07A";
        ExcelPackage excelPackage;
        bool fromStocktake = false;
        private void btnSTNewStocktake_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Select the correct excell File
                string fileName = openFileDialog1.FileName;

                int k = fileName.Length - 1;
                string fileExtension = "";

                for (int i = 1; i < fileName.Length; i++)
                {
                    if(fileName[i] == '.') 
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
                    using (excelPackage = new ExcelPackage(fileName))
                    {
                        //Set Excel Variables
                        ExcelWorkbook excelWorkBook = excelPackage.Workbook;
                        ExcelWorksheet excelWorksheetInventoryItemSummary = excelWorkBook.Worksheets[0];
                        ExcelWorksheet excelWorksheetFrames = excelWorkBook.Worksheets[1];
                        ExcelWorksheet excelWorksheetSunglasses = excelWorkBook.Worksheets[2];
                        ExcelWorksheet excelWorksheetSolutions = excelWorkBook.Worksheets[3];
                        ExcelWorksheet excelWorksheetStocktake;

                        worksheets.Add(excelWorksheetInventoryItemSummary);
                        worksheets.Add(excelWorksheetFrames);
                        worksheets.Add(excelWorksheetSunglasses);
                        worksheets.Add(excelWorksheetSolutions);

                        worksheetsRows.Add(excelWorksheetInventoryItemSummary.Dimension.End.Row);
                        worksheetsRows.Add(excelWorksheetFrames.Dimension.End.Row);
                        worksheetsRows.Add(excelWorksheetSunglasses.Dimension.End.Row);
                        worksheetsRows.Add(excelWorksheetSolutions.Dimension.End.Row);



                        MessageBox.Show("Worksheet 0 : " + excelWorksheetInventoryItemSummary.Name + "\n" + "Worksheet 1 : " + excelWorksheetFrames.Name
                            + "\n" + "Worksheet 2 : " + excelWorksheetSunglasses.Name + "\n" + "Worksheet 3 : " + excelWorksheetSolutions.Name);

                        if (MessageBox.Show("Is this the first stocktake this month?", "New Stocktake or Continue", MessageBoxButtons.YesNo) == DialogResult.Yes) //It is the first time this stocktake is happening
                        {
                            string stockWBName = "Stocktake " + DateTime.Today.Day + " " + Months[DateTime.Today.Month - 1] + " " + DateTime.Today.Year;
                            if (excelWorkBook.Worksheets[4] != null)
                            {
                                excelWorksheetStocktake = excelWorkBook.Worksheets.Add("Stocktake " + DateTime.Today.Day + " " + Months[DateTime.Today.Month - 1] + " " + DateTime.Today.Year);
                            }
                            else 
                            {
                                excelWorksheetStocktake = excelWorkBook.Worksheets[4];
                            }
                            
                            excelWorksheetStocktake.Cells["A1"].Value = "Stocktake " + DateTime.Today;
                            excelWorksheetStocktake.Cells["A2"].Value = excelWorksheetFrames.Cells["A2"].Value;
                            string periodStart = DateTime.Today.Day + " " + Months[DateTime.Today.Month - 1] + " " + DateTime.Today.Year;
                            string periodEnd = DateTime.Today.Day + " " + Months[DateTime.Today.Month - 1] + " " + DateTime.Today.Year;
                            excelWorksheetStocktake.Cells["A3"].Value = "For the period " + periodStart + " to " + periodEnd;
                            excelWorksheetStocktake.Cells["A4"].Value = excelWorksheetFrames.Cells["A4"].Value;
                            excelWorksheetStocktake.Cells["B4"].Value = excelWorksheetFrames.Cells["B4"].Value;
                            excelWorksheetStocktake.Cells["C4"].Value = excelWorksheetFrames.Cells["C4"].Value;
                            excelWorksheetStocktake.Cells["D4"].Value = "Counted/Shelf Number";

                            excelPackage.Save();

                            worksheets.Add(excelWorksheetStocktake);
                            worksheetsRows.Add(excelWorksheetStocktake.Dimension.End.Row);

                            MessageBox.Show("Stocktake will begin.");
                            //DoStocktake(true, worksheets, null);
                            fromStocktake = true;


                            int stockRow = 5;//worksheets[4].Rows.Count() + 1;
                            if (fromStocktake == true)
                            {
                                //Navigating from stocktake tabsheet
                                TabPage previousTab = tabControl.SelectedTab;
                                tabControl.SelectedTab = tbsScanQR;
                            }
                            else
                            {
                                int sheetCounter = 0;
                                string foundedSheets = "";
                                string itemName = "";
                                string closingQuantity = "";
                                bool foundOnStocktake = false;

                                //Search 4 sheets for itemcode
                                foreach (var item in worksheets)
                                {
                                    int rowCounter = 1;
                                    bool hasFoundQR = false;
                                    bool isBlank = false;
                                    int totalRows = worksheetsRows[sheetCounter];

                                    while (rowCounter < totalRows || isBlank == false)
                                    {

                                        if (worksheets[4].Cells["A" + rowCounter].Value.ToString() == "")
                                        {
                                            isBlank = true;
                                            MessageBox.Show("Found blank Row at: " + rowCounter);
                                        }
                                        rowCounter++;
                                    }

                                    MessageBox.Show("End Row: " + totalRows.ToString());
                                    return;
                                    
                                    while (rowCounter < totalRows || hasFoundQR == false)
                                    {
                                        string currentCell = "A" + rowCounter.ToString();
                                        string nameCell = "B" + rowCounter.ToString();
                                        string closingQuantityCell = "C" + rowCounter.ToString();
                                        //Have found the Item code
                                        if (item.Cells[currentCell].Value.ToString() == scannedQR)
                                        {
                                            hasFoundQR = true;
                                            itemName = item.Cells[nameCell].Value.ToString();
                                            closingQuantity = item.Cells[closingQuantityCell].Value.ToString();

                                            if (sheetCounter == 0) { foundedSheets = foundedSheets + "InventoryItemSummary" + ", "; }
                                            else if (sheetCounter == 1) { foundedSheets = foundedSheets + "Frames" + ", "; }
                                            else if (sheetCounter == 2) { foundedSheets = foundedSheets + "Sunglasses" + ", "; }
                                            else if (sheetCounter == 3) { foundedSheets = foundedSheets + "Solutions" + ", "; }

                                            //Found on Stocktake Sheet
                                            else if (sheetCounter == 4)
                                            {
                                                //Increase counted quantity
                                                worksheets[4].Cells["D" + stockRow].Value = Convert.ToInt32(worksheets[4].Cells["D" + stockRow].Value) + 1;//Counted Quantity
                                                foundOnStocktake = true;
                                            }
                                        }
                                        rowCounter++;
                                    }
                                    sheetCounter++;
                                }

                                if (foundOnStocktake == false)
                                {
                                    //add all details to stocktake worksheet and a tab that says what rack, if it was fiund on another sheet.
                                    worksheets[4].Cells["A" + stockRow].Value = scannedQR;//itemCode
                                    worksheets[4].Cells["B" + stockRow].Value = itemName;//ItemName
                                    worksheets[4].Cells["C" + stockRow].Value = closingQuantity;
                                    worksheets[4].Cells["D" + stockRow].Value = Convert.ToInt32(worksheets[4].Cells["D" + stockRow].Value) + 1;//Counted Quantity
                                    worksheets[4].Cells["E" + stockRow].Value = worksheets[4].Cells["E" + stockRow].Value /*+ InputBox "What rack was this found*/;//Rack/Shelf
                                    worksheets[4].Cells["F" + stockRow].Value = foundedSheets;//Found on other sheet
                                }
                            }
                        }
                        else
                        {
                            //SetDate
                            DateTime selectedDate = dtpSTPreviousStocktake.Value.Date;
                            //Set last sheet as active sheet
                            excelWorksheetStocktake = excelWorkBook.Worksheets["Stocktake " + selectedDate.Day + Months[selectedDate.Month - 1] + selectedDate.Year];

                            worksheets.Add(excelWorksheetStocktake);
                            worksheetsRows.Add(excelWorksheetStocktake.Dimension.End.Row);

                            MessageBox.Show(excelWorksheetStocktake.Name);
                            return;
                        }

                        //string periodCellValue = stocktakeWorksheet.Cells["A3"].Value;
                        
                    }
                }
                else
                {
                    MessageBox.Show("\"" + fileExtension + "\"" + "Wrong File Extension only .xlsx allowed", "FileType Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void DoStocktake(bool fromStocktake, List<ExcelWorksheet> worksheets, string scannedQR)
        {
            int stockRow = 5;//worksheets[4].Rows.Count() + 1;
            if (fromStocktake == true) 
            {
                //Navigating from stocktake tabsheet
                TabPage previousTab = tabControl.SelectedTab;
                tabControl.SelectedTab = tbsScanQR;
            }
            else
            {
                int sheetCounter = 0;
                string foundedSheets = "";
                string itemName = "";
                string closingQuantity = "";
                bool foundOnStocktake = false;

                //Search 4 sheets for itemcode
                foreach (var item in worksheets)
                {
                    int rowCounter = 1;
                    bool hasFoundQR = false;
                    bool isBlank = false;
                    int totalRows = worksheetsRows[sheetCounter];

                    while (rowCounter < totalRows || isBlank == false)
                    {
                        
                        if (worksheets[4].Cells["A" + rowCounter].Value.ToString() == "")  
                        {
                            isBlank = true;
                            MessageBox.Show("Found blank Row at: " + rowCounter);
                        }
                        rowCounter++;
                    }

                    MessageBox.Show("End Row: " + totalRows.ToString());
                    return;
                    while (rowCounter < totalRows || hasFoundQR == false)
                    {
                        string currentCell = "A" + rowCounter.ToString();
                        string nameCell = "B" + rowCounter.ToString();
                        string closingQuantityCell = "C" + rowCounter.ToString();
                        //Have found the Item code
                        if (item.Cells[currentCell].Value.ToString() == scannedQR )
                        {
                            hasFoundQR = true;
                            itemName = item.Cells[nameCell].Value.ToString();
                            closingQuantity = item.Cells[closingQuantityCell].Value.ToString();

                            if (sheetCounter == 0) { foundedSheets = foundedSheets + "InventoryItemSummary" + ", "; }
                            else if (sheetCounter == 1) { foundedSheets = foundedSheets + "Frames" + ", "; }
                            else if (sheetCounter == 2) { foundedSheets = foundedSheets + "Sunglasses" + ", "; }
                            else if (sheetCounter == 3) { foundedSheets = foundedSheets + "Solutions" + ", "; }

                            //Found on Stocktake Sheet
                            else if(sheetCounter == 4) 
                            {
                                //Increase counted quantity
                                worksheets[4].Cells["D" + stockRow].Value = Convert.ToInt32(worksheets[4].Cells["D" + stockRow].Value) + 1;//Counted Quantity
                                foundOnStocktake = true;
                            }
                        }
                        rowCounter++;
                    }
                    sheetCounter++;
                }

                if(foundOnStocktake == false) 
                {
                    //add all details to stocktake worksheet and a tab that says what rack, if it was fiund on another sheet.
                    worksheets[4].Cells["A" + stockRow].Value = scannedQR;//itemCode
                    worksheets[4].Cells["B" + stockRow].Value = itemName;//ItemName
                    worksheets[4].Cells["C" + stockRow].Value = closingQuantity;
                    worksheets[4].Cells["D" + stockRow].Value = Convert.ToInt32(worksheets[4].Cells["D" + stockRow].Value) + 1;//Counted Quantity
                    worksheets[4].Cells["E" + stockRow].Value = worksheets[4].Cells["E" + stockRow].Value /*+ InputBox "What rack was this found*/;//Rack/Shelf
                    worksheets[4].Cells["F" + stockRow].Value = foundedSheets;//Found on other sheet
                }
            }
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

        private void btnBugStockTake_Click(object sender, EventArgs e)
        {
            string result = "T-FRA-CUB-3127-002";
            DoStocktake(false, worksheets, result);
        }




        #endregion


    }
}
