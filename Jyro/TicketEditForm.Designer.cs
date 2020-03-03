namespace Jyro
{
    partial class TicketEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblEstimation = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSprintID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxSummary = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.cbxEstimation = new System.Windows.Forms.ComboBox();
            this.cbxPriority = new System.Windows.Forms.ComboBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.cbxSprintID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(57, 31);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(50, 13);
            this.lblSummary.TabIndex = 0;
            this.lblSummary.Text = "Summary";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(57, 69);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblEstimation
            // 
            this.lblEstimation.AutoSize = true;
            this.lblEstimation.Location = new System.Drawing.Point(57, 100);
            this.lblEstimation.Name = "lblEstimation";
            this.lblEstimation.Size = new System.Drawing.Size(55, 13);
            this.lblEstimation.TabIndex = 4;
            this.lblEstimation.Text = "Estimation";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(57, 133);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(38, 13);
            this.lblPriority.TabIndex = 6;
            this.lblPriority.Text = "Priority";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(57, 169);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // lblSprintID
            // 
            this.lblSprintID.AutoSize = true;
            this.lblSprintID.Location = new System.Drawing.Point(57, 201);
            this.lblSprintID.Name = "lblSprintID";
            this.lblSprintID.Size = new System.Drawing.Size(48, 13);
            this.lblSprintID.TabIndex = 10;
            this.lblSprintID.Text = "Sprint ID";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(60, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(193, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbxSummary
            // 
            this.tbxSummary.Location = new System.Drawing.Point(193, 28);
            this.tbxSummary.Name = "tbxSummary";
            this.tbxSummary.Size = new System.Drawing.Size(121, 20);
            this.tbxSummary.TabIndex = 1;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(193, 62);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(121, 20);
            this.tbxDescription.TabIndex = 3;
            // 
            // cbxEstimation
            // 
            this.cbxEstimation.FormattingEnabled = true;
            this.cbxEstimation.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbxEstimation.Location = new System.Drawing.Point(193, 92);
            this.cbxEstimation.Name = "cbxEstimation";
            this.cbxEstimation.Size = new System.Drawing.Size(121, 21);
            this.cbxEstimation.TabIndex = 5;
            // 
            // cbxPriority
            // 
            this.cbxPriority.FormattingEnabled = true;
            this.cbxPriority.Items.AddRange(new object[] {
            "Showstopper",
            "High",
            "Normal",
            "Low"});
            this.cbxPriority.Location = new System.Drawing.Point(193, 125);
            this.cbxPriority.Name = "cbxPriority";
            this.cbxPriority.Size = new System.Drawing.Size(121, 21);
            this.cbxPriority.TabIndex = 7;
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Backlog",
            "Planned",
            "Done"});
            this.cbxStatus.Location = new System.Drawing.Point(193, 161);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxStatus.TabIndex = 9;
            // 
            // cbxSprintID
            // 
            this.cbxSprintID.FormattingEnabled = true;
            this.cbxSprintID.Location = new System.Drawing.Point(193, 201);
            this.cbxSprintID.Name = "cbxSprintID";
            this.cbxSprintID.Size = new System.Drawing.Size(121, 21);
            this.cbxSprintID.TabIndex = 11;
            // 
            // TicketEditForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxSprintID);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.cbxPriority);
            this.Controls.Add(this.cbxEstimation);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxSummary);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSprintID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblEstimation);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSummary);
            this.Name = "TicketEditForm";
            this.Text = "TicketEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblEstimation;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSprintID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxSummary;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.ComboBox cbxEstimation;
        private System.Windows.Forms.ComboBox cbxPriority;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.ComboBox cbxSprintID;
    }
}