using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HmDays
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hmDDataSet.tblProject". При необходимости она может быть перемещена или удалена.
            this.tblProjectTableAdapter.Fill(this.hmDDataSet.tblProject);
            /*    // TODO: данная строка кода позволяет загрузить данные в таблицу "hmDDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
                this.dataTable1TableAdapter.Fill(this.hmDDataSet.DataTable1);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "hmDDataSet1.projects". При необходимости она может быть перемещена или удалена.
                this.projectsTableAdapter.Fill(this.hmDDataSet1.projects);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "hmDDataSet.projects". При необходимости она может быть перемещена или удалена.
                this.projectsTableAdapter.Fill(this.hmDDataSet.projects);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "hmDDataSet.events". При необходимости она может быть перемещена или удалена.
                this.eventsTableAdapter.Fill(this.hmDDataSet.events);*/

        }

        private void tblPrj_Projects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
