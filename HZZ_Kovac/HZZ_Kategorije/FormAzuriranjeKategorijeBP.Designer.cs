
namespace HZZ_Kategorije
{
    partial class FormAzuriranjeKategorijeBP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAzuriranjeKategorijeBP));
            this.label1 = new System.Windows.Forms.Label();
            this.lblIDKategorije = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.inptNazivKategorije = new System.Windows.Forms.TextBox();
            this.inptUrlKategorije = new System.Windows.Forms.TextBox();
            this.dateTimePickerObjava = new System.Windows.Forms.DateTimePicker();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(209, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ažuriranje kategorije baze\r\n";
            // 
            // lblIDKategorije
            // 
            this.lblIDKategorije.AutoSize = true;
            this.lblIDKategorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIDKategorije.Location = new System.Drawing.Point(159, 117);
            this.lblIDKategorije.Name = "lblIDKategorije";
            this.lblIDKategorije.Size = new System.Drawing.Size(26, 18);
            this.lblIDKategorije.TabIndex = 1;
            this.lblIDKategorije.Text = "Id ";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(135, 162);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(50, 18);
            this.lblNaziv.TabIndex = 2;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblURL.Location = new System.Drawing.Point(152, 210);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(30, 18);
            this.lblURL.TabIndex = 3;
            this.lblURL.Text = "Url";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDate.Location = new System.Drawing.Point(12, 252);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(195, 18);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Datum spremanja u bazu";
            // 
            // inptNazivKategorije
            // 
            this.inptNazivKategorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inptNazivKategorije.Location = new System.Drawing.Point(249, 158);
            this.inptNazivKategorije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inptNazivKategorije.Name = "inptNazivKategorije";
            this.inptNazivKategorije.Size = new System.Drawing.Size(427, 24);
            this.inptNazivKategorije.TabIndex = 6;
            // 
            // inptUrlKategorije
            // 
            this.inptUrlKategorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inptUrlKategorije.Location = new System.Drawing.Point(249, 210);
            this.inptUrlKategorije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inptUrlKategorije.Name = "inptUrlKategorije";
            this.inptUrlKategorije.Size = new System.Drawing.Size(427, 24);
            this.inptUrlKategorije.TabIndex = 7;
            // 
            // dateTimePickerObjava
            // 
            this.dateTimePickerObjava.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerObjava.Enabled = false;
            this.dateTimePickerObjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerObjava.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerObjava.Location = new System.Drawing.Point(247, 252);
            this.dateTimePickerObjava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerObjava.MaxDate = new System.DateTime(2109, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerObjava.MinDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerObjava.Name = "dateTimePickerObjava";
            this.dateTimePickerObjava.Size = new System.Drawing.Size(252, 24);
            this.dateTimePickerObjava.TabIndex = 8;
            this.dateTimePickerObjava.Value = new System.DateTime(2021, 1, 17, 0, 0, 0, 0);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOdustani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Image = ((System.Drawing.Image)(resources.GetObject("btnOdustani.Image")));
            this.btnOdustani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustani.Location = new System.Drawing.Point(139, 336);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(151, 46);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "       Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.LightGreen;
            this.btnAzuriraj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAzuriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzuriraj.Image = ((System.Drawing.Image)(resources.GetObject("btnAzuriraj.Image")));
            this.btnAzuriraj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAzuriraj.Location = new System.Drawing.Point(393, 336);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(151, 46);
            this.btnAzuriraj.TabIndex = 10;
            this.btnAzuriraj.Text = "     Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // txtBoxID
            // 
            this.txtBoxID.Enabled = false;
            this.txtBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxID.Location = new System.Drawing.Point(249, 117);
            this.txtBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.ReadOnly = true;
            this.txtBoxID.Size = new System.Drawing.Size(68, 24);
            this.txtBoxID.TabIndex = 11;
            this.txtBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormAzuriranjeKategorijeBP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(732, 422);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.dateTimePickerObjava);
            this.Controls.Add(this.inptUrlKategorije);
            this.Controls.Add(this.inptNazivKategorije);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblIDKategorije);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAzuriranjeKategorijeBP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ažuriranje kategorije baze";
            this.Load += new System.EventHandler(this.FormAzuriranjeKategorijeBP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIDKategorije;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox inptNazivKategorije;
        private System.Windows.Forms.TextBox inptUrlKategorije;
        private System.Windows.Forms.DateTimePicker dateTimePickerObjava;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.TextBox txtBoxID;
    }
}