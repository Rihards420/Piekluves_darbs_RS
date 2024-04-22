using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Projekta_darbs_Rihards_frizetava
{
    public partial class Pierakstisanas : Form
    {
        public Pierakstisanas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Pierakstisanas_Load(object sender, EventArgs e)
        {

        }


        private void Registresanas_parvietosana_Click(object sender, EventArgs e)
        {
            Registresanas reg = new Registresanas();
            reg.Show();
            this.Hide();
          
        }

        private void Radit_tekstu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pierakstisanas_parole.UseSystemPasswordChar = false;
            }
        }

        private void Radit_tekstu_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pierakstisanas_parole.UseSystemPasswordChar = true;
            }
        }
        // Pieraksta lietotaju aplikacija
        private void Pierakstities_click(object sender, EventArgs e)
        {
            if(Datu_manipulesana.VaiTuksiLauki(Pierakstisanas_e_pasts, pierakstisanas_parole))
            {
                MessageBox.Show("wow");
            }
            else
            {
                Form1 f = new Form1();
                f.ShowDialog();
                this.Close();
            }
        }
        // Notira datus ievaditajos laukos
        private void Notirit_laukus(object sender, EventArgs e)
        {
            Datu_manipulesana.NotiritTekstu(Pierakstisanas_e_pasts, pierakstisanas_parole);
        }
    }
}
