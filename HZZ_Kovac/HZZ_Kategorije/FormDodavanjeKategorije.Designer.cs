
namespace HZZ_Kategorije
{
    partial class FormDodavanjeKategorije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodavanjeKategorije));
            this.lblDodavanje = new System.Windows.Forms.Label();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDodavanje
            // 
            this.lblDodavanje.AutoSize = true;
            this.lblDodavanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDodavanje.Location = new System.Drawing.Point(81, 37);
            this.lblDodavanje.Name = "lblDodavanje";
            this.lblDodavanje.Size = new System.Drawing.Size(251, 25);
            this.lblDodavanje.TabIndex = 1;
            this.lblDodavanje.Text = "Dodaj kategoriju u bazu?";
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonOdustani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOdustani.Image = ((System.Drawing.Image)(resources.GetObject("buttonOdustani.Image")));
            this.buttonOdustani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOdustani.Location = new System.Drawing.Point(27, 140);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(151, 46);
            this.buttonOdustani.TabIndex = 3;
            this.buttonOdustani.Text = "       Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = false;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodaj.Image = ((System.Drawing.Image)(resources.GetObject("buttonDodaj.Image")));
            this.buttonDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDodaj.Location = new System.Drawing.Point(222, 140);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(151, 46);
            this.buttonDodaj.TabIndex = 4;
            this.buttonDodaj.Text = "  Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // FormDodavanjeKategorije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(422, 243);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.lblDodavanje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDodavanjeKategorije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Potvrda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDodavanje;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Button buttonDodaj;
    }
}