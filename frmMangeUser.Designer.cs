namespace Driving_License_management
{
    partial class frmMangeUser
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
            System.Windows.Forms.Label lblRecords;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combFilterBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            lblRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRecords.Location = new System.Drawing.Point(134, 589);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new System.Drawing.Size(60, 25);
            lblRecords.TabIndex = 6;
            lblRecords.Text = "????";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(382, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mange User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter By:";
            // 
            // combFilterBy
            // 
            this.combFilterBy.FormattingEnabled = true;
            this.combFilterBy.Location = new System.Drawing.Point(127, 205);
            this.combFilterBy.Name = "combFilterBy";
            this.combFilterBy.Size = new System.Drawing.Size(188, 28);
            this.combFilterBy.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "# Records:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUserID,
            this.cPersonID,
            this.cFullName,
            this.cUserName,
            this.cIsActive});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(8, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(974, 310);
            this.dataGridView1.TabIndex = 8;
            // 
            // cUserID
            // 
            this.cUserID.HeaderText = "UserID";
            this.cUserID.MinimumWidth = 8;
            this.cUserID.Name = "cUserID";
            this.cUserID.Width = 150;
            // 
            // cPersonID
            // 
            this.cPersonID.HeaderText = "PersonID";
            this.cPersonID.MinimumWidth = 8;
            this.cPersonID.Name = "cPersonID";
            this.cPersonID.Width = 150;
            // 
            // cFullName
            // 
            this.cFullName.HeaderText = "Full Name";
            this.cFullName.MinimumWidth = 300;
            this.cFullName.Name = "cFullName";
            this.cFullName.Width = 300;
            // 
            // cUserName
            // 
            this.cUserName.HeaderText = "User Name";
            this.cUserName.MinimumWidth = 8;
            this.cUserName.Name = "cUserName";
            this.cUserName.Width = 150;
            // 
            // cIsActive
            // 
            this.cIsActive.HeaderText = "Is Active";
            this.cIsActive.MinimumWidth = 8;
            this.cIsActive.Name = "cIsActive";
            this.cIsActive.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetails,
            this.toolStripSeparator1,
            this.tsmAddNewUser,
            this.tsmEdit,
            this.tsmDelete,
            this.tsmChangePassword,
            this.toolStripSeparator2,
            this.tsmSendEmail,
            this.tsmPhoneCall});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(249, 273);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(245, 6);
            // 
            // tsmShowDetails
            // 
            this.tsmShowDetails.Image = global::Driving_License_management.Properties.Resources.clipboard;
            this.tsmShowDetails.Name = "tsmShowDetails";
            this.tsmShowDetails.Size = new System.Drawing.Size(248, 32);
            this.tsmShowDetails.Text = "Show Details";
            // 
            // tsmAddNewUser
            // 
            this.tsmAddNewUser.Image = global::Driving_License_management.Properties.Resources._2;
            this.tsmAddNewUser.Name = "tsmAddNewUser";
            this.tsmAddNewUser.Size = new System.Drawing.Size(248, 32);
            this.tsmAddNewUser.Text = "Add New User";
            // 
            // tsmEdit
            // 
            this.tsmEdit.Image = global::Driving_License_management.Properties.Resources.edit;
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(248, 32);
            this.tsmEdit.Text = "Edit";
            // 
            // tsmDelete
            // 
            this.tsmDelete.Image = global::Driving_License_management.Properties.Resources.delete_row;
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(248, 32);
            this.tsmDelete.Text = "Delete";
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Image = global::Driving_License_management.Properties.Resources.password;
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(248, 32);
            this.tsmChangePassword.Text = "Change Password";
            // 
            // tsmSendEmail
            // 
            this.tsmSendEmail.Image = global::Driving_License_management.Properties.Resources.email;
            this.tsmSendEmail.Name = "tsmSendEmail";
            this.tsmSendEmail.Size = new System.Drawing.Size(248, 32);
            this.tsmSendEmail.Text = "Send Email";
            // 
            // tsmPhoneCall
            // 
            this.tsmPhoneCall.Image = global::Driving_License_management.Properties.Resources.phone;
            this.tsmPhoneCall.Name = "tsmPhoneCall";
            this.tsmPhoneCall.Size = new System.Drawing.Size(248, 32);
            this.tsmPhoneCall.Text = "Phone Call";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackgroundImage = global::Driving_License_management.Properties.Resources.salesman;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(847, 178);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(94, 55);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Driving_License_management.Properties.Resources.close__2_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(806, 567);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 63);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "        Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Driving_License_management.Properties.Resources.user_accounts;
            this.pictureBox1.Location = new System.Drawing.Point(415, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMangeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 642);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(lblRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.combFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMangeUser";
            this.Text = "Mange User";
            this.Load += new System.EventHandler(this.frmMangeUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combFilterBy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cIsActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmSendEmail;
        private System.Windows.Forms.ToolStripMenuItem tsmPhoneCall;
    }
}