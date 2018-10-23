using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grader
{
    public partial class AssignmentFrm : Form
    {
        public AssignmentFrm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;
            string temp = assignmentbox.Text;
            f1.updateStudents(temp);
            assignmentbox.Text = "";
        }
    }
}
