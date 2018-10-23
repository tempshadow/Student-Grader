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
    public partial class Form1 : Form
    {
        List<Student> list = new List<Student>();
        public Form1()
        {
            InitializeComponent();

        }

        public void populateList(List<Student> input)
        {
             for(int i = 0; i < input.Count(); i++)
            {
                if(cmboBox.Items.Contains(input[i].name))
                {
                    MessageBox.Show("Student already exists!");
                }
                else
                {
                    cmboBox.Items.Add(input[i].name);
                    list.Add(input[i]);
                    MessageBox.Show(input[i].name + " added!");
                }
            }
        }

        public void updateStudents(string input)
        {
            int addcount = 0;
            int errorcount = 0;
            for(int i = 0; i < list.Count(); i++)
            {
                int count = 0;
                Assignments temp = new Assignments();
                temp.name = input.ToUpper();
                temp.grade = "-";
                for (int j = 0; j < list[i].assignmentlist.Count(); j++)
                {
                    if(list[i].assignmentlist[j].name == input.ToUpper())
                    {
                        count++;
                        errorcount++;
                    }
                }
                if(list[0].assignmentlist.Count() == 0)
                {
                    list[i].assignmentlist.Add(temp);
                    addcount++;
                }
                else if (count < list[0].assignmentlist.Count())
                {
                    list[i].assignmentlist.Add(temp);
                    addcount++;
                }
                else if (errorcount == list.Count())
                {
                    MessageBox.Show("Assignment " + input.ToUpper() + " already exists!");
                }
            }
            if(addcount > 0) { MessageBox.Show("Assignment Added!"); }
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            studentFrm student = new studentFrm();
            student.ShowDialog(this);
        }

        private void cmboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gradeBox.Text = "";
            Console.WriteLine(cmboBox.SelectedIndex.ToString());
            assignmentBox.Items.Clear();
            ageBox.Text = list[cmboBox.SelectedIndex].age.ToString();
            addressBox.Text = list[cmboBox.SelectedIndex].address;
            for(int i = 0; i < list[cmboBox.SelectedIndex].assignmentlist.Count(); i++)
            {
                assignmentBox.Items.Add(list[cmboBox.SelectedIndex].assignmentlist[i].name);
            }
        }

        private void addAssignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignmentFrm asform = new AssignmentFrm();
            asform.ShowDialog(this);
        }

        private void assignmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gradeBox.Text = list[cmboBox.SelectedIndex].assignmentlist[assignmentBox.SelectedIndex].grade;
            editBtn.Enabled = true;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            gradeBox.Focus();
            saveBtn.Enabled = true;
            cancelBtn.Enabled = true;
            removeBtn.Enabled = false;
            editBtn.Enabled = false;
            gradeBox.ReadOnly = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
            cancelBtn.Enabled = false;
            gradeBox.Text = list[cmboBox.SelectedIndex].assignmentlist[assignmentBox.SelectedIndex].grade;
            gradeBox.ReadOnly = true;
            removeBtn.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
            cancelBtn.Enabled = false;
            removeBtn.Enabled = true;
            try
            {
                int num = Convert.ToInt32(gradeBox.Text);
                if(num < 0)
                {
                    MessageBox.Show("Grade must be more than zero!");
                    gradeBox.Focus();
                }
                else
                {
                    list[cmboBox.SelectedIndex].assignmentlist[assignmentBox.SelectedIndex].grade = gradeBox.Text;
                    Console.WriteLine(list[1].assignmentlist[0].grade);
                    Console.WriteLine(cmboBox.SelectedIndex);
                    gradeBox.ReadOnly = true;
                }
            }
            catch
            {
                MessageBox.Show("Grade must be a number!");
                gradeBox.Focus();
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure? This will DELETE ALL assignments from " +
                "every student!", "WARNING!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for(int i = 0; i < list.Count; i++)
                {
                    list[i].assignmentlist.Clear();
                }
                gradeBox.Text = "";
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
