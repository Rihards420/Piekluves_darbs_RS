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
    public partial class Mani_pasutijumi_pieteikumi : Form
    {
        public Mani_pasutijumi_pieteikumi()
        {
            InitializeComponent();
        }

        private void Mani_pasutijumi_pieteikumi_Load(object sender, EventArgs e)
        {
            AizpilditLaukus();
            AizpilditListBox("Pieteikuma_ID", "Pieteikums", IzveletiesPieteikumu);
        }

        private void AizpilditLaukus()
        {

            string query = "SELECT Frizieris_ID, Pakalpojums_ID, Vai_atcelts, Datums FROM Pieteikums WHERE Klients_ID = @KlientsID";

            using (SQLiteConnection connection = Registresanas_dati.Konekcija())
            {

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@KlientsID", KlientaInfo.Klienta_ID);

                    DataTable dataTable = new DataTable();

                    try
                    {
                        connection.Open();
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {

                            adapter.Fill(dataTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                    Pieteikumi_gridView.DataSource = dataTable;
                }
                connection.Close();
            }

        }


        private void AizpilditListBox(string KolonasNosaukums, string TabulasNosaukums, ListBox listbox)
        {
            listbox.Items.Clear();

            using (SQLiteConnection connection = Registresanas_dati.Konekcija())
            {
                connection.Open();

                string query = $"SELECT {KolonasNosaukums}  FROM {TabulasNosaukums} WHERE Klients_ID = @KlientaID AND Vai_atcelts = 'nē'";


                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@KlientaID", KlientaInfo.Klienta_ID);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listbox.Items.Add(reader[KolonasNosaukums]);
                        }
                    }
                }

                connection.Close();
            }
        }

        private void Atcelt_pieteikumu_Click(object sender, EventArgs e)
        {
            if (IzveletiesPieteikumu.SelectedItem != null)
            {
                // Extract the appointment ID from the selected item
                string IzveletaVertiba = IzveletiesPieteikumu.SelectedItem.ToString();
                int appointmentID = DabutPieteikumaID(IzveletaVertiba);

                // Update the appointment in the database to mark it as canceled
                if (AtceltPieteikumu(appointmentID))
                {
                    // Remove the canceled appointment from the list
                    IzveletiesPieteikumu.Items.Remove(IzveletaVertiba);
                    MessageBox.Show("Atcelts veiksmīgi.");
                }
                else
                {
                    MessageBox.Show("Kaut kas nesanāca.");
                }
            }
            else
            {
                MessageBox.Show("izvēlieties ko atcelt.");
            }
        }

        private bool AtceltPieteikumu(int PieteikumaID)
        {
            // Update the appointment in the database to mark it as canceled
            using (SQLiteConnection connection = Registresanas_dati.Konekcija())
            {
                string updateQuery = "UPDATE Pieteikums SET Vai_atcelts = 'Jā' WHERE Pieteikuma_ID = @PieteikumaID";
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@PieteikumaID", PieteikumaID);
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kļūda " + ex.Message);
                        return false;
                    }
                }
            }
        }
        private int DabutPieteikumaID(string IzveletaVertiba)
        {
            int startIndex = IzveletaVertiba.LastIndexOf(":") + 1; 
            string appointmentIDString = IzveletaVertiba.Substring(startIndex).Trim(); 
            int appointmentID;

            if (int.TryParse(appointmentIDString, out appointmentID))
            {
                return appointmentID;
            }
            else
            { 
                MessageBox.Show("Kļūda.");
                return -1; 
            }
        }
    }

}
