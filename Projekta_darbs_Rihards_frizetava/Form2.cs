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
using System.Data.SQLite;
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
                if(IsValidUser(Pierakstisanas_e_pasts.Text, pierakstisanas_parole.Text))
                {
                    MessageBox.Show("Ielogjies");
                    Form1 f = new Form1();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ievadiet pareizi E-pastu un paroli!");
                }

            }
            else
            {
                MessageBox.Show("Aizpildiet laukus");
            }
        }
        // Notira datus ievaditajos laukos
        private void Notirit_laukus(object sender, EventArgs e)
        {
            Datu_manipulesana.NotiritTekstu(Pierakstisanas_e_pasts, pierakstisanas_parole);
        }
        private bool IsValidUser(string E_pasts, string Parole)
        {
            string query = "SELECT * FROM Klients WHERE E_pasts=@Epasts AND Parole=@Password";

            using (SQLiteConnection connection = Registresanas_dati.Konekcija())
            {
                try
                {
                    connection.Open();

                    if (connection.State == ConnectionState.Open)
                    {
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Epasts", E_pasts);
                            command.Parameters.AddWithValue("@Password", Datu_manipulesana.SHA256_HASH(Parole));

                            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);

                                command.ExecuteNonQuery();
                                connection.Close();

                                if (dt.Rows.Count > 0)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kļūda: " + ex.Message);
                }
            }

            return false; // Return false if any error occurs
        }

        private void aiztaisit_programmu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
