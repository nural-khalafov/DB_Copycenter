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
        private List<Worker> _workers;

        private string _fio;
        private string _position;

        private int _salary;
        private int _workExperience;

        public AdminForm(Worker admin)
        {
            InitializeComponent();

            _admin = admin;

            FioLabel.Text = admin.Fio;
            PositionLabel.Text = admin.Position;
            SalaryLabel.Text = Convert.ToString(admin.Salary + "$");
            WorkExperienceLabel.Text = Convert.ToString(admin.WorkExperience + " год");

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            var reader = DBHandler.GetDatabase().SelectClientFioFromClientTable();
            reader.Read();

            int count = 0;

            while (reader.IsOnRow)
            {
                if (dataGridView1.Rows.Count <= count)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.CreateCells(dataGridView1);

                    dataGridViewRow.Cells[0].Value = reader.GetString(0);

                    dataGridView1.Rows.Add(dataGridViewRow);
                }
                else
                {
                    dataGridView1.Rows[count].Cells[0].Value = reader.GetString(0);
                }

                count++;

                reader.Read();
            }

            reader.Close();

        }
    }
}
