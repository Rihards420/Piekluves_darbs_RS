using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SQLite;

namespace Projekta_darbs_Rihards_frizetava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void loadform(object Form)
        {
            if (this.Galvenais_panelis.Controls.Count > 0)
                this.Galvenais_panelis.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Galvenais_panelis.Controls.Add(f);
            this.Galvenais_panelis.Tag = f;
            f.Show();
        }


        private void Pieteikumi_Pasutijumi_Click(object sender, EventArgs e)
        {
            loadform(new Mani_pasutijumi_pieteikumi());
        }

        private void Pieteikties_Click(object sender, EventArgs e)
        {
            loadform(new Pieteikties());
        }

        private void Pasutit_preci_Click(object sender, EventArgs e)
        {
            loadform(new Pasutit_preci());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void augsas_panelis_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Aizversanas_poga_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Galvenais_ekrans_Click(object sender, EventArgs e)
        {
            loadform(new Galvenais_ekrans());
        }
    }

    
}
