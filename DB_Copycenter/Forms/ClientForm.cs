using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DB_Copycenter.Forms
{
    public partial class ClientForm : Form
    {
        private readonly User _client;
        private Service _service;

        private int _selectedId;
        private int _selectedCost;
        private int _paymentId;

        private List<Service> services;


        public ClientForm(User client)
        {
            InitializeComponent();

            _client = client;
            FioLabel.Text = client.Fio;
            SelfCashLabel.Text = Convert.ToString(client.SelfCash + "$");

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
            _service = (Service)ServiceComboBox.SelectedItem;
            ServicePriceLabel.Text = Convert.ToString(_service.ServiceCost + "$");
        }

        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            if (ServiceComboBox.SelectedItem != null && _service != null)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();

                dataGridViewRow.CreateCells(DataGridView1);

                dataGridViewRow.Cells[0].Value = _service.ServiceId;
                dataGridViewRow.Cells[1].Value = _service.ServiceName;
                dataGridViewRow.Cells[2].Value = _service.ServiceCost;

                DataGridView1.Rows.Add(dataGridViewRow);
            }
            else
            {
                MessageBox.Show("Невозможно выбрать пустую услугу!");
            }
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
                    MessageBox.Show("Невозможно удалить пустую услугу!");
                }
            }
        }

        private void GetServiceButton_Click(object sender, EventArgs e)
        {
            DBHandler.GetDatabase().InsertPaymentData(_client);
            var reader = DBHandler.GetDatabase().SelectPaymentFromPaymentTable();
            reader.Read();
            _paymentId = reader.GetInt32(0);
            reader.Close();
            DBHandler.GetDatabase().InsertServicesInPaymentData(_paymentId, _selectedId);
            DBHandler.GetDatabase().UpdateClientCashData(_selectedCost, _client.Id);
            MessageBox.Show($"Ваш номер заказа: {_paymentId}. Ваше время оплаты: " + Time.PaymentTime.ToString("g"));
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string? selectedId = DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string selectedCost = DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                _selectedCost = Convert.ToInt32(selectedCost);
                _selectedId = Convert.ToInt32(selectedId);
            }
            else
            {
                MessageBox.Show("Невозможно выбрать пустую услугу!");
            }

        }

        private void SelfCashLabel_Click(object sender, EventArgs e)
        {
            var reader = DBHandler.GetDatabase().SelectClientDataFromUserTable(_client.Id);
            reader.Read();
            _client.SelfCash = reader.GetInt32(1);
            reader.Close();

            SelfCashLabel.Text = Convert.ToString(_client.SelfCash + " $");

            MessageBox.Show("Updated cash");
        } 
    }
}
