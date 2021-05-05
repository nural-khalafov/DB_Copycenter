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
    public partial class WorkerForm : Form
    {
        private Worker _worker;

        public WorkerForm(Worker worker)
        {
            InitializeComponent();

            _worker = worker;

            FioLabel.Text = worker.Fio;
            PositionLabel.Text = worker.Position;
            SalaryLabel.Text = Convert.ToString(worker.Salary + "$");
            WorkExperienceLabel.Text = Convert.ToString(worker.WorkExperience + " год");
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            var reader = DBHandler.GetDatabase().SelectClientDataFromUserTable();
            reader.Read();

            int count = 0;

            while (reader.IsOnRow)
            {
                if (dataGridView.Rows.Count <= count)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.CreateCells(dataGridView);
                    dataGridViewRow.Cells[0].Value = reader.GetString(0);
                    dataGridViewRow.Cells[1].Value = reader.GetInt32(1);

                    dataGridView.Rows.Add(dataGridViewRow);
                }
                else
                {
                    dataGridView.Rows[count].Cells[0].Value = reader.GetString(0);
                    dataGridView.Rows[count].Cells[1].Value = reader.GetInt32(1);
                }

                count++;

                reader.Read();
            }

            reader.Close();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderForm();

            orderForm.Show();

        }
    }
}
