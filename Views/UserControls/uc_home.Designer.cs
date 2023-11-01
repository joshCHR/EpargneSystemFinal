namespace ADTMPDapk.Views.UserControls
{
    partial class uc_home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnhomeretour = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnhomeretour)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ADTMPDapk.Properties.Resources.Capture;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnhomeretour);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 610);
            this.panel1.TabIndex = 0;
            // 
            // btnhomeretour
            // 
            this.btnhomeretour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnhomeretour.BackColor = System.Drawing.Color.Transparent;
            this.btnhomeretour.Image = global::ADTMPDapk.Properties.Resources.logo;
            this.btnhomeretour.ImageActive = null;
            this.btnhomeretour.Location = new System.Drawing.Point(44, 22);
            this.btnhomeretour.Name = "btnhomeretour";
            this.btnhomeretour.Size = new System.Drawing.Size(171, 130);
            this.btnhomeretour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnhomeretour.TabIndex = 1;
            this.btnhomeretour.TabStop = false;
            this.btnhomeretour.Zoom = 10;
            // 
            // uc_home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uc_home";
            this.Size = new System.Drawing.Size(1114, 610);
            this.Load += new System.EventHandler(this.uc_home_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnhomeretour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnhomeretour;
    }
}
