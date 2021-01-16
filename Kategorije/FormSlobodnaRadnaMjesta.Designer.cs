
namespace HZZ_Kategorije
{
    partial class FormSlobodnaRadnaMjesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSlobodnaRadnaMjesta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dataGridViewFreeJobs = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panelOpcijeRadnaMjesta = new System.Windows.Forms.Panel();
            this.buttonSrchDate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.inptOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.inptNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnZA = new System.Windows.Forms.Button();
            this.btnAZ = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlSlobodnaRadnaMjesta = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewRadnaMjestaBP = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPosao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivPosao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpisPosla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPosla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeJobs)).BeginInit();
            this.panelOpcijeRadnaMjesta.SuspendLayout();
            this.tabControlSlobodnaRadnaMjesta.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRadnaMjestaBP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 153);
            this.panel1.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(4, 4);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(171, 48);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "   Povratak";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dataGridViewFreeJobs
            // 
            this.dataGridViewFreeJobs.AllowUserToAddRows = false;
            this.dataGridViewFreeJobs.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewFreeJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFreeJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.Opis,
            this.Datum});
            this.dataGridViewFreeJobs.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewFreeJobs.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewFreeJobs.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewFreeJobs.Name = "dataGridViewFreeJobs";
            this.dataGridViewFreeJobs.RowHeadersWidth = 51;
            this.dataGridViewFreeJobs.Size = new System.Drawing.Size(942, 491);
            this.dataGridViewFreeJobs.TabIndex = 1;
            this.dataGridViewFreeJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFreeJobs_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 549);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "  Resetiraj";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelOpcijeRadnaMjesta
            // 
            this.panelOpcijeRadnaMjesta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelOpcijeRadnaMjesta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelOpcijeRadnaMjesta.Controls.Add(this.buttonSrchDate);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.label6);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.dateTimePicker1);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.button4);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.inptOpis);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.label5);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.btnSearch);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.inptNaziv);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.label4);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.panel5);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.button3);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.button2);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.label3);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.panel4);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.btnExit);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.btnZA);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.btnAZ);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.panel3);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.label2);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.label1);
            this.panelOpcijeRadnaMjesta.Controls.Add(this.button1);
            this.panelOpcijeRadnaMjesta.Location = new System.Drawing.Point(961, 1);
            this.panelOpcijeRadnaMjesta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOpcijeRadnaMjesta.Name = "panelOpcijeRadnaMjesta";
            this.panelOpcijeRadnaMjesta.Size = new System.Drawing.Size(417, 684);
            this.panelOpcijeRadnaMjesta.TabIndex = 2;
            // 
            // buttonSrchDate
            // 
            this.buttonSrchDate.BackColor = System.Drawing.Color.White;
            this.buttonSrchDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSrchDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonSrchDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSrchDate.Image = ((System.Drawing.Image)(resources.GetObject("buttonSrchDate.Image")));
            this.buttonSrchDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSrchDate.Location = new System.Drawing.Point(232, 477);
            this.buttonSrchDate.Name = "buttonSrchDate";
            this.buttonSrchDate.Size = new System.Drawing.Size(139, 41);
            this.buttonSrchDate.TabIndex = 20;
            this.buttonSrchDate.Text = "Pretraži";
            this.buttonSrchDate.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(4, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Pretraživanje po datumu";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 482);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 1, 15, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 24);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2021, 1, 15, 0, 0, 0, 0);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(232, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 41);
            this.button4.TabIndex = 17;
            this.button4.Text = "Pretraži";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // inptOpis
            // 
            this.inptOpis.Location = new System.Drawing.Point(3, 395);
            this.inptOpis.Name = "inptOpis";
            this.inptOpis.Size = new System.Drawing.Size(183, 22);
            this.inptOpis.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(4, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pretraživanje po opisu\r\n";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(232, 304);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 41);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "  Pretraži";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // inptNaziv
            // 
            this.inptNaziv.Location = new System.Drawing.Point(3, 313);
            this.inptNaziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inptNaziv.Name = "inptNaziv";
            this.inptNaziv.Size = new System.Drawing.Size(183, 22);
            this.inptNaziv.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(4, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pretraživanje po nazivu";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 255);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(413, 10);
            this.panel5.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(244, 117);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 46);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(244, 196);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 46);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(218, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sortiranje po datumu";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(199, 71);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(11, 192);
            this.panel4.TabIndex = 5;
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
            this.btnExit.Location = new System.Drawing.Point(74, 616);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(252, 52);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Izlaz";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnZA
            // 
            this.btnZA.BackColor = System.Drawing.Color.White;
            this.btnZA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZA.Image = ((System.Drawing.Image)(resources.GetObject("btnZA.Image")));
            this.btnZA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZA.Location = new System.Drawing.Point(21, 196);
            this.btnZA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZA.Name = "btnZA";
            this.btnZA.Size = new System.Drawing.Size(139, 46);
            this.btnZA.TabIndex = 6;
            this.btnZA.Text = "Z-A";
            this.btnZA.UseVisualStyleBackColor = false;
            // 
            // btnAZ
            // 
            this.btnAZ.BackColor = System.Drawing.Color.White;
            this.btnAZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAZ.Image = ((System.Drawing.Image)(resources.GetObject("btnAZ.Image")));
            this.btnAZ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAZ.Location = new System.Drawing.Point(21, 117);
            this.btnAZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAZ.Name = "btnAZ";
            this.btnAZ.Size = new System.Drawing.Size(139, 46);
            this.btnAZ.TabIndex = 5;
            this.btnAZ.Text = "A-Z";
            this.btnAZ.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 10);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sortiranje po nazivu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(152, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "OPCIJE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlSlobodnaRadnaMjesta
            // 
            this.tabControlSlobodnaRadnaMjesta.Controls.Add(this.tabPage1);
            this.tabControlSlobodnaRadnaMjesta.Controls.Add(this.tabPage2);
            this.tabControlSlobodnaRadnaMjesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControlSlobodnaRadnaMjesta.Location = new System.Drawing.Point(4, 155);
            this.tabControlSlobodnaRadnaMjesta.Name = "tabControlSlobodnaRadnaMjesta";
            this.tabControlSlobodnaRadnaMjesta.SelectedIndex = 0;
            this.tabControlSlobodnaRadnaMjesta.Size = new System.Drawing.Size(954, 530);
            this.tabControlSlobodnaRadnaMjesta.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewFreeJobs);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(946, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Radna mjesta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewRadnaMjestaBP);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(946, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Radna mjesta baze";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRadnaMjestaBP
            // 
            this.dataGridViewRadnaMjestaBP.AllowUserToAddRows = false;
            this.dataGridViewRadnaMjestaBP.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewRadnaMjestaBP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRadnaMjestaBP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPosao,
            this.NazivPosao,
            this.OpisPosla,
            this.DatumPosla});
            this.dataGridViewRadnaMjestaBP.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewRadnaMjestaBP.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewRadnaMjestaBP.Name = "dataGridViewRadnaMjestaBP";
            this.dataGridViewRadnaMjestaBP.RowHeadersWidth = 51;
            this.dataGridViewRadnaMjestaBP.RowTemplate.Height = 24;
            this.dataGridViewRadnaMjestaBP.Size = new System.Drawing.Size(934, 487);
            this.dataGridViewRadnaMjestaBP.TabIndex = 0;
            this.dataGridViewRadnaMjestaBP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRadnaMjestaBP_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.DataPropertyName = "IdPosao";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.FillWeight = 14.04897F;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Width = 25;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "NazivPosao";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Naziv.DefaultCellStyle = dataGridViewCellStyle2;
            this.Naziv.FillWeight = 88.69324F;
            this.Naziv.HeaderText = "Naziv posla";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Opis
            // 
            this.Opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opis.DataPropertyName = "OpisPosla";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Opis.DefaultCellStyle = dataGridViewCellStyle3;
            this.Opis.FillWeight = 126.5261F;
            this.Opis.HeaderText = "Opis posla";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Datum.DataPropertyName = "Datum";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Datum.DefaultCellStyle = dataGridViewCellStyle4;
            this.Datum.FillWeight = 33.44742F;
            this.Datum.HeaderText = "Datum objave";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Datum.Width = 101;
            // 
            // IdPosao
            // 
            this.IdPosao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IdPosao.DataPropertyName = "IdPosao";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.IdPosao.DefaultCellStyle = dataGridViewCellStyle5;
            this.IdPosao.HeaderText = "Id";
            this.IdPosao.MinimumWidth = 6;
            this.IdPosao.Name = "IdPosao";
            this.IdPosao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdPosao.Width = 25;
            // 
            // NazivPosao
            // 
            this.NazivPosao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivPosao.DataPropertyName = "NazivPosao";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.NazivPosao.DefaultCellStyle = dataGridViewCellStyle6;
            this.NazivPosao.HeaderText = "Naziv posla";
            this.NazivPosao.MinimumWidth = 6;
            this.NazivPosao.Name = "NazivPosao";
            this.NazivPosao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OpisPosla
            // 
            this.OpisPosla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OpisPosla.DataPropertyName = "OpisPosla";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.OpisPosla.DefaultCellStyle = dataGridViewCellStyle7;
            this.OpisPosla.HeaderText = "Opis posla";
            this.OpisPosla.MinimumWidth = 6;
            this.OpisPosla.Name = "OpisPosla";
            this.OpisPosla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DatumPosla
            // 
            this.DatumPosla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DatumPosla.DataPropertyName = "Datum";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.DatumPosla.DefaultCellStyle = dataGridViewCellStyle8;
            this.DatumPosla.HeaderText = "Datum objave";
            this.DatumPosla.MinimumWidth = 6;
            this.DatumPosla.Name = "DatumPosla";
            this.DatumPosla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DatumPosla.Width = 105;
            // 
            // FormSlobodnaRadnaMjesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1377, 691);
            this.Controls.Add(this.tabControlSlobodnaRadnaMjesta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOpcijeRadnaMjesta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSlobodnaRadnaMjesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slobodna radna mjesta";
            this.Load += new System.EventHandler(this.FormKategorije_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeJobs)).EndInit();
            this.panelOpcijeRadnaMjesta.ResumeLayout(false);
            this.panelOpcijeRadnaMjesta.PerformLayout();
            this.tabControlSlobodnaRadnaMjesta.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRadnaMjestaBP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelOpcijeRadnaMjesta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAZ;
        private System.Windows.Forms.Button btnZA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox inptNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewFreeJobs;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox inptOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControlSlobodnaRadnaMjesta;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewRadnaMjestaBP;
        private System.Windows.Forms.Button buttonSrchDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPosao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivPosao;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpisPosla;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPosla;
    }
}