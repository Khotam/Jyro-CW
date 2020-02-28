using Jyro.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jyro
{
    public partial class TicketListForm : Form
    {
        public TicketListForm()
        {
            InitializeComponent();
        }

        private void TicketListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        public void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new TicketList().GetAllTickets();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbxSort.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to sort by");
            else
            {
                ByAttribute selectedAttribute;
                if (cbxSort.SelectedIndex == 0)
                    selectedAttribute = ByAttribute.Priority;
                else
                    selectedAttribute = ByAttribute.Status;

                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new TicketList().Sort(selectedAttribute);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            

        }
    }
       
}
