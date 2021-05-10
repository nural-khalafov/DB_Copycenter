using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DB_Copycenter.Forms
{
    public partial class AdminForm : Form
    {
        private Worker _admin;

        private int _selectedInvID;
        private int _selectedClientID;

        private string _enteredInvName;
        private string _enteredPosition;

        private int _enteredInvQuantity;
        private int _enteredInvCost;
        private int _enteredSalary;
        private int _enteredWorkExp;


        public AdminForm(Worker admin)
        {
            InitializeComponent();

            _admin = admin;

            FioLabel.Text = admin.Fio;
            PositionLabel.Text = admin.Position;
            SalaryLabel.Text = Convert.ToString(admin.Salary + "$");
            WorkExperienceLabel.Text = Convert.ToString(admin.WorkExperience + " год");

        }


        private void RefreshInventoryButton_Click(object sender, EventArgs e)
        {
            var reader = DBHandler.GetDatabase().SelectInventoryDataFromInventoryTable();
            reader.Read();

            var count = 0;

            while (reader.IsOnRow)
            {
                if (dataGridView.Rows.Count <= count)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.CreateCells(dataGridView);

                    dataGridViewRow.Cells[0].Value = reader.GetInt32(0);
                    dataGridViewRow.Cells[1].Value = reader.GetString(1);
                    dataGridViewRow.Cells[2].Value = reader.GetInt32(2);
                    dataGridViewRow.Cells[3].Value = reader.GetInt32(3);

                    dataGridView.Rows.Add(dataGridViewRow);
                }
                else
                {
                    dataGridView.Rows[count].Cells[0].Value = reader.GetInt32(0);
                    dataGridView.Rows[count].Cells[1].Value = reader.GetString(1);
                    dataGridView.Rows[count].Cells[2].Value = reader.GetInt32(2);
                    dataGridView.Rows[count].Cells[3].Value = reader.GetInt32(3);
                }

                count++;

                reader.Read();
            }
            reader.Close();
        }


        /// <summary>
        /// Inventory DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                _selectedInvID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value);
                _enteredInvName = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                _enteredInvQuantity = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[2].Value);
                _enteredInvCost = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[3].Value);

                MessageBox.Show($"{_selectedInvID} {_enteredInvName} {_enteredInvQuantity} {_enteredInvCost}");
            }
        }

        private void AddInventoryButton_Click(object sender, EventArgs e)
        {
            DBHandler.GetDatabase().InsertInventoryData(_enteredInvName, _enteredInvQuantity, _enteredInvCost);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            var reader = DBHandler.GetDatabase().SelectAllDataFromUserTable();
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
                    dataGridViewRow.Cells[2].Value = reader.IsDBNull(2)? "Клиент" : reader.GetString(2);
                    dataGridViewRow.Cells[3].Value = reader.IsDBNull(3)? 0 : reader.GetInt32(3);
                    dataGridViewRow.Cells[4].Value = reader.IsDBNull(4)? 0 : reader.GetInt32(4);

                    dataGridView1.Rows.Add(dataGridViewRow);
                }
                else
                {
                    dataGridView1.Rows[count].Cells[0].Value = reader.GetInt32(0);
                    dataGridView1.Rows[count].Cells[1].Value = reader.GetString(1);
                    dataGridView1.Rows[count].Cells[2].Value = reader.IsDBNull(2) ? "Клиент" : reader.GetString(2);
                    dataGridView1.Rows[count].Cells[3].Value = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                    dataGridView1.Rows[count].Cells[4].Value = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);
                }

                count++;

                reader.Read();
            }
            reader.Close();
        }

        /// <summary>
        /// Worker DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                _selectedClientID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                _enteredPosition = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                _enteredWorkExp = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                _enteredSalary = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);

                MessageBox.Show($"{_selectedClientID} {_enteredPosition} {_enteredWorkExp} {_enteredSalary}");
            }
        }

        private void AddWorkerButton_Click(object sender, EventArgs e)
        {
            DBHandler.GetDatabase().InsertPositionData(_selectedClientID, _enteredPosition, _enteredSalary);
            DBHandler.GetDatabase().InsertWorkerData(_selectedClientID, _selectedClientID, _selectedClientID);
        }

        private void UpdateWorkerButton_Click(object sender, EventArgs e)
        {
            DBHandler.GetDatabase().UpdateWorkerData(_enteredWorkExp, _selectedClientID, _selectedClientID);
            DBHandler.GetDatabase().UpdateWorkerPositionData(_enteredPosition, _enteredSalary, _selectedClientID);
        }

        private void DeleteWorkerButton_Click(object sender, EventArgs e)
        {
            DBHandler.GetDatabase().DeleteWorkerData(_selectedClientID);
            DBHandler.GetDatabase().DeleteWorkerPositionData(_selectedClientID);
        }

        private void UpdateInventoryButton_Click(object sender, EventArgs e)
        {
            DBHandler.GetDatabase().UpdateInventoryData(_enteredInvQuantity, _enteredInvName, _enteredInvCost);
        }

        private void DeleteInventoryButton_Click(object sender, EventArgs e)
        {
            DBHandler.GetDatabase().DeleteInventoryData(_selectedInvID);
        }
    }
}
