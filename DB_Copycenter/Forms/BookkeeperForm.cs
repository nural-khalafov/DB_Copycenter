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
        public BookkeeperForm(Worker bookkeper)
        {
            InitializeComponent();

            _bookkeeper = bookkeper;

            FioLabel.Text = bookkeper.Fio;
            PositionLabel.Text = bookkeper.Position;
            SalaryLabel.Text = Convert.ToString(bookkeper.Salary + "$");
            WorkExperienceLabel.Text = Convert.ToString(bookkeper.WorkExperience + " год");
        }
    }
}
