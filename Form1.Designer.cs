
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbsWelcome = new System.Windows.Forms.TabPage();
            this.btnWelSale = new System.Windows.Forms.Button();
            this.btnWelScan = new System.Windows.Forms.Button();
            this.lblWelHead = new System.Windows.Forms.Label();
            this.btnWelGenerate = new System.Windows.Forms.Button();
            this.tbsGenerateQR = new System.Windows.Forms.TabPage();
            this.btnGenBack = new System.Windows.Forms.Button();
            this.lblGenProductCode = new System.Windows.Forms.Label();
            this.picbxGenImage = new System.Windows.Forms.PictureBox();
            this.txtGenQRCode = new System.Windows.Forms.TextBox();
            this.lblGenQRCodeHead = new System.Windows.Forms.Label();
            this.btnGenGenerate = new System.Windows.Forms.Button();
            this.tbsScanQR = new System.Windows.Forms.TabPage();
            this.btnScanBack = new System.Windows.Forms.Button();
            this.cbbScanCameraList = new System.Windows.Forms.ComboBox();
            this.lblScanProductCode = new System.Windows.Forms.Label();
            this.txtScanQRCode = new System.Windows.Forms.TextBox();
            this.picbxScanImage = new System.Windows.Forms.PictureBox();
            this.lblScanCameraHead = new System.Windows.Forms.Label();
            this.btnScanScan = new System.Windows.Forms.Button();
            this.tbsSale = new System.Windows.Forms.TabPage();
            this.lblTODO = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblSaleHold = new System.Windows.Forms.Label();
            this.cbbSaleHold = new System.Windows.Forms.ComboBox();
            this.btnGenPrint = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tbsWelcome.SuspendLayout();
            this.tbsGenerateQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxGenImage)).BeginInit();
            this.tbsScanQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxScanImage)).BeginInit();
            this.tbsSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbsWelcome);
            this.tabControl.Controls.Add(this.tbsGenerateQR);
            this.tabControl.Controls.Add(this.tbsScanQR);
            this.tabControl.Controls.Add(this.tbsSale);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(393, 606);
            this.tabControl.TabIndex = 4;
            // 
            // tbsWelcome
            // 
            this.tbsWelcome.Controls.Add(this.btnWelSale);
            this.tbsWelcome.Controls.Add(this.btnWelScan);
            this.tbsWelcome.Controls.Add(this.lblWelHead);
            this.tbsWelcome.Controls.Add(this.btnWelGenerate);
            this.tbsWelcome.Location = new System.Drawing.Point(4, 22);
            this.tbsWelcome.Name = "tbsWelcome";
            this.tbsWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tbsWelcome.Size = new System.Drawing.Size(385, 580);
            this.tbsWelcome.TabIndex = 0;
            this.tbsWelcome.Text = "Welcome";
            this.tbsWelcome.UseVisualStyleBackColor = true;
            // 
            // btnWelSale
            // 
            this.btnWelSale.Location = new System.Drawing.Point(19, 50);
            this.btnWelSale.Name = "btnWelSale";
            this.btnWelSale.Size = new System.Drawing.Size(345, 30);
            this.btnWelSale.TabIndex = 14;
            this.btnWelSale.Text = "Sale";
            this.btnWelSale.UseVisualStyleBackColor = true;
            this.btnWelSale.Click += new System.EventHandler(this.btnWelSale_Click);
            // 
            // btnWelScan
            // 
            this.btnWelScan.Location = new System.Drawing.Point(19, 112);
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
            this.btnWelGenerate.Location = new System.Drawing.Point(19, 174);
            this.btnWelGenerate.Name = "btnWelGenerate";
            this.btnWelGenerate.Size = new System.Drawing.Size(345, 30);
            this.btnWelGenerate.TabIndex = 9;
            this.btnWelGenerate.Text = "Generate QR";
            this.btnWelGenerate.UseVisualStyleBackColor = true;
            this.btnWelGenerate.Click += new System.EventHandler(this.btnWelGenerate_Click);
            // 
            // tbsGenerateQR
            // 
            this.tbsGenerateQR.Controls.Add(this.btnGenPrint);
            this.tbsGenerateQR.Controls.Add(this.btnGenBack);
            this.tbsGenerateQR.Controls.Add(this.lblGenProductCode);
            this.tbsGenerateQR.Controls.Add(this.picbxGenImage);
            this.tbsGenerateQR.Controls.Add(this.txtGenQRCode);
            this.tbsGenerateQR.Controls.Add(this.lblGenQRCodeHead);
            this.tbsGenerateQR.Controls.Add(this.btnGenGenerate);
            this.tbsGenerateQR.Location = new System.Drawing.Point(4, 22);
            this.tbsGenerateQR.Name = "tbsGenerateQR";
            this.tbsGenerateQR.Padding = new System.Windows.Forms.Padding(3);
            this.tbsGenerateQR.Size = new System.Drawing.Size(385, 580);
            this.tbsGenerateQR.TabIndex = 1;
            this.tbsGenerateQR.Text = "Generate QR";
            this.tbsGenerateQR.UseVisualStyleBackColor = true;
            // 
            // btnGenBack
            // 
            this.btnGenBack.Location = new System.Drawing.Point(19, 539);
            this.btnGenBack.Name = "btnGenBack";
            this.btnGenBack.Size = new System.Drawing.Size(345, 30);
            this.btnGenBack.TabIndex = 13;
            this.btnGenBack.Text = "Back";
            this.btnGenBack.UseVisualStyleBackColor = true;
            this.btnGenBack.Click += new System.EventHandler(this.btnGenBack_Click);
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
            this.btnGenGenerate.Location = new System.Drawing.Point(19, 503);
            this.btnGenGenerate.Name = "btnGenGenerate";
            this.btnGenGenerate.Size = new System.Drawing.Size(345, 30);
            this.btnGenGenerate.TabIndex = 8;
            this.btnGenGenerate.Text = "Generate";
            this.btnGenGenerate.UseVisualStyleBackColor = true;
            this.btnGenGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbsScanQR
            // 
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
            this.tbsScanQR.Size = new System.Drawing.Size(385, 580);
            this.tbsScanQR.TabIndex = 2;
            this.tbsScanQR.Text = "Scan QR";
            this.tbsScanQR.UseVisualStyleBackColor = true;
            // 
            // btnScanBack
            // 
            this.btnScanBack.Location = new System.Drawing.Point(19, 539);
            this.btnScanBack.Name = "btnScanBack";
            this.btnScanBack.Size = new System.Drawing.Size(345, 30);
            this.btnScanBack.TabIndex = 19;
            this.btnScanBack.Text = "Back";
            this.btnScanBack.UseVisualStyleBackColor = true;
            this.btnScanBack.Click += new System.EventHandler(this.btnScanBack_Click);
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
            this.lblScanProductCode.Location = new System.Drawing.Point(15, 401);
            this.lblScanProductCode.Name = "lblScanProductCode";
            this.lblScanProductCode.Size = new System.Drawing.Size(125, 22);
            this.lblScanProductCode.TabIndex = 17;
            this.lblScanProductCode.Text = "Product Code:";
            // 
            // txtScanQRCode
            // 
            this.txtScanQRCode.Location = new System.Drawing.Point(19, 426);
            this.txtScanQRCode.Multiline = true;
            this.txtScanQRCode.Name = "txtScanQRCode";
            this.txtScanQRCode.Size = new System.Drawing.Size(345, 61);
            this.txtScanQRCode.TabIndex = 16;
            // 
            // picbxScanImage
            // 
            this.picbxScanImage.BackColor = System.Drawing.Color.White;
            this.picbxScanImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbxScanImage.Location = new System.Drawing.Point(22, 44);
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
            this.btnScanScan.Location = new System.Drawing.Point(19, 503);
            this.btnScanScan.Name = "btnScanScan";
            this.btnScanScan.Size = new System.Drawing.Size(345, 30);
            this.btnScanScan.TabIndex = 12;
            this.btnScanScan.Text = "Scan";
            this.btnScanScan.UseVisualStyleBackColor = true;
            this.btnScanScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // tbsSale
            // 
            this.tbsSale.Controls.Add(this.lblTODO);
            this.tbsSale.Controls.Add(this.btnConfirm);
            this.tbsSale.Controls.Add(this.lblSaleHold);
            this.tbsSale.Controls.Add(this.cbbSaleHold);
            this.tbsSale.Location = new System.Drawing.Point(4, 22);
            this.tbsSale.Name = "tbsSale";
            this.tbsSale.Padding = new System.Windows.Forms.Padding(3);
            this.tbsSale.Size = new System.Drawing.Size(385, 580);
            this.tbsSale.TabIndex = 3;
            this.tbsSale.Text = "Sale";
            this.tbsSale.UseVisualStyleBackColor = true;
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
            this.btnConfirm.Location = new System.Drawing.Point(134, 537);
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
            // btnGenPrint
            // 
            this.btnGenPrint.Location = new System.Drawing.Point(264, 397);
            this.btnGenPrint.Name = "btnGenPrint";
            this.btnGenPrint.Size = new System.Drawing.Size(100, 23);
            this.btnGenPrint.TabIndex = 14;
            this.btnGenPrint.Text = "Print QR Code(s)";
            this.btnGenPrint.UseVisualStyleBackColor = true;
            this.btnGenPrint.Click += new System.EventHandler(this.btnGenPrint_Click);
            // 
            // frmBarcodeApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 630);
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
            ((System.ComponentModel.ISupportInitialize)(this.picbxGenImage)).EndInit();
            this.tbsScanQR.ResumeLayout(false);
            this.tbsScanQR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxScanImage)).EndInit();
            this.tbsSale.ResumeLayout(false);
            this.tbsSale.PerformLayout();
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
        private System.Windows.Forms.Button btnGenPrint;
    }
}

