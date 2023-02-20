
namespace Barcode_Application
{
    partial class frmBarcodeApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarcodeApplication));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbsWelcome = new System.Windows.Forms.TabPage();
            this.btnWelClose = new System.Windows.Forms.Button();
            this.btnWelStocktake = new System.Windows.Forms.Button();
            this.btnWelAddRemoveDB = new System.Windows.Forms.Button();
            this.btnWelSale = new System.Windows.Forms.Button();
            this.btnWelScan = new System.Windows.Forms.Button();
            this.lblWelHead = new System.Windows.Forms.Label();
            this.btnWelGenerate = new System.Windows.Forms.Button();
            this.tbsGenerateQR = new System.Windows.Forms.TabPage();
            this.progBarGenSaveQR = new System.Windows.Forms.ProgressBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.lblGenQRCodeOut = new System.Windows.Forms.Label();
            this.btnGenSaveToPDF = new System.Windows.Forms.Button();
            this.btnGenBack = new System.Windows.Forms.Button();
            this.lblGenProductCode = new System.Windows.Forms.Label();
            this.picbxGenImage = new System.Windows.Forms.PictureBox();
            this.txtGenQRCode = new System.Windows.Forms.TextBox();
            this.lblGenQRCodeHead = new System.Windows.Forms.Label();
            this.btnGenGenerate = new System.Windows.Forms.Button();
            this.tbsScanQR = new System.Windows.Forms.TabPage();
            this.btnPrimeScanner = new System.Windows.Forms.Button();
            this.btnBugStockTake = new System.Windows.Forms.Button();
            this.btnScanBack = new System.Windows.Forms.Button();
            this.cbbScanCameraList = new System.Windows.Forms.ComboBox();
            this.lblScanProductCode = new System.Windows.Forms.Label();
            this.txtScanQRCode = new System.Windows.Forms.TextBox();
            this.picbxScanImage = new System.Windows.Forms.PictureBox();
            this.lblScanCameraHead = new System.Windows.Forms.Label();
            this.btnScanScan = new System.Windows.Forms.Button();
            this.tbsSale = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTODO = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblSaleHold = new System.Windows.Forms.Label();
            this.cbbSaleHold = new System.Windows.Forms.ComboBox();
            this.tbsAddRemoveFromDatabase = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnARGenerateItemCode = new System.Windows.Forms.Button();
            this.numUDARItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbxARItemColor = new System.Windows.Forms.TextBox();
            this.tbxARItemName = new System.Windows.Forms.TextBox();
            this.cbbARItemBrand = new System.Windows.Forms.ComboBox();
            this.cbbARItemType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblARItemQuantity = new System.Windows.Forms.Label();
            this.lblARItemColor = new System.Windows.Forms.Label();
            this.lblARItemName = new System.Windows.Forms.Label();
            this.lblARItemBrand = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblARItemType = new System.Windows.Forms.Label();
            this.btnARAddToDB = new System.Windows.Forms.Button();
            this.pnlARSerialBack = new System.Windows.Forms.Panel();
            this.lblARDash4 = new System.Windows.Forms.Label();
            this.lblARDash2 = new System.Windows.Forms.Label();
            this.lblARDash3 = new System.Windows.Forms.Label();
            this.lblARDash1 = new System.Windows.Forms.Label();
            this.tbxARItemCodeBrand = new System.Windows.Forms.TextBox();
            this.tbxARItemCodeType = new System.Windows.Forms.TextBox();
            this.tbxARItemCodeColor = new System.Windows.Forms.TextBox();
            this.tbxARItemCodeName = new System.Windows.Forms.TextBox();
            this.tbxARItemCodeT = new System.Windows.Forms.TextBox();
            this.lblARItemCodeHead = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbsStockTake = new System.Windows.Forms.TabPage();
            this.cbxSTDebugMode = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dtpSTPreviousStocktake = new System.Windows.Forms.DateTimePicker();
            this.btnSTContinue = new System.Windows.Forms.Button();
            this.btnSTNewStocktake = new System.Windows.Forms.Button();
            this.prntDoc = new System.Drawing.Printing.PrintDocument();
            this.prntPrvDlg = new System.Windows.Forms.PrintPreviewDialog();
            this.prntDlg = new System.Windows.Forms.PrintDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblFileReminder = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tbsWelcome.SuspendLayout();
            this.tbsGenerateQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxGenImage)).BeginInit();
            this.tbsScanQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxScanImage)).BeginInit();
            this.tbsSale.SuspendLayout();
            this.tbsAddRemoveFromDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDARItemQuantity)).BeginInit();
            this.pnlARSerialBack.SuspendLayout();
            this.tbsStockTake.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbsWelcome);
            this.tabControl.Controls.Add(this.tbsGenerateQR);
            this.tabControl.Controls.Add(this.tbsScanQR);
            this.tabControl.Controls.Add(this.tbsSale);
            this.tabControl.Controls.Add(this.tbsAddRemoveFromDatabase);
            this.tabControl.Controls.Add(this.tbsStockTake);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(393, 644);
            this.tabControl.TabIndex = 4;
            // 
            // tbsWelcome
            // 
            this.tbsWelcome.Controls.Add(this.btnWelClose);
            this.tbsWelcome.Controls.Add(this.btnWelStocktake);
            this.tbsWelcome.Controls.Add(this.btnWelAddRemoveDB);
            this.tbsWelcome.Controls.Add(this.btnWelSale);
            this.tbsWelcome.Controls.Add(this.btnWelScan);
            this.tbsWelcome.Controls.Add(this.lblWelHead);
            this.tbsWelcome.Controls.Add(this.btnWelGenerate);
            this.tbsWelcome.Location = new System.Drawing.Point(4, 22);
            this.tbsWelcome.Name = "tbsWelcome";
            this.tbsWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tbsWelcome.Size = new System.Drawing.Size(385, 618);
            this.tbsWelcome.TabIndex = 0;
            this.tbsWelcome.Text = "Welcome";
            this.tbsWelcome.UseVisualStyleBackColor = true;
            // 
            // btnWelClose
            // 
            this.btnWelClose.Location = new System.Drawing.Point(20, 224);
            this.btnWelClose.Name = "btnWelClose";
            this.btnWelClose.Size = new System.Drawing.Size(345, 30);
            this.btnWelClose.TabIndex = 17;
            this.btnWelClose.Text = "Close";
            this.btnWelClose.UseVisualStyleBackColor = true;
            this.btnWelClose.Click += new System.EventHandler(this.btnWelClose_Click);
            // 
            // btnWelStocktake
            // 
            this.btnWelStocktake.Location = new System.Drawing.Point(22, 44);
            this.btnWelStocktake.Name = "btnWelStocktake";
            this.btnWelStocktake.Size = new System.Drawing.Size(345, 30);
            this.btnWelStocktake.TabIndex = 16;
            this.btnWelStocktake.Text = "Stock Take";
            this.btnWelStocktake.UseVisualStyleBackColor = true;
            this.btnWelStocktake.Click += new System.EventHandler(this.btnWelStocktake_Click);
            // 
            // btnWelAddRemoveDB
            // 
            this.btnWelAddRemoveDB.Enabled = false;
            this.btnWelAddRemoveDB.Location = new System.Drawing.Point(22, 284);
            this.btnWelAddRemoveDB.Name = "btnWelAddRemoveDB";
            this.btnWelAddRemoveDB.Size = new System.Drawing.Size(345, 30);
            this.btnWelAddRemoveDB.TabIndex = 15;
            this.btnWelAddRemoveDB.Text = "Add/Remove From Database";
            this.btnWelAddRemoveDB.UseVisualStyleBackColor = true;
            this.btnWelAddRemoveDB.Visible = false;
            this.btnWelAddRemoveDB.Click += new System.EventHandler(this.btnWelAddRemoveDB_Click);
            // 
            // btnWelSale
            // 
            this.btnWelSale.Enabled = false;
            this.btnWelSale.Location = new System.Drawing.Point(22, 344);
            this.btnWelSale.Name = "btnWelSale";
            this.btnWelSale.Size = new System.Drawing.Size(345, 30);
            this.btnWelSale.TabIndex = 14;
            this.btnWelSale.Text = "Sale";
            this.btnWelSale.UseVisualStyleBackColor = true;
            this.btnWelSale.Visible = false;
            this.btnWelSale.Click += new System.EventHandler(this.btnWelSale_Click);
            // 
            // btnWelScan
            // 
            this.btnWelScan.Enabled = false;
            this.btnWelScan.Location = new System.Drawing.Point(22, 104);
            this.btnWelScan.Name = "btnWelScan";
            this.btnWelScan.Size = new System.Drawing.Size(345, 30);
            this.btnWelScan.TabIndex = 13;
            this.btnWelScan.Text = "Scan QR";
            this.btnWelScan.UseVisualStyleBackColor = true;
            this.btnWelScan.Click += new System.EventHandler(this.btnWelScan_Click);
            // 
            // lblWelHead
            // 
            this.lblWelHead.AutoSize = true;
            this.lblWelHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelHead.Location = new System.Drawing.Point(15, 13);
            this.lblWelHead.Name = "lblWelHead";
            this.lblWelHead.Size = new System.Drawing.Size(224, 22);
            this.lblWelHead.TabIndex = 10;
            this.lblWelHead.Text = "NORKEM OPTOMETRIST";
            this.lblWelHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWelGenerate
            // 
            this.btnWelGenerate.Location = new System.Drawing.Point(22, 164);
            this.btnWelGenerate.Name = "btnWelGenerate";
            this.btnWelGenerate.Size = new System.Drawing.Size(345, 30);
            this.btnWelGenerate.TabIndex = 9;
            this.btnWelGenerate.Text = "Generate QR";
            this.btnWelGenerate.UseVisualStyleBackColor = true;
            this.btnWelGenerate.Click += new System.EventHandler(this.btnWelGenerate_Click);
            // 
            // tbsGenerateQR
            // 
            this.tbsGenerateQR.Controls.Add(this.progBarGenSaveQR);
            this.tbsGenerateQR.Controls.Add(this.numericUpDown1);
            this.tbsGenerateQR.Controls.Add(this.button1);
            this.tbsGenerateQR.Controls.Add(this.lblGenQRCodeOut);
            this.tbsGenerateQR.Controls.Add(this.btnGenSaveToPDF);
            this.tbsGenerateQR.Controls.Add(this.btnGenBack);
            this.tbsGenerateQR.Controls.Add(this.lblGenProductCode);
            this.tbsGenerateQR.Controls.Add(this.picbxGenImage);
            this.tbsGenerateQR.Controls.Add(this.txtGenQRCode);
            this.tbsGenerateQR.Controls.Add(this.lblGenQRCodeHead);
            this.tbsGenerateQR.Controls.Add(this.btnGenGenerate);
            this.tbsGenerateQR.Location = new System.Drawing.Point(4, 22);
            this.tbsGenerateQR.Name = "tbsGenerateQR";
            this.tbsGenerateQR.Padding = new System.Windows.Forms.Padding(3);
            this.tbsGenerateQR.Size = new System.Drawing.Size(385, 618);
            this.tbsGenerateQR.TabIndex = 1;
            this.tbsGenerateQR.Text = "Generate QR";
            this.tbsGenerateQR.UseVisualStyleBackColor = true;
            // 
            // progBarGenSaveQR
            // 
            this.progBarGenSaveQR.Location = new System.Drawing.Point(192, 397);
            this.progBarGenSaveQR.Name = "progBarGenSaveQR";
            this.progBarGenSaveQR.Size = new System.Drawing.Size(172, 23);
            this.progBarGenSaveQR.TabIndex = 18;
            this.progBarGenSaveQR.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(223, 18);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Quick Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGenQRCodeOut
            // 
            this.lblGenQRCodeOut.AutoSize = true;
            this.lblGenQRCodeOut.Location = new System.Drawing.Point(102, 18);
            this.lblGenQRCodeOut.Name = "lblGenQRCodeOut";
            this.lblGenQRCodeOut.Size = new System.Drawing.Size(0, 13);
            this.lblGenQRCodeOut.TabIndex = 15;
            this.lblGenQRCodeOut.Visible = false;
            // 
            // btnGenSaveToPDF
            // 
            this.btnGenSaveToPDF.Enabled = false;
            this.btnGenSaveToPDF.Location = new System.Drawing.Point(19, 540);
            this.btnGenSaveToPDF.Name = "btnGenSaveToPDF";
            this.btnGenSaveToPDF.Size = new System.Drawing.Size(345, 30);
            this.btnGenSaveToPDF.TabIndex = 14;
            this.btnGenSaveToPDF.Text = "Save QR Code(s) to PDF";
            this.btnGenSaveToPDF.UseVisualStyleBackColor = true;
            this.btnGenSaveToPDF.Click += new System.EventHandler(this.btnGenPrint_Click);
            // 
            // btnGenBack
            // 
            this.btnGenBack.Location = new System.Drawing.Point(19, 580);
            this.btnGenBack.Name = "btnGenBack";
            this.btnGenBack.Size = new System.Drawing.Size(345, 30);
            this.btnGenBack.TabIndex = 13;
            this.btnGenBack.Text = "Back";
            this.btnGenBack.UseVisualStyleBackColor = true;
            this.btnGenBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblGenProductCode
            // 
            this.lblGenProductCode.AutoSize = true;
            this.lblGenProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenProductCode.Location = new System.Drawing.Point(15, 401);
            this.lblGenProductCode.Name = "lblGenProductCode";
            this.lblGenProductCode.Size = new System.Drawing.Size(171, 22);
            this.lblGenProductCode.TabIndex = 12;
            this.lblGenProductCode.Text = "Type Product Code:";
            // 
            // picbxGenImage
            // 
            this.picbxGenImage.BackColor = System.Drawing.Color.White;
            this.picbxGenImage.Location = new System.Drawing.Point(22, 44);
            this.picbxGenImage.Name = "picbxGenImage";
            this.picbxGenImage.Size = new System.Drawing.Size(345, 345);
            this.picbxGenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbxGenImage.TabIndex = 11;
            this.picbxGenImage.TabStop = false;
            // 
            // txtGenQRCode
            // 
            this.txtGenQRCode.Location = new System.Drawing.Point(19, 426);
            this.txtGenQRCode.Multiline = true;
            this.txtGenQRCode.Name = "txtGenQRCode";
            this.txtGenQRCode.Size = new System.Drawing.Size(345, 61);
            this.txtGenQRCode.TabIndex = 10;
            // 
            // lblGenQRCodeHead
            // 
            this.lblGenQRCodeHead.AutoSize = true;
            this.lblGenQRCodeHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenQRCodeHead.Location = new System.Drawing.Point(15, 13);
            this.lblGenQRCodeHead.Name = "lblGenQRCodeHead";
            this.lblGenQRCodeHead.Size = new System.Drawing.Size(90, 22);
            this.lblGenQRCodeHead.TabIndex = 9;
            this.lblGenQRCodeHead.Text = "QR Code:";
            // 
            // btnGenGenerate
            // 
            this.btnGenGenerate.Location = new System.Drawing.Point(19, 500);
            this.btnGenGenerate.Name = "btnGenGenerate";
            this.btnGenGenerate.Size = new System.Drawing.Size(345, 30);
            this.btnGenGenerate.TabIndex = 8;
            this.btnGenGenerate.Text = "Generate";
            this.btnGenGenerate.UseVisualStyleBackColor = true;
            this.btnGenGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbsScanQR
            // 
            this.tbsScanQR.Controls.Add(this.btnPrimeScanner);
            this.tbsScanQR.Controls.Add(this.btnBugStockTake);
            this.tbsScanQR.Controls.Add(this.btnScanBack);
            this.tbsScanQR.Controls.Add(this.cbbScanCameraList);
            this.tbsScanQR.Controls.Add(this.lblScanProductCode);
            this.tbsScanQR.Controls.Add(this.txtScanQRCode);
            this.tbsScanQR.Controls.Add(this.picbxScanImage);
            this.tbsScanQR.Controls.Add(this.lblScanCameraHead);
            this.tbsScanQR.Controls.Add(this.btnScanScan);
            this.tbsScanQR.Location = new System.Drawing.Point(4, 22);
            this.tbsScanQR.Name = "tbsScanQR";
            this.tbsScanQR.Padding = new System.Windows.Forms.Padding(3);
            this.tbsScanQR.Size = new System.Drawing.Size(385, 618);
            this.tbsScanQR.TabIndex = 2;
            this.tbsScanQR.Text = "Scan QR";
            this.tbsScanQR.UseVisualStyleBackColor = true;
            this.tbsScanQR.Enter += new System.EventHandler(this.tbsScanQR_Enter);
            // 
            // btnPrimeScanner
            // 
            this.btnPrimeScanner.Location = new System.Drawing.Point(19, 50);
            this.btnPrimeScanner.Name = "btnPrimeScanner";
            this.btnPrimeScanner.Size = new System.Drawing.Size(345, 23);
            this.btnPrimeScanner.TabIndex = 21;
            this.btnPrimeScanner.Text = "Prime Scanner";
            this.btnPrimeScanner.UseVisualStyleBackColor = true;
            this.btnPrimeScanner.Click += new System.EventHandler(this.btnPrimeScanner_Click);
            // 
            // btnBugStockTake
            // 
            this.btnBugStockTake.Location = new System.Drawing.Point(274, 425);
            this.btnBugStockTake.Name = "btnBugStockTake";
            this.btnBugStockTake.Size = new System.Drawing.Size(75, 23);
            this.btnBugStockTake.TabIndex = 20;
            this.btnBugStockTake.Text = "Stocktake Test";
            this.btnBugStockTake.UseVisualStyleBackColor = true;
            this.btnBugStockTake.Visible = false;
            this.btnBugStockTake.Click += new System.EventHandler(this.btnBugStockTake_Click);
            // 
            // btnScanBack
            // 
            this.btnScanBack.Location = new System.Drawing.Point(19, 563);
            this.btnScanBack.Name = "btnScanBack";
            this.btnScanBack.Size = new System.Drawing.Size(345, 30);
            this.btnScanBack.TabIndex = 19;
            this.btnScanBack.Text = "Back";
            this.btnScanBack.UseVisualStyleBackColor = true;
            this.btnScanBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbbScanCameraList
            // 
            this.cbbScanCameraList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbScanCameraList.FormattingEnabled = true;
            this.cbbScanCameraList.Location = new System.Drawing.Point(91, 18);
            this.cbbScanCameraList.Name = "cbbScanCameraList";
            this.cbbScanCameraList.Size = new System.Drawing.Size(276, 21);
            this.cbbScanCameraList.TabIndex = 18;
            // 
            // lblScanProductCode
            // 
            this.lblScanProductCode.AutoSize = true;
            this.lblScanProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanProductCode.Location = new System.Drawing.Point(15, 425);
            this.lblScanProductCode.Name = "lblScanProductCode";
            this.lblScanProductCode.Size = new System.Drawing.Size(125, 22);
            this.lblScanProductCode.TabIndex = 17;
            this.lblScanProductCode.Text = "Product Code:";
            // 
            // txtScanQRCode
            // 
            this.txtScanQRCode.Location = new System.Drawing.Point(19, 450);
            this.txtScanQRCode.Multiline = true;
            this.txtScanQRCode.Name = "txtScanQRCode";
            this.txtScanQRCode.ReadOnly = true;
            this.txtScanQRCode.Size = new System.Drawing.Size(345, 61);
            this.txtScanQRCode.TabIndex = 16;
            // 
            // picbxScanImage
            // 
            this.picbxScanImage.BackColor = System.Drawing.Color.White;
            this.picbxScanImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbxScanImage.Location = new System.Drawing.Point(19, 77);
            this.picbxScanImage.Name = "picbxScanImage";
            this.picbxScanImage.Size = new System.Drawing.Size(345, 345);
            this.picbxScanImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbxScanImage.TabIndex = 14;
            this.picbxScanImage.TabStop = false;
            // 
            // lblScanCameraHead
            // 
            this.lblScanCameraHead.AutoSize = true;
            this.lblScanCameraHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanCameraHead.Location = new System.Drawing.Point(15, 13);
            this.lblScanCameraHead.Name = "lblScanCameraHead";
            this.lblScanCameraHead.Size = new System.Drawing.Size(78, 22);
            this.lblScanCameraHead.TabIndex = 13;
            this.lblScanCameraHead.Text = "Camera:";
            // 
            // btnScanScan
            // 
            this.btnScanScan.Enabled = false;
            this.btnScanScan.Location = new System.Drawing.Point(19, 527);
            this.btnScanScan.Name = "btnScanScan";
            this.btnScanScan.Size = new System.Drawing.Size(345, 30);
            this.btnScanScan.TabIndex = 12;
            this.btnScanScan.Text = "Turn On Scanning Camera";
            this.btnScanScan.UseVisualStyleBackColor = true;
            this.btnScanScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // tbsSale
            // 
            this.tbsSale.Controls.Add(this.button4);
            this.tbsSale.Controls.Add(this.lblTODO);
            this.tbsSale.Controls.Add(this.btnConfirm);
            this.tbsSale.Controls.Add(this.lblSaleHold);
            this.tbsSale.Controls.Add(this.cbbSaleHold);
            this.tbsSale.Location = new System.Drawing.Point(4, 22);
            this.tbsSale.Name = "tbsSale";
            this.tbsSale.Padding = new System.Windows.Forms.Padding(3);
            this.tbsSale.Size = new System.Drawing.Size(385, 618);
            this.tbsSale.TabIndex = 3;
            this.tbsSale.Text = "Sale";
            this.tbsSale.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 539);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(345, 30);
            this.button4.TabIndex = 27;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTODO
            // 
            this.lblTODO.Location = new System.Drawing.Point(17, 63);
            this.lblTODO.Name = "lblTODO";
            this.lblTODO.Size = new System.Drawing.Size(348, 50);
            this.lblTODO.TabIndex = 3;
            this.lblTODO.Text = "Functionality: Scan QR Code, Search DB for ItemCode, Remove/Mark as on Hold accor" +
    "ding to combobox selection optimax system";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(149, 510);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // lblSaleHold
            // 
            this.lblSaleHold.AutoSize = true;
            this.lblSaleHold.Location = new System.Drawing.Point(17, 18);
            this.lblSaleHold.Name = "lblSaleHold";
            this.lblSaleHold.Size = new System.Drawing.Size(102, 13);
            this.lblSaleHold.TabIndex = 1;
            this.lblSaleHold.Text = "Made Sale/On Hold";
            // 
            // cbbSaleHold
            // 
            this.cbbSaleHold.FormattingEnabled = true;
            this.cbbSaleHold.Items.AddRange(new object[] {
            "Sale",
            "On Hold"});
            this.cbbSaleHold.Location = new System.Drawing.Point(134, 18);
            this.cbbSaleHold.Name = "cbbSaleHold";
            this.cbbSaleHold.Size = new System.Drawing.Size(231, 21);
            this.cbbSaleHold.TabIndex = 0;
            // 
            // tbsAddRemoveFromDatabase
            // 
            this.tbsAddRemoveFromDatabase.Controls.Add(this.button2);
            this.tbsAddRemoveFromDatabase.Controls.Add(this.btnARGenerateItemCode);
            this.tbsAddRemoveFromDatabase.Controls.Add(this.numUDARItemQuantity);
            this.tbsAddRemoveFromDatabase.Controls.Add(this.tbxARItemColor);
            this.tbsAddRemoveFromDatabase.Controls.Add(this.tbxARItemName);
            this.tbsAddRemoveFromDatabase.Controls.Add(this.cbbARItemBrand);
            this.tbsAddRemoveFromDatabase.Controls.Add(this.cbbARItemType);
            this.tbsAddRemoveFromDatabase.Controls.Add(this.label1);
            this.tbsAddRemoveFromDatabase.Controls.Add(this.lblARItemQuantity);
            this.tbsAddRemoveFromDatabase.Controls.Add(this.lblARItemColor);
            this.tbsAddRemoveFromDatabase.Controls.Add(this.lblARItemName);
            this.tbsAddRemoveFromDatabase.Controls.Add(this.lblARItemBrand);
            this.tbsAddRemoveFromDatabase.Controls.Add(this.label2);
            this.tbsAddRemoveFromDatabase.Controls.Add(this.lblARItemType);
            this.tbsAddRemoveFromDatabase.Controls.Add(this.btnARAddToDB);
            this.tbsAddRemoveFromDatabase.Controls.Add(this.pnlARSerialBack);
            this.tbsAddRemoveFromDatabase.Controls.Add(this.label5);
            this.tbsAddRemoveFromDatabase.Location = new System.Drawing.Point(4, 22);
            this.tbsAddRemoveFromDatabase.Name = "tbsAddRemoveFromDatabase";
            this.tbsAddRemoveFromDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tbsAddRemoveFromDatabase.Size = new System.Drawing.Size(385, 618);
            this.tbsAddRemoveFromDatabase.TabIndex = 4;
            this.tbsAddRemoveFromDatabase.Text = "Add/Remove from Database";
            this.tbsAddRemoveFromDatabase.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(345, 30);
            this.button2.TabIndex = 26;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnARGenerateItemCode
            // 
            this.btnARGenerateItemCode.Location = new System.Drawing.Point(100, 200);
            this.btnARGenerateItemCode.Name = "btnARGenerateItemCode";
            this.btnARGenerateItemCode.Size = new System.Drawing.Size(75, 23);
            this.btnARGenerateItemCode.TabIndex = 25;
            this.btnARGenerateItemCode.Text = "Generate Item Code";
            this.btnARGenerateItemCode.UseVisualStyleBackColor = true;
            this.btnARGenerateItemCode.Click += new System.EventHandler(this.btnARGenerateItemCode_Click);
            // 
            // numUDARItemQuantity
            // 
            this.numUDARItemQuantity.Location = new System.Drawing.Point(100, 160);
            this.numUDARItemQuantity.Name = "numUDARItemQuantity";
            this.numUDARItemQuantity.Size = new System.Drawing.Size(100, 20);
            this.numUDARItemQuantity.TabIndex = 24;
            // 
            // tbxARItemColor
            // 
            this.tbxARItemColor.Location = new System.Drawing.Point(100, 130);
            this.tbxARItemColor.Name = "tbxARItemColor";
            this.tbxARItemColor.Size = new System.Drawing.Size(100, 20);
            this.tbxARItemColor.TabIndex = 23;
            // 
            // tbxARItemName
            // 
            this.tbxARItemName.Location = new System.Drawing.Point(100, 100);
            this.tbxARItemName.Name = "tbxARItemName";
            this.tbxARItemName.Size = new System.Drawing.Size(260, 20);
            this.tbxARItemName.TabIndex = 22;
            // 
            // cbbARItemBrand
            // 
            this.cbbARItemBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbARItemBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbARItemBrand.FormattingEnabled = true;
            this.cbbARItemBrand.Items.AddRange(new object[] {
            "Perrier Gun",
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
            "Levi\'s",
            "Mango",
            "Max Mara",
            "Modo",
            "Moleskin",
            "Nano",
            "NHI",
            "Nickelodeon Kiddies",
            "Nike",
            "Nomad",
            "Oakly",
            "Oliviero",
            "Outspoken",
            "Pierre Cardin",
            "Polaroid",
            "Polo",
            "Prada",
            "Pro Design",
            "Pull&Bear",
            "Quicksilver",
            "RayBan",
            "Raydon",
            "Ripple",
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
            "WOOW",
            "",
            ""});
            this.cbbARItemBrand.Location = new System.Drawing.Point(100, 70);
            this.cbbARItemBrand.Name = "cbbARItemBrand";
            this.cbbARItemBrand.Size = new System.Drawing.Size(121, 21);
            this.cbbARItemBrand.TabIndex = 21;
            // 
            // cbbARItemType
            // 
            this.cbbARItemType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbARItemType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbARItemType.FormattingEnabled = true;
            this.cbbARItemType.Items.AddRange(new object[] {
            "FRAME",
            "SUNGLASSES",
            "SOLUTIONS"});
            this.cbbARItemType.Location = new System.Drawing.Point(100, 40);
            this.cbbARItemType.Name = "cbbARItemType";
            this.cbbARItemType.Size = new System.Drawing.Size(121, 21);
            this.cbbARItemType.TabIndex = 20;
            this.cbbARItemType.SelectedIndexChanged += new System.EventHandler(this.cbbARItemType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Search functionality by name or code";
            // 
            // lblARItemQuantity
            // 
            this.lblARItemQuantity.AutoSize = true;
            this.lblARItemQuantity.Location = new System.Drawing.Point(22, 164);
            this.lblARItemQuantity.Name = "lblARItemQuantity";
            this.lblARItemQuantity.Size = new System.Drawing.Size(72, 13);
            this.lblARItemQuantity.TabIndex = 18;
            this.lblARItemQuantity.Text = "Item Quantity:";
            // 
            // lblARItemColor
            // 
            this.lblARItemColor.AutoSize = true;
            this.lblARItemColor.Location = new System.Drawing.Point(22, 134);
            this.lblARItemColor.Name = "lblARItemColor";
            this.lblARItemColor.Size = new System.Drawing.Size(57, 13);
            this.lblARItemColor.TabIndex = 17;
            this.lblARItemColor.Text = "Item Color:";
            // 
            // lblARItemName
            // 
            this.lblARItemName.AutoSize = true;
            this.lblARItemName.Location = new System.Drawing.Point(22, 104);
            this.lblARItemName.Name = "lblARItemName";
            this.lblARItemName.Size = new System.Drawing.Size(61, 13);
            this.lblARItemName.TabIndex = 16;
            this.lblARItemName.Text = "Item Name:";
            // 
            // lblARItemBrand
            // 
            this.lblARItemBrand.AutoSize = true;
            this.lblARItemBrand.Location = new System.Drawing.Point(22, 74);
            this.lblARItemBrand.Name = "lblARItemBrand";
            this.lblARItemBrand.Size = new System.Drawing.Size(61, 13);
            this.lblARItemBrand.TabIndex = 15;
            this.lblARItemBrand.Text = "Item Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Add To Database:";
            // 
            // lblARItemType
            // 
            this.lblARItemType.AutoSize = true;
            this.lblARItemType.Location = new System.Drawing.Point(22, 44);
            this.lblARItemType.Name = "lblARItemType";
            this.lblARItemType.Size = new System.Drawing.Size(57, 13);
            this.lblARItemType.TabIndex = 13;
            this.lblARItemType.Text = "Item Type:";
            // 
            // btnARAddToDB
            // 
            this.btnARAddToDB.Enabled = false;
            this.btnARAddToDB.Location = new System.Drawing.Point(100, 300);
            this.btnARAddToDB.Name = "btnARAddToDB";
            this.btnARAddToDB.Size = new System.Drawing.Size(100, 23);
            this.btnARAddToDB.TabIndex = 12;
            this.btnARAddToDB.Text = "Add To Database";
            this.btnARAddToDB.UseVisualStyleBackColor = true;
            this.btnARAddToDB.Click += new System.EventHandler(this.btnARAddToDB_Click);
            // 
            // pnlARSerialBack
            // 
            this.pnlARSerialBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlARSerialBack.Controls.Add(this.lblARDash4);
            this.pnlARSerialBack.Controls.Add(this.lblARDash2);
            this.pnlARSerialBack.Controls.Add(this.lblARDash3);
            this.pnlARSerialBack.Controls.Add(this.lblARDash1);
            this.pnlARSerialBack.Controls.Add(this.tbxARItemCodeBrand);
            this.pnlARSerialBack.Controls.Add(this.tbxARItemCodeType);
            this.pnlARSerialBack.Controls.Add(this.tbxARItemCodeColor);
            this.pnlARSerialBack.Controls.Add(this.tbxARItemCodeName);
            this.pnlARSerialBack.Controls.Add(this.tbxARItemCodeT);
            this.pnlARSerialBack.Controls.Add(this.lblARItemCodeHead);
            this.pnlARSerialBack.Location = new System.Drawing.Point(17, 250);
            this.pnlARSerialBack.Name = "pnlARSerialBack";
            this.pnlARSerialBack.Size = new System.Drawing.Size(350, 37);
            this.pnlARSerialBack.TabIndex = 11;
            // 
            // lblARDash4
            // 
            this.lblARDash4.AutoSize = true;
            this.lblARDash4.Location = new System.Drawing.Point(268, 11);
            this.lblARDash4.Name = "lblARDash4";
            this.lblARDash4.Size = new System.Drawing.Size(10, 13);
            this.lblARDash4.TabIndex = 19;
            this.lblARDash4.Text = "-";
            this.lblARDash4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblARDash2
            // 
            this.lblARDash2.AutoSize = true;
            this.lblARDash2.Location = new System.Drawing.Point(110, 11);
            this.lblARDash2.Name = "lblARDash2";
            this.lblARDash2.Size = new System.Drawing.Size(10, 13);
            this.lblARDash2.TabIndex = 18;
            this.lblARDash2.Text = "-";
            this.lblARDash2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblARDash3
            // 
            this.lblARDash3.AutoSize = true;
            this.lblARDash3.Location = new System.Drawing.Point(148, 11);
            this.lblARDash3.Name = "lblARDash3";
            this.lblARDash3.Size = new System.Drawing.Size(10, 13);
            this.lblARDash3.TabIndex = 17;
            this.lblARDash3.Text = "-";
            this.lblARDash3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblARDash1
            // 
            this.lblARDash1.AutoSize = true;
            this.lblARDash1.Location = new System.Drawing.Point(72, 11);
            this.lblARDash1.Name = "lblARDash1";
            this.lblARDash1.Size = new System.Drawing.Size(10, 13);
            this.lblARDash1.TabIndex = 16;
            this.lblARDash1.Text = "-";
            this.lblARDash1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxARItemCodeBrand
            // 
            this.tbxARItemCodeBrand.Location = new System.Drawing.Point(120, 8);
            this.tbxARItemCodeBrand.Name = "tbxARItemCodeBrand";
            this.tbxARItemCodeBrand.Size = new System.Drawing.Size(28, 20);
            this.tbxARItemCodeBrand.TabIndex = 15;
            this.tbxARItemCodeBrand.Text = "FOS";
            // 
            // tbxARItemCodeType
            // 
            this.tbxARItemCodeType.Location = new System.Drawing.Point(82, 8);
            this.tbxARItemCodeType.Name = "tbxARItemCodeType";
            this.tbxARItemCodeType.Size = new System.Drawing.Size(28, 20);
            this.tbxARItemCodeType.TabIndex = 14;
            this.tbxARItemCodeType.Text = "FRA";
            // 
            // tbxARItemCodeColor
            // 
            this.tbxARItemCodeColor.Location = new System.Drawing.Point(278, 8);
            this.tbxARItemCodeColor.Name = "tbxARItemCodeColor";
            this.tbxARItemCodeColor.Size = new System.Drawing.Size(65, 20);
            this.tbxARItemCodeColor.TabIndex = 13;
            this.tbxARItemCodeColor.Text = "DDDDD";
            // 
            // tbxARItemCodeName
            // 
            this.tbxARItemCodeName.Location = new System.Drawing.Point(158, 8);
            this.tbxARItemCodeName.Name = "tbxARItemCodeName";
            this.tbxARItemCodeName.Size = new System.Drawing.Size(110, 20);
            this.tbxARItemCodeName.TabIndex = 12;
            this.tbxARItemCodeName.Text = "TASASASASASASAT";
            // 
            // tbxARItemCodeT
            // 
            this.tbxARItemCodeT.Location = new System.Drawing.Point(58, 8);
            this.tbxARItemCodeT.Name = "tbxARItemCodeT";
            this.tbxARItemCodeT.Size = new System.Drawing.Size(13, 20);
            this.tbxARItemCodeT.TabIndex = 11;
            this.tbxARItemCodeT.Text = "T";
            // 
            // lblARItemCodeHead
            // 
            this.lblARItemCodeHead.AutoSize = true;
            this.lblARItemCodeHead.Location = new System.Drawing.Point(3, 11);
            this.lblARItemCodeHead.Name = "lblARItemCodeHead";
            this.lblARItemCodeHead.Size = new System.Drawing.Size(58, 13);
            this.lblARItemCodeHead.TabIndex = 10;
            this.lblARItemCodeHead.Text = "Item Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbsStockTake
            // 
            this.tbsStockTake.Controls.Add(this.lblFileReminder);
            this.tbsStockTake.Controls.Add(this.cbxSTDebugMode);
            this.tbsStockTake.Controls.Add(this.button3);
            this.tbsStockTake.Controls.Add(this.dtpSTPreviousStocktake);
            this.tbsStockTake.Controls.Add(this.btnSTContinue);
            this.tbsStockTake.Controls.Add(this.btnSTNewStocktake);
            this.tbsStockTake.Location = new System.Drawing.Point(4, 22);
            this.tbsStockTake.Name = "tbsStockTake";
            this.tbsStockTake.Padding = new System.Windows.Forms.Padding(3);
            this.tbsStockTake.Size = new System.Drawing.Size(385, 618);
            this.tbsStockTake.TabIndex = 5;
            this.tbsStockTake.Text = "Stock Take";
            this.tbsStockTake.UseVisualStyleBackColor = true;
            // 
            // cbxSTDebugMode
            // 
            this.cbxSTDebugMode.AutoSize = true;
            this.cbxSTDebugMode.Checked = true;
            this.cbxSTDebugMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSTDebugMode.Location = new System.Drawing.Point(201, 37);
            this.cbxSTDebugMode.Name = "cbxSTDebugMode";
            this.cbxSTDebugMode.Size = new System.Drawing.Size(88, 17);
            this.cbxSTDebugMode.TabIndex = 29;
            this.cbxSTDebugMode.Text = "Debug Mode";
            this.cbxSTDebugMode.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 539);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(345, 30);
            this.button3.TabIndex = 27;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtpSTPreviousStocktake
            // 
            this.dtpSTPreviousStocktake.Location = new System.Drawing.Point(190, 92);
            this.dtpSTPreviousStocktake.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpSTPreviousStocktake.Name = "dtpSTPreviousStocktake";
            this.dtpSTPreviousStocktake.Size = new System.Drawing.Size(189, 20);
            this.dtpSTPreviousStocktake.TabIndex = 2;
            // 
            // btnSTContinue
            // 
            this.btnSTContinue.Location = new System.Drawing.Point(21, 89);
            this.btnSTContinue.Name = "btnSTContinue";
            this.btnSTContinue.Size = new System.Drawing.Size(163, 23);
            this.btnSTContinue.TabIndex = 1;
            this.btnSTContinue.Text = "Continue Previous Stocktake";
            this.btnSTContinue.UseVisualStyleBackColor = true;
            this.btnSTContinue.Click += new System.EventHandler(this.btnSTContinue_Click);
            // 
            // btnSTNewStocktake
            // 
            this.btnSTNewStocktake.Location = new System.Drawing.Point(19, 33);
            this.btnSTNewStocktake.Name = "btnSTNewStocktake";
            this.btnSTNewStocktake.Size = new System.Drawing.Size(165, 23);
            this.btnSTNewStocktake.TabIndex = 0;
            this.btnSTNewStocktake.Text = "New Stocktake";
            this.btnSTNewStocktake.UseVisualStyleBackColor = true;
            this.btnSTNewStocktake.Click += new System.EventHandler(this.btnSTNewStocktake_Click);
            // 
            // prntDoc
            // 
            this.prntDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prntDoc_PrintPage);
            // 
            // prntPrvDlg
            // 
            this.prntPrvDlg.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prntPrvDlg.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prntPrvDlg.ClientSize = new System.Drawing.Size(400, 300);
            this.prntPrvDlg.Document = this.prntDoc;
            this.prntPrvDlg.Enabled = true;
            this.prntPrvDlg.Icon = ((System.Drawing.Icon)(resources.GetObject("prntPrvDlg.Icon")));
            this.prntPrvDlg.Name = "prntPrvDlg";
            this.prntPrvDlg.Visible = false;
            // 
            // prntDlg
            // 
            this.prntDlg.UseEXDialog = true;
            // 
            // lblFileReminder
            // 
            this.lblFileReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileReminder.Location = new System.Drawing.Point(18, 133);
            this.lblFileReminder.Name = "lblFileReminder";
            this.lblFileReminder.Size = new System.Drawing.Size(354, 31);
            this.lblFileReminder.TabIndex = 30;
            this.lblFileReminder.Text = "Remember to download the sheet file as a \".xlsx\" file first before starting the s" +
    "tocktake.";
            // 
            // frmBarcodeApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 668);
            this.Controls.Add(this.tabControl);
            this.Name = "frmBarcodeApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBarcodeApplication_FormClosing);
            this.Load += new System.EventHandler(this.frmBarcodeApplication_Load);
            this.tabControl.ResumeLayout(false);
            this.tbsWelcome.ResumeLayout(false);
            this.tbsWelcome.PerformLayout();
            this.tbsGenerateQR.ResumeLayout(false);
            this.tbsGenerateQR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxGenImage)).EndInit();
            this.tbsScanQR.ResumeLayout(false);
            this.tbsScanQR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxScanImage)).EndInit();
            this.tbsSale.ResumeLayout(false);
            this.tbsSale.PerformLayout();
            this.tbsAddRemoveFromDatabase.ResumeLayout(false);
            this.tbsAddRemoveFromDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDARItemQuantity)).EndInit();
            this.pnlARSerialBack.ResumeLayout(false);
            this.pnlARSerialBack.PerformLayout();
            this.tbsStockTake.ResumeLayout(false);
            this.tbsStockTake.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbsWelcome;
        private System.Windows.Forms.TabPage tbsGenerateQR;
        private System.Windows.Forms.PictureBox picbxGenImage;
        private System.Windows.Forms.TextBox txtGenQRCode;
        private System.Windows.Forms.Label lblGenQRCodeHead;
        private System.Windows.Forms.Button btnGenGenerate;
        private System.Windows.Forms.Label lblGenProductCode;
        private System.Windows.Forms.TabPage tbsScanQR;
        private System.Windows.Forms.ComboBox cbbScanCameraList;
        private System.Windows.Forms.Label lblScanProductCode;
        private System.Windows.Forms.TextBox txtScanQRCode;
        private System.Windows.Forms.PictureBox picbxScanImage;
        private System.Windows.Forms.Label lblScanCameraHead;
        private System.Windows.Forms.Button btnScanScan;
        private System.Windows.Forms.Button btnGenBack;
        private System.Windows.Forms.Button btnScanBack;
        private System.Windows.Forms.Label lblWelHead;
        private System.Windows.Forms.Button btnWelGenerate;
        private System.Windows.Forms.Button btnWelScan;
        private System.Windows.Forms.Button btnWelSale;
        private System.Windows.Forms.TabPage tbsSale;
        private System.Windows.Forms.Label lblSaleHold;
        private System.Windows.Forms.ComboBox cbbSaleHold;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblTODO;
        private System.Windows.Forms.Button btnGenSaveToPDF;
        private System.Drawing.Printing.PrintDocument prntDoc;
        private System.Windows.Forms.PrintPreviewDialog prntPrvDlg;
        private System.Windows.Forms.PrintDialog prntDlg;
        private System.Windows.Forms.Label lblGenQRCodeOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TabPage tbsAddRemoveFromDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlARSerialBack;
        private System.Windows.Forms.Label lblARDash4;
        private System.Windows.Forms.Label lblARDash2;
        private System.Windows.Forms.Label lblARDash3;
        private System.Windows.Forms.Label lblARDash1;
        private System.Windows.Forms.TextBox tbxARItemCodeBrand;
        private System.Windows.Forms.TextBox tbxARItemCodeType;
        private System.Windows.Forms.TextBox tbxARItemCodeColor;
        private System.Windows.Forms.TextBox tbxARItemCodeName;
        private System.Windows.Forms.TextBox tbxARItemCodeT;
        private System.Windows.Forms.Label lblARItemCodeHead;
        private System.Windows.Forms.Button btnARAddToDB;
        private System.Windows.Forms.Button btnWelAddRemoveDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblARItemType;
        private System.Windows.Forms.Label lblARItemBrand;
        private System.Windows.Forms.Label lblARItemName;
        private System.Windows.Forms.NumericUpDown numUDARItemQuantity;
        private System.Windows.Forms.TextBox tbxARItemColor;
        private System.Windows.Forms.TextBox tbxARItemName;
        private System.Windows.Forms.ComboBox cbbARItemBrand;
        private System.Windows.Forms.ComboBox cbbARItemType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblARItemQuantity;
        private System.Windows.Forms.Label lblARItemColor;
        private System.Windows.Forms.Button btnARGenerateItemCode;
        private System.Windows.Forms.Button btnWelStocktake;
        private System.Windows.Forms.TabPage tbsStockTake;
        private System.Windows.Forms.Button btnSTNewStocktake;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSTContinue;
        private System.Windows.Forms.DateTimePicker dtpSTPreviousStocktake;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBugStockTake;
        private System.Windows.Forms.CheckBox cbxSTDebugMode;
        private System.Windows.Forms.Button btnPrimeScanner;
        private System.Windows.Forms.Button btnWelClose;
        private System.Windows.Forms.ProgressBar progBarGenSaveQR;
        private System.Windows.Forms.Label lblFileReminder;
    }
}

