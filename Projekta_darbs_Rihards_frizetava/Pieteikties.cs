using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekta_darbs_Rihards_frizetava
{
    public partial class Pieteikties : Form
    {
        public Pieteikties()
        {
            InitializeComponent();
        }

        private void Pieteikties_Load(object sender, EventArgs e)
        {
            DatumaIzvele.MinDate = DateTime.Now;
            DatumaIzvele.MaxDate = DateTime.Now.AddDays(30);



            AizpilditListBox("Vards", "Frizieris", Frizieri);
            AizpilditListBox("Pakalpojuma_nosaukums", "Pakalpojums", Pakalpojumi);
        }


        private void AizpilditListBox(string KolonasNosaukums, string TabulasNosaukums, ListBox listbox)
        {
            // Clear existing items in the listbox
            listbox.Items.Clear();

            // Connect to the SQLite database
            using (SQLiteConnection connection = Registresanas_dati.Konekcija())
            {
                connection.Open();

                // Execute the query to retrieve procedures
                string query = $"SELECT {KolonasNosaukums} FROM {TabulasNosaukums}";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        // Populate the listbox with procedures
                        while (reader.Read())
                        {
                            listbox.Items.Add(reader[KolonasNosaukums]);
                        }
                    }
                }

                connection.Close();
            }
        }

        private void Izveidot_pieteikumu_Click(object sender, EventArgs e)
        {
            string pakalpojums = Pakalpojumi.SelectedItem.ToString();
            string frizieris = Frizieri.SelectedItem.ToString();
            string datums = DatumaIzvele.Value.ToString("dd/MM/yy");
            SaglabatPieteikumu(pakalpojums, frizieris, datums);
        }

        private void SaglabatPieteikumu(string IzveletaisPakalpojums, string IzveletaisFrizieris, string datums)
        {
            int pakalpojumaID = Pieteikuma_dati.IegutID("Pakalpojums_ID", "Pakalpojums", "Pakalpojuma_nosaukums", IzveletaisPakalpojums);
            int frizieraID = Pieteikuma_dati.IegutID("Frizieris_ID", "Frizieris", "Vards", IzveletaisFrizieris);
            MessageBox.Show(frizieraID.ToString());
            int klientaID = KlientaInfo.Klienta_ID;
            if (pakalpojumaID != -1 && frizieraID != -1 && klientaID != -1)
            {
                // Insert the pieteikums into the Pieteikums table
                string query = "INSERT INTO Pieteikums (klients_ID, Frizieris_ID, Pakalpojums_ID, Vai_atcelts, Datums) VALUES (@KlientsID, @FrizieraID, @PakalpojumaID, 'nē', @Datums)";

                using (SQLiteConnection connection = Registresanas_dati.Konekcija())
                {
                    try
                    {
                        connection.Open();

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            // Add parameters for the insert query
                            command.Parameters.AddWithValue("@KlientsID", klientaID);
                            command.Parameters.AddWithValue("@PakalpojumaID", pakalpojumaID);
                            command.Parameters.AddWithValue("@FrizieraID", frizieraID);
                            command.Parameters.AddWithValue("@Datums", datums);

                            // Execute the insert query
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kļūda: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kaut kas aizgāja greizi.");
            } 
        }

        public class Pieteikuma_dati
        {
            public string Pakalpojums { get; set; }
            public string Friziieris { get; set; }

            public string Vai_atcelts = "nē";
            public string Datums { get; set; }

            public static int IegutID(string KolonasNosaukums, string TabulasNosaukums, string Parbaudeskolona, string Vertiba)
            {
                int ID = -1;

                string query = $"SELECT {KolonasNosaukums} FROM {TabulasNosaukums} WHERE {Parbaudeskolona} = @vertiba";

                using (SQLiteConnection connection = Registresanas_dati.Konekcija())
                {
                    try
                    {
                        connection.Open();

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            // Add parameter for selected value
                            command.Parameters.AddWithValue("@vertiba", Vertiba);

                            // Execute the query and retrieve the ID
                            object result = command.ExecuteScalar();

                            if (result != null)
                            {
                                ID = Convert.ToInt32(result);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kļūda: " + ex.Message);
                    }
                }

                return ID;
            }

        }
    }
}
