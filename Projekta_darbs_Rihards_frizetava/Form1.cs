using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SQLite;
using System.Net.Http;
using Newtonsoft.Json;

namespace Projekta_darbs_Rihards_frizetava
{
    public partial class Form1 : Form
    {
        private readonly HttpClient client;
        private readonly Timer timer;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            timer = new Timer();
            timer.Interval = 1000; // Intervals 1 sekunde (1000 milisekundes)
            timer.Tick += Timer_Tick;
            timer.Start();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private async void Timer_Tick(object sender, EventArgs e)
        {
            await laikanolase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void loadform(object Form)
        {
            if (this.Galvenais_panelis.Controls.Count > 0)
                this.Galvenais_panelis.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Galvenais_panelis.Controls.Add(f);
            this.Galvenais_panelis.Tag = f;
            f.Show();
        }


        private void Pieteikumi_Pasutijumi_Click(object sender, EventArgs e)
        {
            loadform(new Mani_pasutijumi_pieteikumi());
        }

        private void Pieteikties_Click(object sender, EventArgs e)
        {
            loadform(new Pieteikties());
        }

        private void Pasutit_preci_Click(object sender, EventArgs e)
        {
            loadform(new Pasutit_preci());
        }

        private void Aizversanas_poga_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Galvenais_ekrans_Click(object sender, EventArgs e)
        {
            loadform(new Galvenais_ekrans());
        }

        private async Task laikanolase()
        {
            //izlasa no API laiku un izvada to uz saskarnes
            try
            {
                string apiUrl = "https://timeapi.io/api/Time/current/zone?timeZone=Europe/Riga";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                dynamic jsonObject = JsonConvert.DeserializeObject(responseBody);
                string time = jsonObject.time;
                label1.Text = time;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"API request failed: {ex.Message}");
            }
        }

    }


}


