using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms__StudentGrade
{
    public partial class Form1 : Form, IEnumerable
    {
        private List<Student> students = new List<Student>()
           {
               new Student{FirstName= "John", LastName= "Doe", Group = " bv1", ExamDate = new DateTime(2025, 10, 07)},
               new Student{FirstName= "Peter", LastName= "Jenifer", Group = "zs2", ExamDate = new DateTime(2030, 03, 08)},
               new Student{FirstName= "Kate", LastName= "Rowland", Group = "gy3", ExamDate = new DateTime(2024, 12, 06)}

          };


        public Form1()
        {
            InitializeComponent();

        }

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }

        private void Get_StatusButton_Click(object sender, EventArgs e)
        {

            try
            {
                double physics, maths, computer_Science, total, avearge;
                string grade;
                physics = int.Parse(textBoxPhysics.Text);
                maths = int.Parse(textBoxMath.Text);
                computer_Science = int.Parse(textBoxComputer.Text);

                total = physics + maths + computer_Science;

                textBoxTotalScore.Text = total.ToString();

                avearge = total / 3;

                textBoxAverage.Text = avearge.ToString();

                //Date and time here 
                dateTimePickerExamdate.Text = DateTime.Now.ToShortDateString();
                //Grade

                if (avearge >= 85)
                {
                    grade = "Excellent";
                }
                else if (avearge >= 75)
                {
                    grade = " very Good";
                }
                else if (avearge >= 65)
                {
                    grade = "Good";
                }
                else if (avearge >= 60)
                {
                    grade = "Pass";
                }
                else
                {
                    grade = "Fail";
                }


                textBoxGrade.Text = grade;
            }
            catch
            {
                MessageBox.Show("Kindly enter correct grade score");
            }
           
        }

       
    }
}
