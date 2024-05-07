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
    public partial class Pasutit_preci : Form
    {
        Dictionary<string, int> Produktu_saraksts = new Dictionary<string, int>();
        public Pasutit_preci()
        {
            InitializeComponent();
        }

        private void Pasutit_preci_Load(object sender, EventArgs e)
        {
            PiepilditVardnicu();
            FillCheckedListBox();
        }


        public void PiepilditVardnicu()
        {

            string query = "SELECT Nosaukums, Cena FROM Produkts";


            using (SQLiteConnection connection = Registresanas_dati.Konekcija())
            {
                try
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                string Nosaukums = reader["Nosaukums"].ToString();
                                int Cena = Convert.ToInt32(reader["Cena"]);

                                Produktu_saraksts.Add(Nosaukums, Cena);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void FillCheckedListBox()
        {
            Produkti.Items.Clear();

            foreach (var Nosaukums in Produktu_saraksts.Keys)
            {
                Produkti.Items.Add(Nosaukums);
            }
        }

        private void Produkti_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int Summa = AprekinatSummu();

            if (e.NewValue == CheckState.Checked)
            {
                string Produkta_nosaukums = Produkti.Items[e.Index].ToString();
                int Cena = Produktu_saraksts[Produkta_nosaukums];
                Summa += Cena;
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                string Produkta_nosaukums = Produkti.Items[e.Index].ToString();
                int Cena = Produktu_saraksts[Produkta_nosaukums];
                Summa -= Cena;
            }

            Cena.Text = Summa.ToString();
        }

        private int AprekinatSummu()
        {
            int Summa = 0;

           
            foreach (var Produkts in Produkti.CheckedItems)
            { 
                if (Produktu_saraksts.ContainsKey(Produkts.ToString()))
                {
                    Summa += Produktu_saraksts[Produkts.ToString()];
                }
                else
                {
                    MessageBox.Show($"Kļūda");
                }
            }

            return Summa;
        }

        private void Pasutit_produktu_Click(object sender, EventArgs e)
        {

        }
    }
}

 
