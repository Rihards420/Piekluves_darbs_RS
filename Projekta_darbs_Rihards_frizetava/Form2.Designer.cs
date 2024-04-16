namespace Projekta_darbs_Rihards_frizetava
{
    partial class Pierakstisanas
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
            this.Pierakstisanas_e_pasts = new System.Windows.Forms.MaskedTextBox();
            this.Pierakstisanas_parole = new System.Windows.Forms.TextBox();
            this.Pierakstisanas_poga = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Registresanas_parvietosana = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Radit_tekstu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "E-pasts";
            // 
            // Pierakstisanas_e_pasts
            // 
            this.Pierakstisanas_e_pasts.Location = new System.Drawing.Point(83, 154);
            this.Pierakstisanas_e_pasts.Name = "Pierakstisanas_e_pasts";
            this.Pierakstisanas_e_pasts.Size = new System.Drawing.Size(155, 20);
            this.Pierakstisanas_e_pasts.TabIndex = 7;
            // 
            // Pierakstisanas_parole
            // 
            this.Pierakstisanas_parole.Location = new System.Drawing.Point(83, 206);
            this.Pierakstisanas_parole.Name = "Pierakstisanas_parole";
            this.Pierakstisanas_parole.Size = new System.Drawing.Size(155, 20);
            this.Pierakstisanas_parole.TabIndex = 6;
            this.Pierakstisanas_parole.UseSystemPasswordChar = true;
            // 
            // Pierakstisanas_poga
            // 
            this.Pierakstisanas_poga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(192)))), ((int)(((byte)(164)))));
            this.Pierakstisanas_poga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pierakstisanas_poga.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pierakstisanas_poga.Location = new System.Drawing.Point(112, 232);
            this.Pierakstisanas_poga.Name = "Pierakstisanas_poga";
            this.Pierakstisanas_poga.Size = new System.Drawing.Size(93, 39);
            this.Pierakstisanas_poga.TabIndex = 9;
            this.Pierakstisanas_poga.Text = "Pierakstities";
            this.Pierakstisanas_poga.UseVisualStyleBackColor = false;
            this.Pierakstisanas_poga.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Parole";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Neesi reģistrēts?";
            // 
            // Registresanas_parvietosana
            // 
            this.Registresanas_parvietosana.Location = new System.Drawing.Point(123, 345);
            this.Registresanas_parvietosana.Name = "Registresanas_parvietosana";
            this.Registresanas_parvietosana.Size = new System.Drawing.Size(75, 23);
            this.Registresanas_parvietosana.TabIndex = 12;
            this.Registresanas_parvietosana.Text = "Reģistrēties";
            this.Registresanas_parvietosana.UseVisualStyleBackColor = true;
            this.Registresanas_parvietosana.Click += new System.EventHandler(this.Registresanas_parvietosana_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(84, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pierakstīšanās";
            // 
            // Radit_tekstu
            // 
            this.Radit_tekstu.BackgroundImage = global::Projekta_darbs_Rihards_frizetava.Properties.Resources.rsz_lupa;
            this.Radit_tekstu.Location = new System.Drawing.Point(244, 206);
            this.Radit_tekstu.Name = "Radit_tekstu";
            this.Radit_tekstu.Size = new System.Drawing.Size(20, 23);
            this.Radit_tekstu.TabIndex = 14;
            this.Radit_tekstu.UseVisualStyleBackColor = true;
            // 
            // Pierakstisanas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.Controls.Add(this.Radit_tekstu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Registresanas_parvietosana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pierakstisanas_poga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pierakstisanas_e_pasts);
            this.Controls.Add(this.Pierakstisanas_parole);
            this.Name = "Pierakstisanas";
            this.Text = "Pierakstisanas";
            this.Load += new System.EventHandler(this.Pierakstisanas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Pierakstisanas_e_pasts;
        private System.Windows.Forms.TextBox Pierakstisanas_parole;
        private System.Windows.Forms.Button Pierakstisanas_poga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Registresanas_parvietosana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Radit_tekstu;
    }
}