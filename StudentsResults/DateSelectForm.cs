using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsResults
{
    public partial class DateSelectForm : Form
    {
        string Datedate = "";
        public DateSelectForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            RB_Form MF = (RB_Form)this.Owner;
            MF.SelectedName = Datedate;

            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Datedate = e.Start.ToShortDateString();
        }
    }
}
