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
using MySql.Data.MySqlClient;

namespace Projekta_darbs_Rihards_frizetava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public bool Ievades_parbaude()
        {
            if (String.IsNullOrEmpty(Vards_text.Text))
            {
                MessageBox.Show("Ievadiet savu vardu!");
                return false;
            }
            else if (String.IsNullOrEmpty(Uzvards_text.Text))
            {
                MessageBox.Show("Ievadiet savu uzvardu!");
                return false;
            }
            else if (String.IsNullOrEmpty(Tel_numurs_text.Text))
            {
                MessageBox.Show("Ievadiet savu telefona numuru!");
                return false;
            }
            else if (Izvele_list.SelectedIndex == -1)
            {
                MessageBox.Show("Izvelaties kadu no proceduram!");
                return false;
            }
            else
            {
                return true;
            }
        }


        public void SQL()
        {
            string ConnectString = "datasource =127.0.0.1 ; username = root ; password = ; database = frizetava_rihards";
            MySqlConnection DBconnect = new MySqlConnection(ConnectString);

            DBconnect.Open();

            string Query1 = "INSERT INTO klients (Klienta_ID, Vards, Uzvards, Telefona_numurs) VALUES ('" + "NULL" + "','" + this.Vards_text.Text + "','" + this.Uzvards_text.Text + "','" + this.Tel_numurs_text.Text + "')";
            MySqlCommand cmd1 = new MySqlCommand(Query1, DBconnect);

            int i = cmd1.ExecuteNonQuery();

            if (i != 0)
            {
                MessageBox.Show("Jus esat pierakstijusies!");
            }
            else
            {
                MessageBox.Show("oops, kaut kas nogaja greizi!");
            }

            DBconnect.Close();

        }

        public void frizetavas_saraksts()
        {
            string ConnectString = "datasource =127.0.0.1 ; username = root ; password = ; database = frizetava_rihards";
            MySqlConnection DBconnect = new MySqlConnection(ConnectString);
            DBconnect.Open();

            string query = "SELECT * FROM frizetava";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, DBconnect);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            DBconnect.Close();

        }

        private void Pierakstisanas_poga_Click(object sender, EventArgs e)
        {
         
           if (Ievades_parbaude() == true)
            {
                SQL();
            }
            else
            {

            }
        }

        private void Saraksta_poga_Click(object sender, EventArgs e)
        {
            frizetavas_saraksts();
        }
    }
}
