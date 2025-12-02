namespace UserInterFacelayer
{
    partial class frmManagePeople
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvManagePeople = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThirdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contmList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combFilterBy = new System.Windows.Forms.ComboBox();
            this.txtbSearchBy = new System.Windows.Forms.TextBox();
            this.lbRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagePeople)).BeginInit();
            this.contmList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManagePeople
            // 
            this.dgvManagePeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvManagePeople.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvManagePeople.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvManagePeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvManagePeople.ColumnHeadersHeight = 34;
            this.dgvManagePeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.CNationalNo,
            this.cFirstName,
            this.cSecondName,
            this.cThirdName,
            this.cLastName,
            this.cGender,
            this.cDateOfBirth,
            this.cNationality,
            this.cPhone,
            this.cEmail});
            this.dgvManagePeople.ContextMenuStrip = this.contmList;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManagePeople.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManagePeople.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvManagePeople.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvManagePeople.Location = new System.Drawing.Point(1, 269);
            this.dgvManagePeople.Name = "dgvManagePeople";
            this.dgvManagePeople.RowHeadersWidth = 62;
            this.dgvManagePeople.RowTemplate.Height = 28;
            this.dgvManagePeople.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvManagePeople.Size = new System.Drawing.Size(1349, 276);
            this.dgvManagePeople.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Peson ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 111;
            // 
            // CNationalNo
            // 
            this.CNationalNo.HeaderText = "NationalNo";
            this.CNationalNo.MinimumWidth = 8;
            this.CNationalNo.Name = "CNationalNo";
            this.CNationalNo.Width = 123;
            // 
            // cFirstName
            // 
            this.cFirstName.HeaderText = "First Name";
            this.cFirstName.MinimumWidth = 8;
            this.cFirstName.Name = "cFirstName";
            this.cFirstName.Width = 122;
            // 
            // cSecondName
            // 
            this.cSecondName.HeaderText = "Second Name";
            this.cSecondName.MinimumWidth = 8;
            this.cSecondName.Name = "cSecondName";
            this.cSecondName.Width = 146;
            // 
            // cThirdName
            // 
            this.cThirdName.HeaderText = "Third Name";
            this.cThirdName.MinimumWidth = 8;
            this.cThirdName.Name = "cThirdName";
            this.cThirdName.Width = 126;
            // 
            // cLastName
            // 
            this.cLastName.HeaderText = "Last Name";
            this.cLastName.MinimumWidth = 8;
            this.cLastName.Name = "cLastName";
            this.cLastName.Width = 122;
            // 
            // cGender
            // 
            this.cGender.HeaderText = "Gender";
            this.cGender.MinimumWidth = 8;
            this.cGender.Name = "cGender";
            this.cGender.Width = 99;
            // 
            // cDateOfBirth
            // 
            this.cDateOfBirth.HeaderText = "Date Of birth";
            this.cDateOfBirth.MinimumWidth = 8;
            this.cDateOfBirth.Name = "cDateOfBirth";
            this.cDateOfBirth.Width = 136;
            // 
            // cNationality
            // 
            this.cNationality.HeaderText = "Nationality";
            this.cNationality.MinimumWidth = 8;
            this.cNationality.Name = "cNationality";
            this.cNationality.Width = 118;
            // 
            // cPhone
            // 
            this.cPhone.HeaderText = "Phone";
            this.cPhone.MinimumWidth = 8;
            this.cPhone.Name = "cPhone";
            this.cPhone.Width = 91;
            // 
            // cEmail
            // 
            this.cEmail.FillWeight = 200F;
            this.cEmail.HeaderText = "Email";
            this.cEmail.MinimumWidth = 8;
            this.cEmail.Name = "cEmail";
            this.cEmail.Width = 84;
            // 
            // contmList
            // 
            this.contmList.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contmList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetails,
            this.toolStripSeparator1,
            this.tsmAddNewPerson,
            this.tsmEdit,
            this.tsmDelete,
            this.toolStripSeparator2,
            this.tsmSendEmail,
            this.tsmPhoneCall});
            this.contmList.Name = "contShowDetails";
            this.contmList.Size = new System.Drawing.Size(225, 208);
            this.contmList.Text = "Show Details";
            // 
            // tsmShowDetails
            // 
            this.tsmShowDetails.Image = global::Driving_License_management.Properties.Resources.clipboard;
            this.tsmShowDetails.Name = "tsmShowDetails";
            this.tsmShowDetails.Size = new System.Drawing.Size(224, 32);
            this.tsmShowDetails.Text = "Show Details";
            this.tsmShowDetails.Click += new System.EventHandler(this.tsmShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // tsmAddNewPerson
            // 
            this.tsmAddNewPerson.Image = global::Driving_License_management.Properties.Resources.salesman;
            this.tsmAddNewPerson.Name = "tsmAddNewPerson";
            this.tsmAddNewPerson.Size = new System.Drawing.Size(224, 32);
            this.tsmAddNewPerson.Text = "Add New Person";
            this.tsmAddNewPerson.Click += new System.EventHandler(this.tsmAddNewPerson_Click);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Image = global::Driving_License_management.Properties.Resources.edit;
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(224, 32);
            this.tsmEdit.Text = "Edit";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Image = global::Driving_License_management.Properties.Resources.delete_row;
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(224, 32);
            this.tsmDelete.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // tsmSendEmail
            // 
            this.tsmSendEmail.Image = global::Driving_License_management.Properties.Resources.email;
            this.tsmSendEmail.Name = "tsmSendEmail";
            this.tsmSendEmail.Size = new System.Drawing.Size(224, 32);
            this.tsmSendEmail.Text = "Send Email";
            // 
            // tsmPhoneCall
            // 
            this.tsmPhoneCall.Image = global::Driving_License_management.Properties.Resources.phone;
            this.tsmPhoneCall.Name = "tsmPhoneCall";
            this.tsmPhoneCall.Size = new System.Drawing.Size(224, 32);
            this.tsmPhoneCall.Text = "Phone Call";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(589, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage People";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter By:";
            // 
            // combFilterBy
            // 
            this.combFilterBy.FormattingEnabled = true;
            this.combFilterBy.Location = new System.Drawing.Point(99, 220);
            this.combFilterBy.Name = "combFilterBy";
            this.combFilterBy.Size = new System.Drawing.Size(200, 28);
            this.combFilterBy.TabIndex = 4;
            // 
            // txtbSearchBy
            // 
            this.txtbSearchBy.Location = new System.Drawing.Point(324, 220);
            this.txtbSearchBy.Name = "txtbSearchBy";
            this.txtbSearchBy.Size = new System.Drawing.Size(180, 26);
            this.txtbSearchBy.TabIndex = 5;
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(114, 561);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(39, 20);
            this.lbRecords.TabIndex = 7;
            this.lbRecords.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "# Records:";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackgroundImage = global::Driving_License_management.Properties.Resources.salesman;
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPerson.Location = new System.Drawing.Point(1178, 190);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(94, 58);
            this.btnAddPerson.TabIndex = 8;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Driving_License_management.Properties.Resources.group;
            this.pictureBox1.Location = new System.Drawing.Point(622, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 601);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbSearchBy);
            this.Controls.Add(this.combFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvManagePeople);
            this.Name = "frmManagePeople";
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagePeople)).EndInit();
            this.contmList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManagePeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combFilterBy;
        private System.Windows.Forms.TextBox txtbSearchBy;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThirdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
        private System.Windows.Forms.ContextMenuStrip contmList;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmSendEmail;
        private System.Windows.Forms.ToolStripMenuItem tsmPhoneCall;
    }
}