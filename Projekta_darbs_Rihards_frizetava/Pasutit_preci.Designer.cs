namespace Projekta_darbs_Rihards_frizetava
{
    partial class Pasutit_preci
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
            this.label1 = new System.Windows.Forms.Label();
            this.Produkti = new System.Windows.Forms.CheckedListBox();
            this.Pasutit_produktu = new System.Windows.Forms.Button();
            this.Cena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produkti";
            // 
            // Produkti
            // 
            this.Produkti.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produkti.FormattingEnabled = true;
            this.Produkti.Location = new System.Drawing.Point(12, 57);
            this.Produkti.Name = "Produkti";
            this.Produkti.Size = new System.Drawing.Size(233, 304);
            this.Produkti.TabIndex = 2;
            this.Produkti.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Produkti_ItemCheck);
            // 
            // Pasutit_produktu
            // 
            this.Pasutit_produktu.BackColor = System.Drawing.Color.White;
            this.Pasutit_produktu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pasutit_produktu.Location = new System.Drawing.Point(374, 290);
            this.Pasutit_produktu.Name = "Pasutit_produktu";
            this.Pasutit_produktu.Size = new System.Drawing.Size(164, 71);
            this.Pasutit_produktu.TabIndex = 3;
            this.Pasutit_produktu.Text = "Pasūtīt";
            this.Pasutit_produktu.UseVisualStyleBackColor = false;
            this.Pasutit_produktu.Click += new System.EventHandler(this.Pasutit_produktu_Click);
            // 
            // Cena
            // 
            this.Cena.AutoSize = true;
            this.Cena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cena.Location = new System.Drawing.Point(370, 254);
            this.Cena.Name = "Cena";
            this.Cena.Size = new System.Drawing.Size(0, 19);
            this.Cena.TabIndex = 4;
            // 
            // Pasutit_preci
            // 
            this.AcceptButton = this.Pasutit_produktu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.Cena);
            this.Controls.Add(this.Pasutit_produktu);
            this.Controls.Add(this.Produkti);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pasutit_preci";
            this.Text = "Pasutit_preci";
            this.Load += new System.EventHandler(this.Pasutit_preci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox Produkti;
        private System.Windows.Forms.Button Pasutit_produktu;
        private System.Windows.Forms.Label Cena;
    }
}