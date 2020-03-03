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
    public partial class SprintEditForm : Form
    {
        public SprintEditForm()
        {
            InitializeComponent();
        }

    public Sprint Sprint { get; set; }

    public FormMode Mode { get; set; }

    public void CreateNewSprint()
    {
        Mode = FormMode.Create;
        Sprint = new Sprint();
        InitializeControls();
        MdiParent = MyForms.GetForm<ParentForm>();
        Show();
    }

    public void UpdateSprint(Sprint sprint)
    {
        Mode = FormMode.Update;
        Sprint = sprint;
        InitializeControls();
        ShowSprintInControls();
        MdiParent = MyForms.GetForm<ParentForm>();
        Show();
    }

    private void InitializeControls()
    {
    }

    private void ShowSprintInControls()
    {
            tbxName.Text = Sprint.Name;
            dtpDate.Value = Sprint.Date;
            nudNumber.Value = Sprint.NumberOfDevelopers;
            cbxStatus.SelectedItem = Sprint.Status;
    }

    private void GrabUserInput()
    {
            Sprint.Name = tbxName.Text;
            Sprint.Date = dtpDate.Value;
            Sprint.NumberOfDevelopers = (int)nudNumber.Value;
            Sprint.Status = (string)cbxStatus.SelectedItem;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GrabUserInput();
                var manager = new SprintManager();
                if (Mode == FormMode.Create)
                    manager.Create(Sprint);
                else
                    manager.Update(Sprint);

                MyForms.GetForm<SprintListForm>().LoadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
