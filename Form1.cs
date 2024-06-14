using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafes_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //converts the grade which is a text to a number.
            Single grade = Convert.ToSingle(txtGrade.Text); //make a variable to hold the grade
            String name = txtName.Text; //make a variable to hoild the name


            if (grade < 50) //if the grade is less than 50
            {
                //this adds a new item to the listbox if it is less than 50
                lbxGrade.Items.Add(name + " scored " + grade + " = Fail");
            }
            else //if its not less than 50
            {
                //this adds a new item to the listbox if it is greater than 50
                lbxGrade.Items.Add(name + " scored " + grade + " = Pass");
            }
        }
    }
}