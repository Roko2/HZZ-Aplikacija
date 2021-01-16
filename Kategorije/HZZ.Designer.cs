
namespace HZZ_Kategorije
{
    partial class HZZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HZZ));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNaslovna = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageKategorije = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPageKategorijeBP = new System.Windows.Forms.TabPage();
            this.btnSrchDate = new System.Windows.Forms.Button();
            this.btnSearchNaziv = new System.Windows.Forms.Button();
            this.datePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.labelSrchDatum = new System.Windows.Forms.Label();
            this.labelSrchNaziv = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxNaziv = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDatumZA = new System.Windows.Forms.Button();
            this.btnDatumAZ = new System.Windows.Forms.Button();
            this.lblSortDatum = new System.Windows.Forms.Label();
            this.lblSortNaziv = new System.Windows.Forms.Label();
            this.btnSortNazivZA = new System.Windows.Forms.Button();
            this.btnSortNazivAZ = new System.Windows.Forms.Button();
            this.dataGridViewBPCategory = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDodavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBP = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelOpcije = new System.Windows.Forms.Panel();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnResetChecked = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageKategorije.SuspendLayout();
            this.tabPageKategorijeBP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBPCategory)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelBP.SuspendLayout();
            this.panelOpcije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslovna
            // 
            this.lblNaslovna.AutoSize = true;
            this.lblNaslovna.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblNaslovna.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslovna.ForeColor = System.Drawing.Color.White;
            this.lblNaslovna.Location = new System.Drawing.Point(1135, 46);
            this.lblNaslovna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaslovna.Name = "lblNaslovna";
            this.lblNaslovna.Size = new System.Drawing.Size(179, 36);
            this.lblNaslovna.TabIndex = 1;
            this.lblNaslovna.Text = "Dobrodošli!";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(4, 489);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(252, 52);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Izlaz";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageKategorije);
            this.tabControl1.Controls.Add(this.tabPageKategorijeBP);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(260, 125);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 556);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPageKategorije
            // 
            this.tabPageKategorije.AutoScroll = true;
            this.tabPageKategorije.BackColor = System.Drawing.Color.LightCyan;
            this.tabPageKategorije.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageKategorije.Controls.Add(this.button1);
            this.tabPageKategorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPageKategorije.Location = new System.Drawing.Point(4, 27);
            this.tabPageKategorije.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageKategorije.Name = "tabPageKategorije";
            this.tabPageKategorije.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageKategorije.Size = new System.Drawing.Size(826, 525);
            this.tabPageKategorije.TabIndex = 0;
            this.tabPageKategorije.Text = "Kategorije";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Osvježi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPageKategorijeBP
            // 
            this.tabPageKategorijeBP.BackColor = System.Drawing.Color.LightCyan;
            this.tabPageKategorijeBP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageKategorijeBP.Controls.Add(this.btnSrchDate);
            this.tabPageKategorijeBP.Controls.Add(this.btnSearchNaziv);
            this.tabPageKategorijeBP.Controls.Add(this.datePickerDatum);
            this.tabPageKategorijeBP.Controls.Add(this.labelSrchDatum);
            this.tabPageKategorijeBP.Controls.Add(this.labelSrchNaziv);
            this.tabPageKategorijeBP.Controls.Add(this.label5);
            this.tabPageKategorijeBP.Controls.Add(this.txtBoxNaziv);
            this.tabPageKategorijeBP.Controls.Add(this.lblSearch);
            this.tabPageKategorijeBP.Controls.Add(this.btnDatumZA);
            this.tabPageKategorijeBP.Controls.Add(this.btnDatumAZ);
            this.tabPageKategorijeBP.Controls.Add(this.lblSortDatum);
            this.tabPageKategorijeBP.Controls.Add(this.lblSortNaziv);
            this.tabPageKategorijeBP.Controls.Add(this.btnSortNazivZA);
            this.tabPageKategorijeBP.Controls.Add(this.btnSortNazivAZ);
            this.tabPageKategorijeBP.Controls.Add(this.dataGridViewBPCategory);
            this.tabPageKategorijeBP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPageKategorijeBP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPageKategorijeBP.Location = new System.Drawing.Point(4, 27);
            this.tabPageKategorijeBP.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageKategorijeBP.Name = "tabPageKategorijeBP";
            this.tabPageKategorijeBP.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageKategorijeBP.Size = new System.Drawing.Size(826, 525);
            this.tabPageKategorijeBP.TabIndex = 2;
            this.tabPageKategorijeBP.Text = "Baza podataka kategorija";
            // 
            // btnSrchDate
            // 
            this.btnSrchDate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSrchDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSrchDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSrchDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSrchDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSrchDate.ForeColor = System.Drawing.Color.Black;
            this.btnSrchDate.Image = ((System.Drawing.Image)(resources.GetObject("btnSrchDate.Image")));
            this.btnSrchDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSrchDate.Location = new System.Drawing.Point(646, 140);
            this.btnSrchDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSrchDate.Name = "btnSrchDate";
            this.btnSrchDate.Size = new System.Drawing.Size(139, 41);
            this.btnSrchDate.TabIndex = 16;
            this.btnSrchDate.Text = "  Pretraži";
            this.btnSrchDate.UseVisualStyleBackColor = false;
            this.btnSrchDate.Click += new System.EventHandler(this.btnSrchDate_Click);
            // 
            // btnSearchNaziv
            // 
            this.btnSearchNaziv.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSearchNaziv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchNaziv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearchNaziv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSearchNaziv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSearchNaziv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchNaziv.ForeColor = System.Drawing.Color.Black;
            this.btnSearchNaziv.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchNaziv.Image")));
            this.btnSearchNaziv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchNaziv.Location = new System.Drawing.Point(438, 137);
            this.btnSearchNaziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchNaziv.Name = "btnSearchNaziv";
            this.btnSearchNaziv.Size = new System.Drawing.Size(139, 41);
            this.btnSearchNaziv.TabIndex = 15;
            this.btnSearchNaziv.Text = "  Pretraži";
            this.btnSearchNaziv.UseVisualStyleBackColor = false;
            this.btnSearchNaziv.Click += new System.EventHandler(this.btnSearchNaziv_Click);
            // 
            // datePickerDatum
            // 
            this.datePickerDatum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datePickerDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerDatum.Location = new System.Drawing.Point(624, 97);
            this.datePickerDatum.MaxDate = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.datePickerDatum.MinDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.datePickerDatum.Name = "datePickerDatum";
            this.datePickerDatum.Size = new System.Drawing.Size(193, 24);
            this.datePickerDatum.TabIndex = 12;
            // 
            // labelSrchDatum
            // 
            this.labelSrchDatum.AutoSize = true;
            this.labelSrchDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSrchDatum.ForeColor = System.Drawing.Color.Black;
            this.labelSrchDatum.Location = new System.Drawing.Point(666, 65);
            this.labelSrchDatum.Name = "labelSrchDatum";
            this.labelSrchDatum.Size = new System.Drawing.Size(98, 20);
            this.labelSrchDatum.TabIndex = 11;
            this.labelSrchDatum.Text = "Po datumu";
            // 
            // labelSrchNaziv
            // 
            this.labelSrchNaziv.AutoSize = true;
            this.labelSrchNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSrchNaziv.ForeColor = System.Drawing.Color.Black;
            this.labelSrchNaziv.Location = new System.Drawing.Point(461, 65);
            this.labelSrchNaziv.Name = "labelSrchNaziv";
            this.labelSrchNaziv.Size = new System.Drawing.Size(91, 20);
            this.labelSrchNaziv.TabIndex = 10;
            this.labelSrchNaziv.Text = "Po nazivu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(502, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 9;
            // 
            // txtBoxNaziv
            // 
            this.txtBoxNaziv.Location = new System.Drawing.Point(438, 97);
            this.txtBoxNaziv.Name = "txtBoxNaziv";
            this.txtBoxNaziv.Size = new System.Drawing.Size(138, 24);
            this.txtBoxNaziv.TabIndex = 8;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(554, 26);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(126, 20);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Pretraživanje ";
            // 
            // btnDatumZA
            // 
            this.btnDatumZA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDatumZA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDatumZA.BackgroundImage")));
            this.btnDatumZA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDatumZA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatumZA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDatumZA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDatumZA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatumZA.Image = ((System.Drawing.Image)(resources.GetObject("btnDatumZA.Image")));
            this.btnDatumZA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatumZA.Location = new System.Drawing.Point(258, 137);
            this.btnDatumZA.Name = "btnDatumZA";
            this.btnDatumZA.Size = new System.Drawing.Size(139, 46);
            this.btnDatumZA.TabIndex = 6;
            this.btnDatumZA.UseVisualStyleBackColor = false;
            this.btnDatumZA.Click += new System.EventHandler(this.btnDatumZA_Click);
            // 
            // btnDatumAZ
            // 
            this.btnDatumAZ.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDatumAZ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDatumAZ.BackgroundImage")));
            this.btnDatumAZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDatumAZ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDatumAZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDatumAZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatumAZ.Image = ((System.Drawing.Image)(resources.GetObject("btnDatumAZ.Image")));
            this.btnDatumAZ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatumAZ.Location = new System.Drawing.Point(258, 74);
            this.btnDatumAZ.Name = "btnDatumAZ";
            this.btnDatumAZ.Size = new System.Drawing.Size(139, 46);
            this.btnDatumAZ.TabIndex = 5;
            this.btnDatumAZ.UseVisualStyleBackColor = false;
            this.btnDatumAZ.Click += new System.EventHandler(this.btnDatumAZ_Click);
            // 
            // lblSortDatum
            // 
            this.lblSortDatum.AutoSize = true;
            this.lblSortDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSortDatum.ForeColor = System.Drawing.Color.Black;
            this.lblSortDatum.Location = new System.Drawing.Point(236, 26);
            this.lblSortDatum.Name = "lblSortDatum";
            this.lblSortDatum.Size = new System.Drawing.Size(184, 20);
            this.lblSortDatum.TabIndex = 4;
            this.lblSortDatum.Text = "Sortiranje po datumu";
            // 
            // lblSortNaziv
            // 
            this.lblSortNaziv.AutoSize = true;
            this.lblSortNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSortNaziv.ForeColor = System.Drawing.Color.Black;
            this.lblSortNaziv.Location = new System.Drawing.Point(14, 26);
            this.lblSortNaziv.Name = "lblSortNaziv";
            this.lblSortNaziv.Size = new System.Drawing.Size(177, 20);
            this.lblSortNaziv.TabIndex = 3;
            this.lblSortNaziv.Text = "Sortiranje po nazivu";
            // 
            // btnSortNazivZA
            // 
            this.btnSortNazivZA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSortNazivZA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortNazivZA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSortNazivZA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSortNazivZA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortNazivZA.ForeColor = System.Drawing.Color.Black;
            this.btnSortNazivZA.Image = ((System.Drawing.Image)(resources.GetObject("btnSortNazivZA.Image")));
            this.btnSortNazivZA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortNazivZA.Location = new System.Drawing.Point(39, 137);
            this.btnSortNazivZA.Name = "btnSortNazivZA";
            this.btnSortNazivZA.Size = new System.Drawing.Size(139, 46);
            this.btnSortNazivZA.TabIndex = 2;
            this.btnSortNazivZA.Text = "Z-A";
            this.btnSortNazivZA.UseVisualStyleBackColor = false;
            this.btnSortNazivZA.Click += new System.EventHandler(this.btnSortNazivZA_Click);
            // 
            // btnSortNazivAZ
            // 
            this.btnSortNazivAZ.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSortNazivAZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortNazivAZ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSortNazivAZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSortNazivAZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortNazivAZ.ForeColor = System.Drawing.Color.Black;
            this.btnSortNazivAZ.Image = ((System.Drawing.Image)(resources.GetObject("btnSortNazivAZ.Image")));
            this.btnSortNazivAZ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortNazivAZ.Location = new System.Drawing.Point(39, 74);
            this.btnSortNazivAZ.Name = "btnSortNazivAZ";
            this.btnSortNazivAZ.Size = new System.Drawing.Size(139, 46);
            this.btnSortNazivAZ.TabIndex = 1;
            this.btnSortNazivAZ.Text = "A-Z";
            this.btnSortNazivAZ.UseVisualStyleBackColor = false;
            this.btnSortNazivAZ.Click += new System.EventHandler(this.btnSortNazivAZ_Click);
            // 
            // dataGridViewBPCategory
            // 
            this.dataGridViewBPCategory.AllowUserToAddRows = false;
            this.dataGridViewBPCategory.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewBPCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBPCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Description,
            this.Url,
            this.DatumDodavanja});
            this.dataGridViewBPCategory.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewBPCategory.Location = new System.Drawing.Point(1, 203);
            this.dataGridViewBPCategory.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBPCategory.Name = "dataGridViewBPCategory";
            this.dataGridViewBPCategory.RowHeadersWidth = 51;
            this.dataGridViewBPCategory.RowTemplate.Height = 24;
            this.dataGridViewBPCategory.Size = new System.Drawing.Size(818, 314);
            this.dataGridViewBPCategory.TabIndex = 0;
            this.dataGridViewBPCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBPCategory_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.DataPropertyName = "ID";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            this.Id.DefaultCellStyle = dataGridViewCellStyle25;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Width = 30;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Description.DataPropertyName = "Description";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
            this.Description.DefaultCellStyle = dataGridViewCellStyle26;
            this.Description.HeaderText = "Naziv kategorije";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Description.Width = 122;
            // 
            // Url
            // 
            this.Url.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Url.DataPropertyName = "Url";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            this.Url.DefaultCellStyle = dataGridViewCellStyle27;
            this.Url.HeaderText = "URL";
            this.Url.MinimumWidth = 6;
            this.Url.Name = "Url";
            this.Url.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DatumDodavanja
            // 
            this.DatumDodavanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DatumDodavanja.DataPropertyName = "DatumSpremanjaUBazu";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            this.DatumDodavanja.DefaultCellStyle = dataGridViewCellStyle28;
            this.DatumDodavanja.HeaderText = "Datum spremanja u bazu";
            this.DatumDodavanja.MinimumWidth = 6;
            this.DatumDodavanja.Name = "DatumDodavanja";
            this.DatumDodavanja.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DatumDodavanja.Width = 149;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panelBP);
            this.panel1.Controls.Add(this.panelOpcije);
            this.panel1.Location = new System.Drawing.Point(1099, 125);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 556);
            this.panel1.TabIndex = 6;
            // 
            // panelBP
            // 
            this.panelBP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBP.BackgroundImage")));
            this.panelBP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBP.Controls.Add(this.monthCalendar1);
            this.panelBP.Location = new System.Drawing.Point(2, 4);
            this.panelBP.Name = "panelBP";
            this.panelBP.Size = new System.Drawing.Size(270, 465);
            this.panelBP.TabIndex = 8;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 176);
            this.monthCalendar1.MaxDate = new System.DateTime(2109, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(1900, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // panelOpcije
            // 
            this.panelOpcije.Controls.Add(this.btnCheckAll);
            this.panelOpcije.Controls.Add(this.btnResetChecked);
            this.panelOpcije.Controls.Add(this.label2);
            this.panelOpcije.Controls.Add(this.BtnSave);
            this.panelOpcije.Location = new System.Drawing.Point(2, 4);
            this.panelOpcije.Margin = new System.Windows.Forms.Padding(2);
            this.panelOpcije.Name = "panelOpcije";
            this.panelOpcije.Size = new System.Drawing.Size(265, 479);
            this.panelOpcije.TabIndex = 7;
            this.panelOpcije.Visible = false;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCheckAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAll.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckAll.Image")));
            this.btnCheckAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckAll.Location = new System.Drawing.Point(50, 255);
            this.btnCheckAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(168, 40);
            this.btnCheckAll.TabIndex = 8;
            this.btnCheckAll.Text = " Označi sve";
            this.btnCheckAll.UseVisualStyleBackColor = false;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnResetChecked
            // 
            this.btnResetChecked.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnResetChecked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetChecked.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResetChecked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetChecked.Image = ((System.Drawing.Image)(resources.GetObject("btnResetChecked.Image")));
            this.btnResetChecked.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetChecked.Location = new System.Drawing.Point(50, 325);
            this.btnResetChecked.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetChecked.Name = "btnResetChecked";
            this.btnResetChecked.Size = new System.Drawing.Size(168, 40);
            this.btnResetChecked.TabIndex = 7;
            this.btnResetChecked.Text = " Odznači sve";
            this.btnResetChecked.UseVisualStyleBackColor = false;
            this.btnResetChecked.Click += new System.EventHandler(this.btnResetChecked_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(85, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "OPCIJE";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(50, 394);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(168, 40);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "  Spremi u bazu";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1374, 125);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 556);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(30, 499);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lokacije";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 276);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(232, 218);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 41);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 218);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kontakt informacije";
            // 
            // HZZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1370, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblNaslovna);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HZZ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HZZ";
            this.Load += new System.EventHandler(this.Kategorije_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageKategorije.ResumeLayout(false);
            this.tabPageKategorijeBP.ResumeLayout(false);
            this.tabPageKategorijeBP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBPCategory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelBP.ResumeLayout(false);
            this.panelOpcije.ResumeLayout(false);
            this.panelOpcije.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNaslovna;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageKategorije;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TabPage tabPageKategorijeBP;
        private System.Windows.Forms.DataGridView dataGridViewBPCategory;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelOpcije;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnResetChecked;
        private System.Windows.Forms.Panel panelBP;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDodavanja;
        private System.Windows.Forms.Button btnSortNazivZA;
        private System.Windows.Forms.Button btnSortNazivAZ;
        private System.Windows.Forms.Button btnDatumAZ;
        private System.Windows.Forms.Label lblSortDatum;
        private System.Windows.Forms.Label lblSortNaziv;
        private System.Windows.Forms.Button btnDatumZA;
        private System.Windows.Forms.Label labelSrchDatum;
        private System.Windows.Forms.Label labelSrchNaziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxNaziv;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DateTimePicker datePickerDatum;
        private System.Windows.Forms.Button btnSrchDate;
        private System.Windows.Forms.Button btnSearchNaziv;
    }
}

