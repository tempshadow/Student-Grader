namespace Student_Grader
{
    partial class AssignmentFrm
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
            this.assignmentbox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Assignment:";
            // 
            // assignmentbox
            // 
            this.assignmentbox.Location = new System.Drawing.Point(92, 19);
            this.assignmentbox.Name = "assignmentbox";
            this.assignmentbox.Size = new System.Drawing.Size(137, 20);
            this.assignmentbox.TabIndex = 0;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(76, 68);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // AssignmentFrm
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 103);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.assignmentbox);
            this.Controls.Add(this.label1);
            this.Name = "AssignmentFrm";
            this.Text = "AssignmentFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox assignmentbox;
        private System.Windows.Forms.Button submitBtn;
    }
}