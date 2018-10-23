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
    public partial class studentFrm : Form
    {
        public studentFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;
            Student student = new Student();
            student.name = txtName.Text.ToUpper();
            try
            {
                student.age = Convert.ToInt32(txtAge.Text);
                if(student.age < 0)
                {
                    MessageBox.Show("Age must more than zero!");
                    txtAge.Focus();
                }
                else
                {
                    student.address = txtAddress.Text;
                    List<Student> studentlist = new List<Student>();
                    studentlist.Add(student);
                    f1.populateList(studentlist);
                    txtName.Text = "";
                    txtAge.Text = "";
                    txtAddress.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Age can only be a number!");
                txtAge.Focus();
            }
        }
    }
}
