using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DB_Copycenter.Forms
{
    public partial class ClientForm : Form
    {
        private User client;
        private Service service;

        private int _clientSelfCash;

        private string _login;
        private string _clientFIO;
        private string ServiceType;

        private List<Service> services;
        

        public ClientForm(User client_)
        {
            InitializeComponent();

            client = client_;
            FioLabel.Text = client_.Fio;
            SelfCashLabel.Text = Convert.ToString(client_.SelfCash + "$");

            services = new List<Service>
            {
                new Service{ ServiceId = 1, ServiceName = "Обратка фотографий", ServiceCost = 10},
                new Service{ ServiceId = 2, ServiceName = "Печать фотографий", ServiceCost = 7},
                new Service{ ServiceId = 3, ServiceName = "Ксерокопия", ServiceCost = 1},
                new Service{ ServiceId = 4, ServiceName = "Сканирование", ServiceCost = 2},
                new Service{ ServiceId = 5, ServiceName = "Распечатка ч/б", ServiceCost = 1},
                new Service{ ServiceId = 6, ServiceName = "Распечатка цветная", ServiceCost = 5}
            };

            ServiceComboBox.DataSource = services;
            ServiceComboBox.DisplayMember = "ServiceName";
            ServiceComboBox.ValueMember = "ServiceId";

            ServiceComboBox.SelectedIndexChanged += serviceComboBox_SelectedIndexChanged;
            AddServiceButton.MouseClick += AddServiceButton_Click;
            AddServiceButton.MouseClick -= AddServiceButton_Click;

            //var reader = DBHandler.GetDatabase().SelectFromServiceTable(service.ServiceName);
            //reader.Read();
        }

        private void serviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            service = (Service)ServiceComboBox.SelectedItem;
            ServicePriceLabel.Text = Convert.ToString(service.ServiceCost + " $");
        }

        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow.CreateCells(DataGridView1);

            dataGridViewRow.Cells[0].Value = service.ServiceName;
            dataGridViewRow.Cells[1].Value = service.ServiceCost;

            DataGridView1.Rows.Add(dataGridViewRow);
        }

        private void RemoveServiceButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.DataGridView1.SelectedRows)
            {
                try
                {
                    DataGridView1.Rows.RemoveAt(item.Index);
                }
                catch
                {
                    MessageBox.Show("Невозможно удалить пустую строку");
                }
            }
        }

        private void GetServiceButton_Click(object sender, EventArgs e)
        {

        }
    }
}
