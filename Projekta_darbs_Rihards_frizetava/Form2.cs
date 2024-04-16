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

        private void button1_Click(object sender, EventArgs e)
        {
            Pierakstisanas_parole.Text = SHA256_HASH(Pierakstisanas_e_pasts.Text);
        }

        static string SHA256_HASH(string Parole)
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

        private void Registresanas_parvietosana_Click(object sender, EventArgs e)
        {
            Pierakstisanas pie = new Pierakstisanas();
            Registresanas reg = new Registresanas();
            reg.Show();
            pie.Close();
          
        }
    }

    public class Pierakstisanas_dati
    {
        string e_pasts {get; set;}
        string parole  {get; set;}
    }
}
