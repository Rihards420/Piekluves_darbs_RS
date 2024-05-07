namespace Projekta_darbs_Rihards_frizetava
{
    partial class Pieteikties
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
            this.Pakalpojumi = new System.Windows.Forms.ListBox();
            this.Frizieri = new System.Windows.Forms.ListBox();
            this.DatumaIzvele = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Izveidot_pieteikumu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pakalpojumi
            // 
            this.Pakalpojumi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pakalpojumi.FormattingEnabled = true;
            this.Pakalpojumi.ItemHeight = 15;
            this.Pakalpojumi.Location = new System.Drawing.Point(33, 99);
            this.Pakalpojumi.Name = "Pakalpojumi";
            this.Pakalpojumi.Size = new System.Drawing.Size(152, 214);
            this.Pakalpojumi.TabIndex = 1;
            // 
            // Frizieri
            // 
            this.Frizieri.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frizieri.FormattingEnabled = true;
            this.Frizieri.ItemHeight = 15;
            this.Frizieri.Location = new System.Drawing.Point(227, 99);
            this.Frizieri.Name = "Frizieri";
            this.Frizieri.Size = new System.Drawing.Size(120, 214);
            this.Frizieri.TabIndex = 2;
            // 
            // DatumaIzvele
            // 
            this.DatumaIzvele.Location = new System.Drawing.Point(388, 99);
            this.DatumaIzvele.Name = "DatumaIzvele";
            this.DatumaIzvele.Size = new System.Drawing.Size(200, 20);
            this.DatumaIzvele.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Frizieri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pakalpojumi";
            // 
            // Izveidot_pieteikumu
            // 
            this.Izveidot_pieteikumu.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Izveidot_pieteikumu.Location = new System.Drawing.Point(415, 224);
            this.Izveidot_pieteikumu.Name = "Izveidot_pieteikumu";
            this.Izveidot_pieteikumu.Size = new System.Drawing.Size(145, 89);
            this.Izveidot_pieteikumu.TabIndex = 6;
            this.Izveidot_pieteikumu.Text = "Pieteikties";
            this.Izveidot_pieteikumu.UseVisualStyleBackColor = true;
            this.Izveidot_pieteikumu.Click += new System.EventHandler(this.Izveidot_pieteikumu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datums";
            // 
            // Pieteikties
            // 
            this.AcceptButton = this.Izveidot_pieteikumu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Izveidot_pieteikumu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatumaIzvele);
            this.Controls.Add(this.Frizieri);
            this.Controls.Add(this.Pakalpojumi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pieteikties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pieteikties";
            this.Load += new System.EventHandler(this.Pieteikties_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Pakalpojumi;
        private System.Windows.Forms.ListBox Frizieri;
        private System.Windows.Forms.DateTimePicker DatumaIzvele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Izveidot_pieteikumu;
        private System.Windows.Forms.Label label4;
    }
}