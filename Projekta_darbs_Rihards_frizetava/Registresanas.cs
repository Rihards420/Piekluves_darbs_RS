using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if(Datu_manipulesana.VaiTuksiLauki(Vards_TTB, Uzvards_TTB, E_pasts_TTB, Tel_nr_TTB, Parole_TTB))
            {
                bridinajums_label.Visible = true;
            }
            else
            {

            }
        }
    }

    public class Registresanas_dati
    {
        string Vards { get; set;}
        string Uzvards { get; set; }
        string E_pasts {get; set; }
        int Telefona_nr { get; set; }
        string  Parole { get; set; }

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
            // Create a SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(Parole));

                // Convert byte array to a string
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
                    return false; // Found an empty text box
                }
            }
            return true; // All text boxes are non-empty
        }

        public static bool CiparuParbaude(string vards)
        {
            foreach(char  c in vards)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show("Neizmantojiet ciparus vardam un uzvardam!");
                    return false;
                }
            }
            return true;
        }

        public static bool SimboluParbaude(string vards)
        {
            foreach (char c in vards)
            {
                if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')))

                    MessageBox.Show("Neizmantojiet simbolus vardam, uzvardam un telefona numuram!");
                    return false;
                
            }
            return true;
        }


    }
}
