namespace Projekta_darbs_Rihards_frizetava
{
    partial class Form1
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
            this.Vards_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Uzvards_text = new System.Windows.Forms.TextBox();
            this.Tel_numurs_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Pierakstisanas_poga = new System.Windows.Forms.Button();
            this.Izvele_list = new System.Windows.Forms.CheckedListBox();
            this.Saraksta_poga = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Vards_text
            // 
            this.Vards_text.Location = new System.Drawing.Point(337, 58);
            this.Vards_text.Name = "Vards_text";
            this.Vards_text.Size = new System.Drawing.Size(100, 20);
            this.Vards_text.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vards";
            // 
            // Uzvards_text
            // 
            this.Uzvards_text.Location = new System.Drawing.Point(337, 84);
            this.Uzvards_text.Name = "Uzvards_text";
            this.Uzvards_text.Size = new System.Drawing.Size(100, 20);
            this.Uzvards_text.TabIndex = 2;
            // 
            // Tel_numurs_text
            // 
            this.Tel_numurs_text.Location = new System.Drawing.Point(337, 110);
            this.Tel_numurs_text.Name = "Tel_numurs_text";
            this.Tel_numurs_text.Size = new System.Drawing.Size(100, 20);
            this.Tel_numurs_text.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Uzvards";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefona_nr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label4.Location = new System.Drawing.Point(307, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Frizetava";
            // 
            // Pierakstisanas_poga
            // 
            this.Pierakstisanas_poga.Location = new System.Drawing.Point(337, 136);
            this.Pierakstisanas_poga.Name = "Pierakstisanas_poga";
            this.Pierakstisanas_poga.Size = new System.Drawing.Size(100, 23);
            this.Pierakstisanas_poga.TabIndex = 7;
            this.Pierakstisanas_poga.Text = "Pierakstities";
            this.Pierakstisanas_poga.UseVisualStyleBackColor = true;
            this.Pierakstisanas_poga.Click += new System.EventHandler(this.Pierakstisanas_poga_Click);
            // 
            // Izvele_list
            // 
            this.Izvele_list.FormattingEnabled = true;
            this.Izvele_list.Items.AddRange(new object[] {
            "Matu mazgasana",
            "Matu griezsana",
            "Matu krasosana",
            "Bardas skusana"});
            this.Izvele_list.Location = new System.Drawing.Point(211, 58);
            this.Izvele_list.Name = "Izvele_list";
            this.Izvele_list.Size = new System.Drawing.Size(120, 94);
            this.Izvele_list.TabIndex = 8;
            // 
            // Saraksta_poga
            // 
            this.Saraksta_poga.Location = new System.Drawing.Point(337, 383);
            this.Saraksta_poga.Name = "Saraksta_poga";
            this.Saraksta_poga.Size = new System.Drawing.Size(100, 23);
            this.Saraksta_poga.TabIndex = 9;
            this.Saraksta_poga.Text = "Saraksts";
            this.Saraksta_poga.UseVisualStyleBackColor = true;
            this.Saraksta_poga.Click += new System.EventHandler(this.Saraksta_poga_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(519, 58);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Saraksta_poga);
            this.Controls.Add(this.Izvele_list);
            this.Controls.Add(this.Pierakstisanas_poga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tel_numurs_text);
            this.Controls.Add(this.Uzvards_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vards_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Vards_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Uzvards_text;
        private System.Windows.Forms.TextBox Tel_numurs_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Pierakstisanas_poga;
        private System.Windows.Forms.CheckedListBox Izvele_list;
        private System.Windows.Forms.Button Saraksta_poga;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

