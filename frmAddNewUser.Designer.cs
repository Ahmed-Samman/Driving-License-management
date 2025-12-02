namespace Driving_License_management
{
    partial class frmAddNewUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectPerson = new System.Windows.Forms.Button();
            this.btnNextPage2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabcPersonInfo = new System.Windows.Forms.TabControl();
            this.tpage1PersonalInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonDetails1 = new Driving_License_management.ctrlPersonDetails();
            this.tpage2LoginInfo = new System.Windows.Forms.TabPage();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabcPersonInfo.SuspendLayout();
            this.tpage1PersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(329, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New User";
            // 
            // btnSelectPerson
            // 
            this.btnSelectPerson.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSelectPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPerson.Location = new System.Drawing.Point(612, 19);
            this.btnSelectPerson.Name = "btnSelectPerson";
            this.btnSelectPerson.Size = new System.Drawing.Size(186, 56);
            this.btnSelectPerson.TabIndex = 30;
            this.btnSelectPerson.Text = "Select a Person\r\n";
            this.btnSelectPerson.UseVisualStyleBackColor = false;
            this.btnSelectPerson.Click += new System.EventHandler(this.btnSelectPerson_Click);
            // 
            // btnNextPage2
            // 
            this.btnNextPage2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNextPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage2.Image = global::Driving_License_management.Properties.Resources.next__1_;
            this.btnNextPage2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNextPage2.Location = new System.Drawing.Point(666, 379);
            this.btnNextPage2.Name = "btnNextPage2";
            this.btnNextPage2.Size = new System.Drawing.Size(142, 59);
            this.btnNextPage2.TabIndex = 29;
            this.btnNextPage2.Text = "Next       ";
            this.btnNextPage2.UseVisualStyleBackColor = true;
            this.btnNextPage2.Click += new System.EventHandler(this.btnNextPage2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::Driving_License_management.Properties.Resources.diskette__2_;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(695, 561);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 58);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "        Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Driving_License_management.Properties.Resources.close__2_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(531, 561);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 58);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "        Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabcPersonInfo);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnSave);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnClose);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(867, 631);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(867, 631);
            this.toolStripContainer1.TabIndex = 32;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // tabcPersonInfo
            // 
            this.tabcPersonInfo.Controls.Add(this.tpage1PersonalInfo);
            this.tabcPersonInfo.Controls.Add(this.tpage2LoginInfo);
            this.tabcPersonInfo.Location = new System.Drawing.Point(25, 72);
            this.tabcPersonInfo.Name = "tabcPersonInfo";
            this.tabcPersonInfo.SelectedIndex = 0;
            this.tabcPersonInfo.Size = new System.Drawing.Size(827, 483);
            this.tabcPersonInfo.TabIndex = 31;
            // 
            // tpage1PersonalInfo
            // 
            this.tpage1PersonalInfo.Controls.Add(this.ctrlPersonDetails1);
            this.tpage1PersonalInfo.Controls.Add(this.btnSelectPerson);
            this.tpage1PersonalInfo.Controls.Add(this.btnNextPage2);
            this.tpage1PersonalInfo.Location = new System.Drawing.Point(4, 29);
            this.tpage1PersonalInfo.Name = "tpage1PersonalInfo";
            this.tpage1PersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpage1PersonalInfo.Size = new System.Drawing.Size(819, 450);
            this.tpage1PersonalInfo.TabIndex = 0;
            this.tpage1PersonalInfo.Text = "Personal Info";
            this.tpage1PersonalInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(9, 91);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(799, 276);
            this.ctrlPersonDetails1.TabIndex = 1;
            // 
            // tpage2LoginInfo
            // 
            this.tpage2LoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpage2LoginInfo.Location = new System.Drawing.Point(4, 29);
            this.tpage2LoginInfo.Name = "tpage2LoginInfo";
            this.tpage2LoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpage2LoginInfo.Size = new System.Drawing.Size(819, 450);
            this.tpage2LoginInfo.TabIndex = 1;
            this.tpage2LoginInfo.Text = "Login Info";
            this.tpage2LoginInfo.UseVisualStyleBackColor = true;
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 631);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "frmAddNewUser";
            this.Text = "Add New User";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabcPersonInfo.ResumeLayout(false);
            this.tpage1PersonalInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrlPersonDetails ctrlPersonDetails1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNextPage2;
        private System.Windows.Forms.Button btnSelectPerson;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TabControl tabcPersonInfo;
        private System.Windows.Forms.TabPage tpage1PersonalInfo;
        private System.Windows.Forms.TabPage tpage2LoginInfo;
    }
}