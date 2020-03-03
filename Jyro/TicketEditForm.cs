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
    public partial class TicketEditForm : Form
    {
        public TicketEditForm()
        {
            InitializeComponent();
        }

        public Ticket Ticket { get; set; }

        public FormMode Mode { get; set; }

        public void CreateNewTicket()
        {
            Mode = FormMode.Create;
            Ticket = new Ticket();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateTicket(Ticket ticket)
        {
            Mode = FormMode.Update;
            Ticket = ticket;
            InitializeControls();
            ShowTicketInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void InitializeControls()
        {
            cbxSprintID.DataSource = new SprintManager().GetAll();
        }

        private void ShowTicketInControls()
        {
            tbxSummary.Text = Ticket.Summary;
            tbxDescription.Text = Ticket.Description;
            cbxEstimation.SelectedItem = Ticket.Estimation;
            cbxPriority.SelectedItem = Ticket.Priority;
            cbxStatus.SelectedItem = Ticket.Status;
            cbxSprintID.SelectedItem = Ticket.SprintId;
        }

        private void GrabUserInput()
        {
             Ticket.Summary = tbxSummary.Text;
             Ticket.Description = tbxDescription.Text;
             Ticket.Estimation = (int)cbxEstimation.SelectedItem;
             Ticket.Priority = (string)cbxPriority.SelectedItem;
             Ticket.Status = (string)cbxStatus.SelectedItem;
             Ticket.SprintId = (Sprint)cbxSprintID.SelectedItem;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
