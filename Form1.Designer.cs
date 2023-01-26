
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbsWelcome = new System.Windows.Forms.TabPage();
            this.tbsGenerateQR = new System.Windows.Forms.TabPage();
            this.picbxImage = new System.Windows.Forms.PictureBox();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.lblQRCode = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbsScanQR = new System.Windows.Forms.TabPage();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbsGenerateQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbsWelcome);
            this.tabControl1.Controls.Add(this.tbsGenerateQR);
            this.tabControl1.Controls.Add(this.tbsScanQR);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 606);
            this.tabControl1.TabIndex = 4;
            // 
            // tbsWelcome
            // 
            this.tbsWelcome.Location = new System.Drawing.Point(4, 22);
            this.tbsWelcome.Name = "tbsWelcome";
            this.tbsWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tbsWelcome.Size = new System.Drawing.Size(408, 529);
            this.tbsWelcome.TabIndex = 0;
            this.tbsWelcome.Text = "Welcome";
            this.tbsWelcome.UseVisualStyleBackColor = true;
            // 
            // tbsGenerateQR
            // 
            this.tbsGenerateQR.Controls.Add(this.lblProductCode);
            this.tbsGenerateQR.Controls.Add(this.picbxImage);
            this.tbsGenerateQR.Controls.Add(this.txtQRCode);
            this.tbsGenerateQR.Controls.Add(this.lblQRCode);
            this.tbsGenerateQR.Controls.Add(this.btnGenerate);
            this.tbsGenerateQR.Location = new System.Drawing.Point(4, 22);
            this.tbsGenerateQR.Name = "tbsGenerateQR";
            this.tbsGenerateQR.Padding = new System.Windows.Forms.Padding(3);
            this.tbsGenerateQR.Size = new System.Drawing.Size(385, 580);
            this.tbsGenerateQR.TabIndex = 1;
            this.tbsGenerateQR.Text = "Generate QR";
            this.tbsGenerateQR.UseVisualStyleBackColor = true;
            // 
            // picbxImage
            // 
            this.picbxImage.BackColor = System.Drawing.Color.White;
            this.picbxImage.Location = new System.Drawing.Point(19, 38);
            this.picbxImage.Name = "picbxImage";
            this.picbxImage.Size = new System.Drawing.Size(345, 345);
            this.picbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbxImage.TabIndex = 11;
            this.picbxImage.TabStop = false;
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(19, 426);
            this.txtQRCode.Multiline = true;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(345, 61);
            this.txtQRCode.TabIndex = 10;
            // 
            // lblQRCode
            // 
            this.lblQRCode.AutoSize = true;
            this.lblQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQRCode.Location = new System.Drawing.Point(15, 13);
            this.lblQRCode.Name = "lblQRCode";
            this.lblQRCode.Size = new System.Drawing.Size(90, 22);
            this.lblQRCode.TabIndex = 9;
            this.lblQRCode.Text = "QR Code:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(19, 503);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(345, 58);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbsScanQR
            // 
            this.tbsScanQR.Location = new System.Drawing.Point(4, 22);
            this.tbsScanQR.Name = "tbsScanQR";
            this.tbsScanQR.Padding = new System.Windows.Forms.Padding(3);
            this.tbsScanQR.Size = new System.Drawing.Size(385, 580);
            this.tbsScanQR.TabIndex = 2;
            this.tbsScanQR.Text = "Scan QR";
            this.tbsScanQR.UseVisualStyleBackColor = true;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(15, 401);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(171, 22);
            this.lblProductCode.TabIndex = 12;
            this.lblProductCode.Text = "Type Product Code:";
            // 
            // frmBarcodeApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 630);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmBarcodeApplication";
            this.Text = "Barcode Application";
            this.tabControl1.ResumeLayout(false);
            this.tbsGenerateQR.ResumeLayout(false);
            this.tbsGenerateQR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbsWelcome;
        private System.Windows.Forms.TabPage tbsGenerateQR;
        private System.Windows.Forms.PictureBox picbxImage;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.Label lblQRCode;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TabPage tbsScanQR;
    }
}

