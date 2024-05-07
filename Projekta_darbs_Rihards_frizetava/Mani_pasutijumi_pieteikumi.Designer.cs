namespace Projekta_darbs_Rihards_frizetava
{
    partial class Mani_pasutijumi_pieteikumi
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
            this.Pieteikumi_gridView = new System.Windows.Forms.DataGridView();
            this.Pasutijumi_gridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IzveletiesPieteikumu = new System.Windows.Forms.ListBox();
            this.Atcelt_pieteikumu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pieteikumi_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pasutijumi_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mani pasūtijumi/Pieteikumi";
            // 
            // Pieteikumi_gridView
            // 
            this.Pieteikumi_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pieteikumi_gridView.Location = new System.Drawing.Point(12, 90);
            this.Pieteikumi_gridView.Name = "Pieteikumi_gridView";
            this.Pieteikumi_gridView.Size = new System.Drawing.Size(240, 150);
            this.Pieteikumi_gridView.TabIndex = 2;
            // 
            // Pasutijumi_gridView
            // 
            this.Pasutijumi_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pasutijumi_gridView.Location = new System.Drawing.Point(348, 90);
            this.Pasutijumi_gridView.Name = "Pasutijumi_gridView";
            this.Pasutijumi_gridView.Size = new System.Drawing.Size(240, 150);
            this.Pasutijumi_gridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pieteikumi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pasūtījumi";
            // 
            // IzveletiesPieteikumu
            // 
            this.IzveletiesPieteikumu.FormattingEnabled = true;
            this.IzveletiesPieteikumu.Location = new System.Drawing.Point(12, 246);
            this.IzveletiesPieteikumu.Name = "IzveletiesPieteikumu";
            this.IzveletiesPieteikumu.Size = new System.Drawing.Size(120, 95);
            this.IzveletiesPieteikumu.TabIndex = 6;
            // 
            // Atcelt_pieteikumu
            // 
            this.Atcelt_pieteikumu.Location = new System.Drawing.Point(12, 347);
            this.Atcelt_pieteikumu.Name = "Atcelt_pieteikumu";
            this.Atcelt_pieteikumu.Size = new System.Drawing.Size(75, 23);
            this.Atcelt_pieteikumu.TabIndex = 7;
            this.Atcelt_pieteikumu.Text = "Atcelt";
            this.Atcelt_pieteikumu.UseVisualStyleBackColor = true;
            this.Atcelt_pieteikumu.Click += new System.EventHandler(this.Atcelt_pieteikumu_Click);
            // 
            // Mani_pasutijumi_pieteikumi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.Atcelt_pieteikumu);
            this.Controls.Add(this.IzveletiesPieteikumu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pasutijumi_gridView);
            this.Controls.Add(this.Pieteikumi_gridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mani_pasutijumi_pieteikumi";
            this.Text = "Mani_pasutijumi_pieteikumi";
            this.Load += new System.EventHandler(this.Mani_pasutijumi_pieteikumi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pieteikumi_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pasutijumi_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Pieteikumi_gridView;
        private System.Windows.Forms.DataGridView Pasutijumi_gridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox IzveletiesPieteikumu;
        private System.Windows.Forms.Button Atcelt_pieteikumu;
    }
}