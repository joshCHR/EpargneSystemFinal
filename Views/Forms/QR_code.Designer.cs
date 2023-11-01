namespace ADTMPDapk.Views.Forms
{
    partial class QR_code
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
            this.pan1 = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.txtQr = new System.Windows.Forms.TextBox();
            this.picQr = new System.Windows.Forms.PictureBox();
            this.pan2 = new System.Windows.Forms.Panel();
            this.lblwhat = new System.Windows.Forms.Label();
            this.txtWhat = new System.Windows.Forms.TextBox();
            this.picWha = new System.Windows.Forms.PictureBox();
            this.pan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQr)).BeginInit();
            this.pan2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWha)).BeginInit();
            this.SuspendLayout();
            // 
            // pan1
            // 
            this.pan1.Controls.Add(this.pan2);
            this.pan1.Controls.Add(this.lbl);
            this.pan1.Controls.Add(this.txtQr);
            this.pan1.Controls.Add(this.picQr);
            this.pan1.Location = new System.Drawing.Point(2, 2);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(204, 204);
            this.pan1.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(29, 8);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(118, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Trouvez moi sur GitGub";
            // 
            // txtQr
            // 
            this.txtQr.Location = new System.Drawing.Point(26, 167);
            this.txtQr.Multiline = true;
            this.txtQr.Name = "txtQr";
            this.txtQr.Size = new System.Drawing.Size(151, 30);
            this.txtQr.TabIndex = 4;
            this.txtQr.Visible = false;
            // 
            // picQr
            // 
            this.picQr.Location = new System.Drawing.Point(26, 28);
            this.picQr.Name = "picQr";
            this.picQr.Size = new System.Drawing.Size(152, 133);
            this.picQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picQr.TabIndex = 3;
            this.picQr.TabStop = false;
            // 
            // pan2
            // 
            this.pan2.Controls.Add(this.lblwhat);
            this.pan2.Controls.Add(this.txtWhat);
            this.pan2.Controls.Add(this.picWha);
            this.pan2.Location = new System.Drawing.Point(0, 0);
            this.pan2.Name = "pan2";
            this.pan2.Size = new System.Drawing.Size(205, 205);
            this.pan2.TabIndex = 6;
            // 
            // lblwhat
            // 
            this.lblwhat.AutoSize = true;
            this.lblwhat.Location = new System.Drawing.Point(29, 8);
            this.lblwhat.Name = "lblwhat";
            this.lblwhat.Size = new System.Drawing.Size(135, 13);
            this.lblwhat.TabIndex = 5;
            this.lblwhat.Text = "Trouvez moi sur WhatsApp";
            // 
            // txtWhat
            // 
            this.txtWhat.Location = new System.Drawing.Point(26, 167);
            this.txtWhat.Multiline = true;
            this.txtWhat.Name = "txtWhat";
            this.txtWhat.Size = new System.Drawing.Size(151, 30);
            this.txtWhat.TabIndex = 4;
            this.txtWhat.Visible = false;
            // 
            // picWha
            // 
            this.picWha.Location = new System.Drawing.Point(26, 28);
            this.picWha.Name = "picWha";
            this.picWha.Size = new System.Drawing.Size(152, 133);
            this.picWha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWha.TabIndex = 3;
            this.picWha.TabStop = false;
            // 
            // QR_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(205, 205);
            this.Controls.Add(this.pan1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QR_code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR_code";
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQr)).EndInit();
            this.pan2.ResumeLayout(false);
            this.pan2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblwhat;
        public System.Windows.Forms.TextBox txtWhat;
        public System.Windows.Forms.PictureBox picWha;
        public System.Windows.Forms.Label lbl;
        public System.Windows.Forms.TextBox txtQr;
        public System.Windows.Forms.PictureBox picQr;
        public System.Windows.Forms.Panel pan1;
        public System.Windows.Forms.Panel pan2;
    }
}