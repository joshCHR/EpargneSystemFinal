﻿namespace ADTMPDapk.Views.Forms
{
    partial class frm_adhesion
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
            this.components = new System.ComponentModel.Container();
            this.btnfermer = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtpercepteur = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.t_loginTableAdapter1 = new ADTMPDapk.db_adtmpdDataSetTableAdapters.t_loginTableAdapter();
            this.labeltitre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsecteur = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdateversement = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelsexe = new System.Windows.Forms.Label();
            this.labelphone = new System.Windows.Forms.Label();
            this.txtversement = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnenregistrer = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnactualiser = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbmembre1 = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnfermer)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnactualiser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnfermer
            // 
            this.btnfermer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfermer.BackColor = System.Drawing.Color.Transparent;
            this.btnfermer.Image = global::ADTMPDapk.Properties.Resources.close_window_96px;
            this.btnfermer.ImageActive = null;
            this.btnfermer.Location = new System.Drawing.Point(632, 3);
            this.btnfermer.Name = "btnfermer";
            this.btnfermer.Size = new System.Drawing.Size(36, 29);
            this.btnfermer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnfermer.TabIndex = 2;
            this.btnfermer.TabStop = false;
            this.btnfermer.Zoom = 10;
            this.btnfermer.Click += new System.EventHandler(this.btnfermer_Click);
            // 
            // txtpercepteur
            // 
            this.txtpercepteur.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtpercepteur.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtpercepteur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpercepteur.DefaultText = "";
            this.txtpercepteur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpercepteur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpercepteur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpercepteur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpercepteur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpercepteur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtpercepteur.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpercepteur.Location = new System.Drawing.Point(341, 166);
            this.txtpercepteur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpercepteur.Name = "txtpercepteur";
            this.txtpercepteur.PasswordChar = '\0';
            this.txtpercepteur.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtpercepteur.PlaceholderText = "nom du percepteur";
            this.txtpercepteur.SelectedText = "";
            this.txtpercepteur.Size = new System.Drawing.Size(268, 37);
            this.txtpercepteur.TabIndex = 49;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.label1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(349, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Date d\'adhesion";
            // 
            // t_loginTableAdapter1
            // 
            this.t_loginTableAdapter1.ClearBeforeFill = true;
            // 
            // labeltitre
            // 
            this.labeltitre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltitre.AutoSize = true;
            this.labeltitre.ForeColor = System.Drawing.Color.White;
            this.labeltitre.Location = new System.Drawing.Point(11, 10);
            this.labeltitre.Name = "labeltitre";
            this.labeltitre.Size = new System.Drawing.Size(71, 20);
            this.labeltitre.TabIndex = 3;
            this.labeltitre.Text = "Adhesion";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label5.Location = new System.Drawing.Point(34, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Motif";
            // 
            // txtsecteur
            // 
            this.txtsecteur.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtsecteur.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtsecteur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsecteur.DefaultText = "";
            this.txtsecteur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsecteur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsecteur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsecteur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsecteur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsecteur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsecteur.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsecteur.Location = new System.Drawing.Point(29, 243);
            this.txtsecteur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsecteur.Name = "txtsecteur";
            this.txtsecteur.PasswordChar = '\0';
            this.txtsecteur.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtsecteur.PlaceholderText = "Secteur d\'activiter";
            this.txtsecteur.SelectedText = "";
            this.txtsecteur.Size = new System.Drawing.Size(580, 37);
            this.txtsecteur.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label3.Location = new System.Drawing.Point(56, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "01";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label4.Location = new System.Drawing.Point(357, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Statut";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label2.Location = new System.Drawing.Point(26, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "ID";
            // 
            // txtdateversement
            // 
            this.txtdateversement.Checked = true;
            this.txtdateversement.FillColor = System.Drawing.Color.White;
            this.txtdateversement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdateversement.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdateversement.Location = new System.Drawing.Point(341, 86);
            this.txtdateversement.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdateversement.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdateversement.Name = "txtdateversement";
            this.txtdateversement.Size = new System.Drawing.Size(268, 45);
            this.txtdateversement.TabIndex = 41;
            this.txtdateversement.Value = new System.DateTime(2023, 7, 19, 15, 36, 14, 47);
            // 
            // labelsexe
            // 
            this.labelsexe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelsexe.AutoSize = true;
            this.labelsexe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.labelsexe.Location = new System.Drawing.Point(34, 72);
            this.labelsexe.Name = "labelsexe";
            this.labelsexe.Size = new System.Drawing.Size(65, 20);
            this.labelsexe.TabIndex = 36;
            this.labelsexe.Text = "Membre";
            // 
            // labelphone
            // 
            this.labelphone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelphone.AutoSize = true;
            this.labelphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.labelphone.Location = new System.Drawing.Point(34, 145);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(115, 20);
            this.labelphone.TabIndex = 35;
            this.labelphone.Text = "Frais d\'adhesion";
            // 
            // txtversement
            // 
            this.txtversement.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtversement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtversement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtversement.DefaultText = "";
            this.txtversement.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtversement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtversement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtversement.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtversement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtversement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtversement.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtversement.Location = new System.Drawing.Point(29, 166);
            this.txtversement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtversement.Name = "txtversement";
            this.txtversement.PasswordChar = '\0';
            this.txtversement.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtversement.PlaceholderText = "Montant verser";
            this.txtversement.SelectedText = "";
            this.txtversement.Size = new System.Drawing.Size(256, 37);
            this.txtversement.TabIndex = 26;
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.AnimationHoverSpeed = 0.07F;
            this.btnenregistrer.AnimationSpeed = 0.03F;
            this.btnenregistrer.BackColor = System.Drawing.Color.Transparent;
            this.btnenregistrer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.btnenregistrer.BorderColor = System.Drawing.Color.Black;
            this.btnenregistrer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnenregistrer.FocusedColor = System.Drawing.Color.Empty;
            this.btnenregistrer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.ForeColor = System.Drawing.Color.White;
            this.btnenregistrer.Image = null;
            this.btnenregistrer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnenregistrer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnenregistrer.Location = new System.Drawing.Point(208, 387);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnenregistrer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnenregistrer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnenregistrer.OnHoverImage = null;
            this.btnenregistrer.OnPressedColor = System.Drawing.Color.Black;
            this.btnenregistrer.Size = new System.Drawing.Size(268, 32);
            this.btnenregistrer.TabIndex = 25;
            this.btnenregistrer.Text = "ENREGISTRER";
            this.btnenregistrer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaElipsePanel1.Controls.Add(this.label5);
            this.gunaElipsePanel1.Controls.Add(this.txtsecteur);
            this.gunaElipsePanel1.Controls.Add(this.label3);
            this.gunaElipsePanel1.Controls.Add(this.label4);
            this.gunaElipsePanel1.Controls.Add(this.txtpercepteur);
            this.gunaElipsePanel1.Controls.Add(this.label2);
            this.gunaElipsePanel1.Controls.Add(this.label1);
            this.gunaElipsePanel1.Controls.Add(this.txtdateversement);
            this.gunaElipsePanel1.Controls.Add(this.labelsexe);
            this.gunaElipsePanel1.Controls.Add(this.labelphone);
            this.gunaElipsePanel1.Controls.Add(this.cmbmembre1);
            this.gunaElipsePanel1.Controls.Add(this.txtversement);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(15, 77);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 3;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(659, 304);
            this.gunaElipsePanel1.TabIndex = 24;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.btnenregistrer);
            this.gunaShadowPanel1.Controls.Add(this.gunaElipsePanel1);
            this.gunaShadowPanel1.Controls.Add(this.btnactualiser);
            this.gunaShadowPanel1.Controls.Add(this.panel1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(2, 2);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(677, 423);
            this.gunaShadowPanel1.TabIndex = 3;
            // 
            // btnactualiser
            // 
            this.btnactualiser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnactualiser.BackColor = System.Drawing.Color.Transparent;
            this.btnactualiser.Image = global::ADTMPDapk.Properties.Resources.update_left_rotation_96px;
            this.btnactualiser.ImageActive = null;
            this.btnactualiser.Location = new System.Drawing.Point(631, 44);
            this.btnactualiser.Name = "btnactualiser";
            this.btnactualiser.Size = new System.Drawing.Size(36, 27);
            this.btnactualiser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnactualiser.TabIndex = 23;
            this.btnactualiser.TabStop = false;
            this.btnactualiser.Zoom = 10;
            this.btnactualiser.Click += new System.EventHandler(this.btnactualiser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.labeltitre);
            this.panel1.Controls.Add(this.btnfermer);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 35);
            this.panel1.TabIndex = 0;
            // 
            // cmbmembre1
            // 
            this.cmbmembre1.BackColor = System.Drawing.Color.Transparent;
            this.cmbmembre1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbmembre1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbmembre1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmembre1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbmembre1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbmembre1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbmembre1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbmembre1.ItemHeight = 30;
            this.cmbmembre1.Location = new System.Drawing.Point(30, 95);
            this.cmbmembre1.Name = "cmbmembre1";
            this.cmbmembre1.Size = new System.Drawing.Size(255, 36);
            this.cmbmembre1.TabIndex = 29;
            // 
            // frm_adhesion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(680, 427);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_adhesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnfermer)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnactualiser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnfermer;
        public Guna.UI2.WinForms.Guna2TextBox txtpercepteur;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private db_adtmpdDataSetTableAdapters.t_loginTableAdapter t_loginTableAdapter1;
        private System.Windows.Forms.Label labeltitre;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2TextBox txtsecteur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelsexe;
        private System.Windows.Forms.Label labelphone;
        public Guna.UI2.WinForms.Guna2TextBox txtversement;
        private Guna.UI.WinForms.GunaButton btnenregistrer;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Bunifu.Framework.UI.BunifuImageButton btnactualiser;
        private System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2DateTimePicker txtdateversement;
        public Guna.UI2.WinForms.Guna2ComboBox cmbmembre1;
    }
}