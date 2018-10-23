namespace Student_Grader
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.addAssignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboBox = new System.Windows.Forms.ComboBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.assignmentBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gradeBox = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.addAssignmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "File";
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(85, 20);
            this.menuAdd.Text = "Add Student";
            this.menuAdd.ToolTipText = "Adds a student to the student list.";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // addAssignmentToolStripMenuItem
            // 
            this.addAssignmentToolStripMenuItem.Name = "addAssignmentToolStripMenuItem";
            this.addAssignmentToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.addAssignmentToolStripMenuItem.Text = "Add Assignment";
            this.addAssignmentToolStripMenuItem.ToolTipText = "Adds an assignment for all students.";
            this.addAssignmentToolStripMenuItem.Click += new System.EventHandler(this.addAssignmentToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Student Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Student Address:";
            // 
            // cmboBox
            // 
            this.cmboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBox.FormattingEnabled = true;
            this.cmboBox.Location = new System.Drawing.Point(68, 27);
            this.cmboBox.Name = "cmboBox";
            this.cmboBox.Size = new System.Drawing.Size(132, 21);
            this.cmboBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmboBox, "A dropdown list that displays all students that have been added.");
            this.cmboBox.SelectedIndexChanged += new System.EventHandler(this.cmboBox_SelectedIndexChanged);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(327, 68);
            this.addressBox.Name = "addressBox";
            this.addressBox.ReadOnly = true;
            this.addressBox.Size = new System.Drawing.Size(153, 20);
            this.addressBox.TabIndex = 9;
            this.toolTip1.SetToolTip(this.addressBox, "Selected students address.");
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(327, 28);
            this.ageBox.Name = "ageBox";
            this.ageBox.ReadOnly = true;
            this.ageBox.Size = new System.Drawing.Size(153, 20);
            this.ageBox.TabIndex = 8;
            this.toolTip1.SetToolTip(this.ageBox, "Selected students age.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Assignment: ";
            // 
            // assignmentBox
            // 
            this.assignmentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assignmentBox.FormattingEnabled = true;
            this.assignmentBox.Location = new System.Drawing.Point(327, 111);
            this.assignmentBox.Name = "assignmentBox";
            this.assignmentBox.Size = new System.Drawing.Size(153, 21);
            this.assignmentBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.assignmentBox, "A dropdown list that displays all assignments for the selected student.");
            this.assignmentBox.SelectedIndexChanged += new System.EventHandler(this.assignmentBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Students:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Grade:";
            // 
            // gradeBox
            // 
            this.gradeBox.Location = new System.Drawing.Point(327, 154);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.ReadOnly = true;
            this.gradeBox.Size = new System.Drawing.Size(153, 20);
            this.gradeBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.gradeBox, "Selected assignments grade for the selected student.");
            // 
            // editBtn
            // 
            this.editBtn.Enabled = false;
            this.editBtn.Location = new System.Drawing.Point(12, 66);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Edit Grade";
            this.toolTip1.SetToolTip(this.editBtn, "Allaws you to edit the grade for the selected assignment of the selected student." +
        "");
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(12, 109);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.toolTip1.SetToolTip(this.saveBtn, "Saves the entered grade.");
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Enabled = false;
            this.cancelBtn.Location = new System.Drawing.Point(12, 151);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.toolTip1.SetToolTip(this.cancelBtn, "Cancels the change to the grade.");
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(93, 109);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(121, 23);
            this.removeBtn.TabIndex = 7;
            this.removeBtn.Text = "Remove Assignments";
            this.toolTip1.SetToolTip(this.removeBtn, "Removes all assignments from every student.");
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(492, 200);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.gradeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.assignmentBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.cmboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Student Grader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox assignmentBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gradeBox;
        private System.Windows.Forms.ToolStripMenuItem addAssignmentToolStripMenuItem;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

