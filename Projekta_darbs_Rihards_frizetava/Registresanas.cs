using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekta_darbs_Rihards_frizetava
{
    public partial class Registresanas : Form
    {
        public Registresanas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Registresanas_Load(object sender, EventArgs e)
        {

        }
        private void notirit_laukus_Click(object sender, EventArgs e)
        {
            Datu_manipulesana.NotiritTekstu(Vards_TTB, Uzvards_TTB, E_pasts_TTB, Tel_nr_TTB, Parole_TTB);
        }

        private void Registresanas_poga_Click(object sender, EventArgs e)
        {
            if (!Datu_manipulesana.VaiTuksiLauki(Vards_TTB, Uzvards_TTB, E_pasts_TTB, Tel_nr_TTB, Parole_TTB))
            {
                bridinajums_label.Visible = true;
            }
            else
            {
                if (Datu_manipulesana.Varda_parbaude(Vards_TTB.Text))
                {
                    MessageBox.Show("True strada");
                }
                else
                {
                    MessageBox.Show("False strada");
                }

            }
        }

        private void Paradit_paroli_MouseDown(object sender, MouseEventArgs e)
        {
            Parole_TTB.UseSystemPasswordChar = false;
        }

        private void Paradit_paroli_MouseUp(object sender, MouseEventArgs e)
        {
            Parole_TTB.UseSystemPasswordChar = true;
        }
    }

    public class Registresanas_dati
    {
        public string Vards { get; set; }
        public string Uzvards { get; set; }
        public string E_pasts { get; set; }
        public int Telefona_nr { get; set; }
        public string Parole { get; set; }
    }

    static class Datu_manipulesana
    {
        public static void NotiritTekstu(params MaskedTextBox[] textBoxes)
        {
            foreach (MaskedTextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
        }

        public static string SHA256_HASH(string Parole)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(Parole));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool VaiTuksiLauki(params MaskedTextBox[] textBoxes)
        {
            foreach (MaskedTextBox textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false;
                }
            }
            return true;
        }


        public static bool Varda_parbaude(string vards)
        {
            bool parbaude = true;

            foreach (char c in vards)
            {

                if (((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))

                {
                    continue;
                }
                else
                {
                    MessageBox.Show("Lūdzu ievadiet vārdu bez simboliem un cipariem!");
                    parbaude = false;
                    return parbaude;
                }
                
            }
            return parbaude;
        }
    }
}