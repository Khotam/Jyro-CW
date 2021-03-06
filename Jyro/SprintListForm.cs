﻿using Jyro.DAL;
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
    public partial class SprintListForm : Form
    {
        public SprintListForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dgvSprint.DataMember = "";
            dgvSprint.DataSource = null;
            dgvSprint.DataSource = new SprintList().GetAllSprints();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            new SprintEditForm().CreateNewSprint();
            LoadData();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SprintListForm_Load_1(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            new SprintEditForm().CreateNewSprint();
        }
    }
}