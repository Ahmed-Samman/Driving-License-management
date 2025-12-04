namespace Driving_License_management
{
    partial class frmUserInfo
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
            this.ctrlPersonDetailsAndlogin1 = new Driving_License_management.ctrlPersonDetailsAndlogin();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlPersonDetailsAndlogin1
            // 
            this.ctrlPersonDetailsAndlogin1.Location = new System.Drawing.Point(12, 12);
            this.ctrlPersonDetailsAndlogin1.Name = "ctrlPersonDetailsAndlogin1";
            this.ctrlPersonDetailsAndlogin1.Size = new System.Drawing.Size(861, 448);
            this.ctrlPersonDetailsAndlogin1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Driving_License_management.Properties.Resources.close__2_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(693, 466);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 58);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "        Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 543);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlPersonDetailsAndlogin1);
            this.Name = "frmUserInfo";
            this.Text = "frmUserInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonDetailsAndlogin ctrlPersonDetailsAndlogin1;
        private System.Windows.Forms.Button btnClose;
    }
}