
namespace ADTMPDapk.Views.UserControls
{
    partial class uc_emprunt
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_emprunt));
            this.MembreEnregistrer = new System.Windows.Forms.GroupBox();
            this.dtg_emprunt = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.journalierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planRemboursementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesFichesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoursementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hebdomadaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depotDeLabonnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnactualiser = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnexcel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnprint = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.MembreEnregistrer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_emprunt)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnactualiser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprint)).BeginInit();
            this.SuspendLayout();
            // 
            // MembreEnregistrer
            // 
            this.MembreEnregistrer.Controls.Add(this.dtg_emprunt);
            this.bunifuTransition1.SetDecoration(this.MembreEnregistrer, BunifuAnimatorNS.DecorationType.None);
            this.MembreEnregistrer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MembreEnregistrer.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembreEnregistrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.MembreEnregistrer.Location = new System.Drawing.Point(0, 0);
            this.MembreEnregistrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MembreEnregistrer.Name = "MembreEnregistrer";
            this.MembreEnregistrer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MembreEnregistrer.Size = new System.Drawing.Size(1106, 478);
            this.MembreEnregistrer.TabIndex = 1;
            this.MembreEnregistrer.TabStop = false;
            this.MembreEnregistrer.Text = "Enregistrement ";
            // 
            // dtg_emprunt
            // 
            this.dtg_emprunt.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtg_emprunt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_emprunt.BackgroundColor = System.Drawing.Color.White;
            this.dtg_emprunt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_emprunt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_emprunt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_emprunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_emprunt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricule,
            this.nom,
            this.adresse,
            this.postnom,
            this.phone,
            this.sexe,
            this.Column1});
            this.bunifuTransition1.SetDecoration(this.dtg_emprunt, BunifuAnimatorNS.DecorationType.None);
            this.dtg_emprunt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_emprunt.DoubleBuffered = true;
            this.dtg_emprunt.EnableHeadersVisualStyles = false;
            this.dtg_emprunt.GridColor = System.Drawing.Color.White;
            this.dtg_emprunt.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.dtg_emprunt.HeaderForeColor = System.Drawing.Color.White;
            this.dtg_emprunt.Location = new System.Drawing.Point(4, 25);
            this.dtg_emprunt.Name = "dtg_emprunt";
            this.dtg_emprunt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_emprunt.Size = new System.Drawing.Size(1098, 448);
            this.dtg_emprunt.TabIndex = 0;
            this.dtg_emprunt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_emprunt_CellContentClick);
            // 
            // matricule
            // 
            this.matricule.DataPropertyName = "id_pret";
            this.matricule.HeaderText = "Id";
            this.matricule.Name = "matricule";
            // 
            // nom
            // 
            this.nom.DataPropertyName = "membre";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.Width = 200;
            // 
            // adresse
            // 
            this.adresse.DataPropertyName = "secteur";
            this.adresse.HeaderText = "Secteur";
            this.adresse.Name = "adresse";
            this.adresse.Width = 200;
            // 
            // postnom
            // 
            this.postnom.DataPropertyName = "versement";
            this.postnom.HeaderText = "Montant preter";
            this.postnom.Name = "postnom";
            this.postnom.Width = 150;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "date_pret";
            this.phone.HeaderText = "Date de versement";
            this.phone.Name = "phone";
            this.phone.Width = 160;
            // 
            // sexe
            // 
            this.sexe.DataPropertyName = "id_user";
            this.sexe.HeaderText = "Nom du percepteur";
            this.sexe.Name = "sexe";
            this.sexe.Width = 190;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Supprimer";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Visible = false;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.label1);
            this.gunaElipsePanel1.Controls.Add(this.menuStrip1);
            this.gunaElipsePanel1.Controls.Add(this.btnactualiser);
            this.gunaElipsePanel1.Controls.Add(this.txtsearch);
            this.gunaElipsePanel1.Controls.Add(this.btnAdd);
            this.bunifuTransition1.SetDecoration(this.gunaElipsePanel1, BunifuAnimatorNS.DecorationType.None);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaElipsePanel1.Location = new System.Drawing.Point(4, 5);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 3;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1106, 51);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // menuStrip1
            // 
            this.bunifuTransition1.SetDecoration(this.menuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportToolStripMenuItem,
            this.mesFichesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1106, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.journalierToolStripMenuItem,
            this.planRemboursementToolStripMenuItem});
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.rapportToolStripMenuItem.Text = "Rapport";
            // 
            // journalierToolStripMenuItem
            // 
            this.journalierToolStripMenuItem.Name = "journalierToolStripMenuItem";
            this.journalierToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.journalierToolStripMenuItem.Text = "Journalier";
            // 
            // planRemboursementToolStripMenuItem
            // 
            this.planRemboursementToolStripMenuItem.Name = "planRemboursementToolStripMenuItem";
            this.planRemboursementToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.planRemboursementToolStripMenuItem.Text = "Plan Remboursement";
            // 
            // mesFichesToolStripMenuItem
            // 
            this.mesFichesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remoursementToolStripMenuItem,
            this.depotDeLabonnerToolStripMenuItem});
            this.mesFichesToolStripMenuItem.Name = "mesFichesToolStripMenuItem";
            this.mesFichesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.mesFichesToolStripMenuItem.Text = "Mes fiches";
            // 
            // remoursementToolStripMenuItem
            // 
            this.remoursementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hebdomadaireToolStripMenuItem});
            this.remoursementToolStripMenuItem.Name = "remoursementToolStripMenuItem";
            this.remoursementToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.remoursementToolStripMenuItem.Text = "Remoursement";
            // 
            // hebdomadaireToolStripMenuItem
            // 
            this.hebdomadaireToolStripMenuItem.Name = "hebdomadaireToolStripMenuItem";
            this.hebdomadaireToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.hebdomadaireToolStripMenuItem.Text = "Hebdomadaire";
            // 
            // depotDeLabonnerToolStripMenuItem
            // 
            this.depotDeLabonnerToolStripMenuItem.Name = "depotDeLabonnerToolStripMenuItem";
            this.depotDeLabonnerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.depotDeLabonnerToolStripMenuItem.Text = "Depot de l\'abonner";
            // 
            // btnactualiser
            // 
            this.btnactualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnactualiser.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnactualiser, BunifuAnimatorNS.DecorationType.None);
            this.btnactualiser.Image = global::ADTMPDapk.Properties.Resources.update_left_rotation_96px1;
            this.btnactualiser.ImageActive = null;
            this.btnactualiser.Location = new System.Drawing.Point(1052, 21);
            this.btnactualiser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnactualiser.Name = "btnactualiser";
            this.btnactualiser.Size = new System.Drawing.Size(50, 32);
            this.btnactualiser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnactualiser.TabIndex = 4;
            this.btnactualiser.TabStop = false;
            this.btnactualiser.Zoom = 10;
            this.btnactualiser.Click += new System.EventHandler(this.btnactualiser_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtsearch.BorderRadius = 3;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txtsearch, BunifuAnimatorNS.DecorationType.None);
            this.txtsearch.DefaultText = "";
            this.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.IconRight = global::ADTMPDapk.Properties.Resources.search_32px;
            this.txtsearch.Location = new System.Drawing.Point(747, 21);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtsearch.PlaceholderText = "Rechecher membre";
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(304, 32);
            this.txtsearch.TabIndex = 3;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnAdd, BunifuAnimatorNS.DecorationType.None);
            this.btnAdd.Image = global::ADTMPDapk.Properties.Resources.ad_96px;
            this.btnAdd.ImageActive = null;
            this.btnAdd.Location = new System.Drawing.Point(695, 21);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 32);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TabStop = false;
            this.btnAdd.Zoom = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MembreEnregistrer);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 478);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gunaElipsePanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 610);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGit);
            this.panel2.Controls.Add(this.btnexcel);
            this.panel2.Controls.Add(this.btnprint);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 55);
            this.panel2.TabIndex = 2;
            // 
            // btnGit
            // 
            this.btnGit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGit.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnGit, BunifuAnimatorNS.DecorationType.None);
            this.btnGit.Image = global::ADTMPDapk.Properties.Resources.github_96px;
            this.btnGit.ImageActive = null;
            this.btnGit.Location = new System.Drawing.Point(529, 11);
            this.btnGit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(32, 32);
            this.btnGit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGit.TabIndex = 7;
            this.btnGit.TabStop = false;
            this.btnGit.Zoom = 10;
            this.btnGit.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexcel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnexcel, BunifuAnimatorNS.DecorationType.None);
            this.btnexcel.Image = global::ADTMPDapk.Properties.Resources.microsoft_excel_96px;
            this.btnexcel.ImageActive = null;
            this.btnexcel.Location = new System.Drawing.Point(979, 18);
            this.btnexcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(50, 32);
            this.btnexcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnexcel.TabIndex = 6;
            this.btnexcel.TabStop = false;
            this.btnexcel.Zoom = 10;
            // 
            // btnprint
            // 
            this.btnprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprint.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnprint, BunifuAnimatorNS.DecorationType.None);
            this.btnprint.Image = global::ADTMPDapk.Properties.Resources.print_96px;
            this.btnprint.ImageActive = null;
            this.btnprint.Location = new System.Drawing.Point(1053, 18);
            this.btnprint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(50, 32);
            this.btnprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnprint.TabIndex = 5;
            this.btnprint.TabStop = false;
            this.btnprint.Zoom = 10;
            this.btnprint.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // gunaContextMenuStrip1
            // 
            this.bunifuTransition1.SetDecoration(this.gunaContextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // uc_emprunt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_emprunt";
            this.Size = new System.Drawing.Size(1114, 610);
            this.Load += new System.EventHandler(this.uc_emprunt_Load);
            this.MembreEnregistrer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_emprunt)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnactualiser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnGit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnactualiser;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private System.Windows.Forms.GroupBox MembreEnregistrer;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtg_emprunt;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnprint;
        private Bunifu.Framework.UI.BunifuImageButton btnexcel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem journalierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planRemboursementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesFichesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoursementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hebdomadaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depotDeLabonnerToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private Bunifu.Framework.UI.BunifuImageButton btnGit;
    }
}
