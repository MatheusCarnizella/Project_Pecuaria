using Newtonsoft.Json;
using Pecuaria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pecuaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };

            string URI = Services.Services.API_URL + Services.Services.PECUARISTA_GETAll_Route;
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        datagrid_pecuaristas.DataSource = JsonConvert.DeserializeObject<Pecuarista[]>(json).ToList();
                    }
                    else
                    {
                        MessageBox.Show($"Não foi possivel fazer a requisição de obter todos pecuaristas!" +
                            "\nErro: " + response.StatusCode);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread T = new Thread(() => Application.Run(new Form2()));
            T.Start();
        }

        private void btnCadastrarP_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread T = new Thread(() => Application.Run(new Form4()));
            T.Start();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var dt = GerarDadosRelatorio();
            using(var frm = new Form5(dt))
            {
                frm.ShowDialog();
            }
        }

        private DataTable GerarDadosRelatorio()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Pecuarista");
            dt.Columns.Add("Data Entrega");
            dt.Columns.Add("Preco", typeof(decimal));

            foreach (DataGridViewRow item in datagrid_pecuaristas.Rows)
            {
                dt.Rows.Add(item.Cells["Id"].Value.ToString());
            }
            return dt;
        }   

    }
}
