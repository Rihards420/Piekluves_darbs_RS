using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
                    Registresanas_dati reg = new Registresanas_dati();
                    reg.Vards = Vards_TTB.Text;
                    reg.Uzvards = Uzvards_TTB.Text;
                    reg.Telefona_nr = Convert.ToInt32(Tel_nr_TTB.Text);
                    reg.E_pasts = E_pasts_TTB.Text;
                    reg.Parole = Parole_TTB.Text;

                    reg.registrelietotaju();
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Dispose();

                }
                else
                {
                    
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

        private void aiztaisit_programmu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Atpakal_poga_Click(object sender, EventArgs e)
        {
            Pierakstisanas pie = new Pierakstisanas();
            pie.Show();
            this.Dispose();
        }
    }

    public class Registresanas_dati
    {
        public string Vards { get; set; }
        public string Uzvards { get; set; }
        public string E_pasts { get; set; }
        public int Telefona_nr { get; set; }
        public string Parole { get; set; }

        public void registrelietotaju()
        {
            // Open the connection within the method scope
            using (SQLiteConnection connection = Konekcija())
            {
                try
                {
                    // Open the connection explicitly
                    connection.Open();

                    // Check if the connection is open
                    if (connection.State == ConnectionState.Open)
                    {
                        // Execute the command
                        string query = "INSERT INTO Klients (Vards, Uzvards, Telefona_numurs, E_pasts, Parole) " +
                                       "VALUES (@Vards, @Uzvards, @Telefona_numurs, @E_pasts, @Parole)";

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            // Set parameters
                            command.Parameters.AddWithValue("@Vards", Vards);
                            command.Parameters.AddWithValue("@Uzvards", Uzvards);
                            command.Parameters.AddWithValue("@Telefona_numurs", Telefona_nr);
                            command.Parameters.AddWithValue("@E_pasts", E_pasts);
                            command.Parameters.AddWithValue("@Parole", Datu_manipulesana.SHA256_HASH(Parole));

                            // Execute command
                            command.ExecuteNonQuery();
                            command.Parameters.Clear();
                            connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Savienojums netika izveidots");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kļūda: " + ex.Message);
                }
            }
        }

        // Move the connection method outside the class or refactor it to an instance method
        public static SQLiteConnection Konekcija()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection(@"Data Source= ..\..\Faili\Frizetava_datubaze_SQLite.db; Version = 3;");
            try
            {
                // Do not open the connection here
            }
            catch (Exception ex)
            {
                // Handle exception
            }
            return sqlite_conn;
        }

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