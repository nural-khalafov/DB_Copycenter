using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Copycenter.Forms
{
    public partial class OrderForm : Form
    {
        private readonly WorkerForm _workerForm;
        private readonly Worker _worker;
        private Service _service;

        private int _paymentId;
        private int _selectedId;
        private int _selectedServiceId;

        private List<Service> services;

        public OrderForm()
        {
            InitializeComponent();

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

            ServiceComboBox.SelectedIndexChanged += ServiceComboBox_SelectedIndexChanged;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            _workerForm.Show();
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            DBHandler.GetDatabase().UpdatePaymentStatusToDone(DateTime.Today, _selectedId);
        }

        /// <summary>
        /// Client DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string? selectedId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                _selectedId = Convert.ToInt32(selectedId);
            }
            else
            {
                MessageBox.Show("Невозможно выбрать пустую услугу!");
            }
        }

        private void ServiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _service = (Service)ServiceComboBox.SelectedItem;
            ServicePriceLabel.Text = Convert.ToString(_service.ServiceCost + "$");
        }

        private void NotClientButton_Click(object sender, EventArgs e)
        {
            if (ServiceComboBox.SelectedItem != null && _service != null)
            {
                DBHandler.GetDatabase().InsertPaymentData();
                var reader = DBHandler.GetDatabase().SelectPaymentFromPaymentTable();
                reader.Read();
                _paymentId = reader.GetInt32(0);
                reader.Close();
                DBHandler.GetDatabase().InsertServicesInPaymentData(_paymentId, _service.ServiceId);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите услугу!");
            }
        }

        private void NotClientConfirmButton_Click(object sender, EventArgs e)
        {
            DBHandler.GetDatabase().UpdatePaymentStatusToDone(DateTime.Today, _selectedId);
            MessageBox.Show("Заказ принят!");
        }

        /// <summary>
        /// Non Client DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string? selectedId = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                _selectedId = Convert.ToInt32(selectedId);
            }
            else
            {
                MessageBox.Show("Невозможно выбрать пустую услугу!");
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            var reader = DBHandler.GetDatabase().SelectInProcessPaymentDataFromPaymentTable();
            reader.Read();

            var count = 0;

            while (reader.IsOnRow)
            {
                if (dataGridView1.Rows.Count <= count)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.CreateCells(dataGridView1);
                    dataGridViewRow.Cells[0].Value = reader.GetInt32(0);
                    dataGridViewRow.Cells[1].Value = reader.GetString(1);
                    dataGridViewRow.Cells[2].Value = reader.GetString(2);
                    dataGridViewRow.Cells[3].Value = reader.GetInt32(3);
                    dataGridViewRow.Cells[4].Value = reader.GetString(4);

                    dataGridView1.Rows.Add(dataGridViewRow);
                }
                else
                {
                    dataGridView1.Rows[count].Cells[0].Value = reader.GetInt32(0);
                    dataGridView1.Rows[count].Cells[1].Value = reader.GetString(1);
                    dataGridView1.Rows[count].Cells[2].Value = reader.GetString(2);
                    dataGridView1.Rows[count].Cells[3].Value = reader.GetInt32(3);
                    dataGridView1.Rows[count].Cells[4].Value = reader.GetString(4);
                }
                count++;
                reader.Read();
            }
            reader.Close();
        }

        private void RefreshButton1_Click(object sender, EventArgs e)
        {
            var reader = DBHandler.GetDatabase().SelectInProcessNonClientPaymentDataFromPaymentTable();
            reader.Read();

            var count = 0;

            while (reader.IsOnRow)
            {
                if (dataGridView2.Rows.Count <= count)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.CreateCells(dataGridView2);
                    dataGridViewRow.Cells[0].Value = reader.GetInt32(0);
                    dataGridViewRow.Cells[1].Value = reader.GetString(1);
                    dataGridViewRow.Cells[2].Value = reader.GetInt32(2);
                    dataGridViewRow.Cells[3].Value = reader.GetString(3);

                    dataGridView2.Rows.Add(dataGridViewRow);
                }
                else
                {
                    dataGridView2.Rows[count].Cells[0].Value = reader.GetInt32(0);
                    dataGridView2.Rows[count].Cells[1].Value = reader.GetString(1);
                    dataGridView2.Rows[count].Cells[2].Value = reader.GetInt32(2);
                    dataGridView2.Rows[count].Cells[3].Value = reader.GetString(3);
                }
                count++;
                reader.Read();
            }
            reader.Close();
        }
    }
}
