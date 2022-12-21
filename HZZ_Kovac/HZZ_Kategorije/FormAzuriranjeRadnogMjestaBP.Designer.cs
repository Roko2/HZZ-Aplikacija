namespace HZZ_Kategorije
{
    partial class FormAzuriranjeRadnogMjestaBP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAzuriranjeRadnogMjestaBP));
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblIDPosla = new System.Windows.Forms.Label();
            this.lblNazivPosla = new System.Windows.Forms.Label();
            this.lblOpisPosla = new System.Windows.Forms.Label();
            this.lblDatumSpremanja = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxNaziv = new System.Windows.Forms.TextBox();
            this.richTxtBoxOpis = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerSpremanja = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.LightGreen;
            this.btnAzuriraj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAzuriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzuriraj.Image = ((System.Drawing.Image)(resources.GetObject("btnAzuriraj.Image")));
            this.btnAzuriraj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAzuriraj.Location = new System.Drawing.Point(391, 379);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(151, 46);
            this.btnAzuriraj.TabIndex = 11;
            this.btnAzuriraj.Text = "     Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOdustani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Image = ((System.Drawing.Image)(resources.GetObject("btnOdustani.Image")));
            this.btnOdustani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustani.Location = new System.Drawing.Point(131, 379);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(151, 46);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "       Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.Location = new System.Drawing.Point(181, 36);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(305, 25);
            this.lblNaslov.TabIndex = 13;
            this.lblNaslov.Text = "Ažuriranje radnog mjesta baze\r\n";
            // 
            // lblIDPosla
            // 
            this.lblIDPosla.AutoSize = true;
            this.lblIDPosla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIDPosla.Location = new System.Drawing.Point(153, 105);
            this.lblIDPosla.Name = "lblIDPosla";
            this.lblIDPosla.Size = new System.Drawing.Size(26, 18);
            this.lblIDPosla.TabIndex = 14;
            this.lblIDPosla.Text = "Id ";
            // 
            // lblNazivPosla
            // 
            this.lblNazivPosla.AutoSize = true;
            this.lblNazivPosla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivPosla.Location = new System.Drawing.Point(128, 154);
            this.lblNazivPosla.Name = "lblNazivPosla";
            this.lblNazivPosla.Size = new System.Drawing.Size(50, 18);
            this.lblNazivPosla.TabIndex = 15;
            this.lblNazivPosla.Text = "Naziv";
            // 
            // lblOpisPosla
            // 
            this.lblOpisPosla.AutoSize = true;
            this.lblOpisPosla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisPosla.Location = new System.Drawing.Point(136, 204);
            this.lblOpisPosla.Name = "lblOpisPosla";
            this.lblOpisPosla.Size = new System.Drawing.Size(43, 18);
            this.lblOpisPosla.TabIndex = 16;
            this.lblOpisPosla.Text = "Opis";
            // 
            // lblDatumSpremanja
            // 
            this.lblDatumSpremanja.AutoSize = true;
            this.lblDatumSpremanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumSpremanja.Location = new System.Drawing.Point(38, 314);
            this.lblDatumSpremanja.Name = "lblDatumSpremanja";
            this.lblDatumSpremanja.Size = new System.Drawing.Size(140, 18);
            this.lblDatumSpremanja.TabIndex = 17;
            this.lblDatumSpremanja.Text = "Datum spremanja";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Enabled = false;
            this.txtBoxID.Location = new System.Drawing.Point(237, 105);
            this.txtBoxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(60, 22);
            this.txtBoxID.TabIndex = 18;
            // 
            // txtBoxNaziv
            // 
            this.txtBoxNaziv.Location = new System.Drawing.Point(237, 154);
            this.txtBoxNaziv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxNaziv.Name = "txtBoxNaziv";
            this.txtBoxNaziv.Size = new System.Drawing.Size(477, 22);
            this.txtBoxNaziv.TabIndex = 20;
            // 
            // richTxtBoxOpis
            // 
            this.richTxtBoxOpis.Location = new System.Drawing.Point(237, 203);
            this.richTxtBoxOpis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTxtBoxOpis.Name = "richTxtBoxOpis";
            this.richTxtBoxOpis.Size = new System.Drawing.Size(477, 87);
            this.richTxtBoxOpis.TabIndex = 21;
            this.richTxtBoxOpis.Text = "";
            // 
            // dateTimePickerSpremanja
            // 
            this.dateTimePickerSpremanja.Enabled = false;
            this.dateTimePickerSpremanja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSpremanja.Location = new System.Drawing.Point(237, 310);
            this.dateTimePickerSpremanja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerSpremanja.Name = "dateTimePickerSpremanja";
            this.dateTimePickerSpremanja.Size = new System.Drawing.Size(253, 22);
            this.dateTimePickerSpremanja.TabIndex = 22;
            // 
            // FormAzuriranjeRadnogMjestaBP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.dateTimePickerSpremanja);
            this.Controls.Add(this.richTxtBoxOpis);
            this.Controls.Add(this.txtBoxNaziv);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.lblDatumSpremanja);
            this.Controls.Add(this.lblOpisPosla);
            this.Controls.Add(this.lblNazivPosla);
            this.Controls.Add(this.lblIDPosla);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnAzuriraj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAzuriranjeRadnogMjestaBP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ažuriranje radnog mjesta baze";
            this.Load += new System.EventHandler(this.FormAzuriranjeRadnogMjestaBP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblIDPosla;
        private System.Windows.Forms.Label lblNazivPosla;
        private System.Windows.Forms.Label lblOpisPosla;
        private System.Windows.Forms.Label lblDatumSpremanja;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxNaziv;
        private System.Windows.Forms.RichTextBox richTxtBoxOpis;
        private System.Windows.Forms.DateTimePicker dateTimePickerSpremanja;
    }
}