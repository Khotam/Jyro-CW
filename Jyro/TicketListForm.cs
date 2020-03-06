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
            if (cbxSearch.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to search by");
            else if (nudSearch.Value <= 0)
                MessageBox.Show("Must be a positive number");
            else
            {
                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new TicketList().Search((int)nudSearch.Value);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new TicketEditForm().CreateNewTicket();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select a ticket");
            else
            {
                var t = (Ticket)dgv.SelectedRows[0].DataBoundItem;
                new TicketEditForm().UpdateTicket(t);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select a ticket");
            else
            {
                var t = (Ticket)dgv.SelectedRows[0].DataBoundItem;
                new TicketManager().Delete(t.Id);
                LoadData();
            }
        }
    }
       
}
