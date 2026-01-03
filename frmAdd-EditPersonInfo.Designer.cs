namespace Driving_License_management
{
    partial class frmAdd_EditPersonInfo
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
            this.lblAddEditPerson = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.ctrlAddEditPerson1 = new Driving_License_management.ctrlAddEditPerson();
            this.SuspendLayout();
            // 
            // lblAddEditPerson
            // 
            this.lblAddEditPerson.AutoSize = true;
            this.lblAddEditPerson.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditPerson.ForeColor = System.Drawing.Color.Red;
            this.lblAddEditPerson.Location = new System.Drawing.Point(246, 19);
            this.lblAddEditPerson.Name = "lblAddEditPerson";
            this.lblAddEditPerson.Size = new System.Drawing.Size(381, 46);
            this.lblAddEditPerson.TabIndex = 1;
            this.lblAddEditPerson.Text = "Add/Edit New Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Person ID:";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(158, 84);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(49, 25);
            this.lblPersonID.TabIndex = 3;
            this.lblPersonID.Text = "N/A";
            // 
            // ctrlAddEditPerson1
            // 
            this.ctrlAddEditPerson1.Address = null;
            this.ctrlAddEditPerson1.CountryID = 51;
            this.ctrlAddEditPerson1.DateOfBirth = new System.DateTime(2007, 12, 13, 0, 0, 0, 0);
            this.ctrlAddEditPerson1.Email = null;
            this.ctrlAddEditPerson1.FirstName = null;
            this.ctrlAddEditPerson1.Gendor = ((byte)(0));
            this.ctrlAddEditPerson1.ImagePath = null;
            this.ctrlAddEditPerson1.LastName = null;
            this.ctrlAddEditPerson1.Location = new System.Drawing.Point(6, 117);
            this.ctrlAddEditPerson1.Name = "ctrlAddEditPerson1";
            this.ctrlAddEditPerson1.National_NO = null;
            this.ctrlAddEditPerson1.Phone = null;
            this.ctrlAddEditPerson1.SecondName = null;
            this.ctrlAddEditPerson1.Size = new System.Drawing.Size(852, 366);
            this.ctrlAddEditPerson1.TabIndex = 4;
            this.ctrlAddEditPerson1.ThirdName = null;
           
            // 
            // frmAdd_EditPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 487);
            this.Controls.Add(this.ctrlAddEditPerson1);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAddEditPerson);
            this.Name = "frmAdd_EditPersonInfo";
            this.Text = "Add/Edit Person Info";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAddEditPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPersonID;
        private ctrlAddEditPerson ctrlAddEditPerson1;
    }
}