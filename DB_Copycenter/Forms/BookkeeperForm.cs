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
    public partial class BookkeeperForm : Form
    {
        private Worker _bookkeeper;

        private int _quantity, _costPerUnit, _sum;
        private int _paymentSum;

        private string _enteredDescription;

        public BookkeeperForm(Worker bookkeper)
        {
            InitializeComponent();

            _bookkeeper = bookkeper;

            FioLabel.Text = bookkeper.Fio;
            PositionLabel.Text = bookkeper.Position;
            SalaryLabel.Text = Convert.ToString(bookkeper.Salary + "$");
            WorkExperienceLabel.Text = Convert.ToString(bookkeper.WorkExperience + " год");
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                _enteredDescription = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                MessageBox.Show($"{_enteredDescription}");
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            var reader = DBHandler.GetDatabase().SelectFromReportTable();
            reader.Read();

            var count = 0;

            while (reader.IsOnRow)
            {
                if (dataGridView.Rows.Count <= count)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.CreateCells(dataGridView);

                    dataGridViewRow.Cells[0].Value = reader.GetString(0);
                    dataGridViewRow.Cells[1].Value = reader.GetDate(1);
                    dataGridViewRow.Cells[2].Value = reader.GetInt32(2);
                    dataGridViewRow.Cells[3].Value = reader.GetInt32(3);

                    dataGridView.Rows.Add(dataGridViewRow);
                }
                else
                {
                    dataGridView.Rows[count].Cells[0].Value = reader.GetString(0);
                    dataGridView.Rows[count].Cells[1].Value = reader.GetDate(1);
                    dataGridView.Rows[count].Cells[2].Value = reader.GetInt32(2);
                    dataGridView.Rows[count].Cells[3].Value = reader.GetInt32(3);
                }

                count++;
                reader.Read();
            }
            reader.Close();
        }

        private void SendReportButton_Click(object sender, EventArgs e)
        {
            DBHandler.GetDatabase().InsertReportData(_paymentSum, _enteredDescription, _sum);
        }

        private void IncomeLabel_Click(object sender, EventArgs e)
        {
            var reader = DBHandler.GetDatabase().SelectDonePaymentFromPaymentTable();
            reader.Read();

            var count = 0;

            while (reader.IsOnRow)
            {
                _paymentSum += reader.GetInt32(0);

                count++;

                reader.Read();
            }
            reader.Close();

            IncomeLabel.Text = Convert.ToString(_paymentSum + "$");

        }

        private void CostsLabel_Click(object sender, EventArgs e)
        {
            var reader = DBHandler.GetDatabase().SelectInventoryDataFromInventoryTable();
            reader.Read();

            var count = 0;

            while (reader.IsOnRow)
            {
                _quantity = reader.GetInt32(2);
                _costPerUnit = reader.GetInt32(3);

                _sum += _quantity * _costPerUnit;

                count++;

                reader.Read();
            }
            reader.Close();

            CostsLabel.Text = Convert.ToString(_sum + "$");
        }
    }
}
