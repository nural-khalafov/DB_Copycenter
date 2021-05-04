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
    public partial class AdminForm : Form
    {
        private Worker _admin;
        public AdminForm(Worker admin)
        {
            InitializeComponent();

            _admin = admin;
        }
    }
}
