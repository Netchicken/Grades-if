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
            lblDataError.Visible = false; //make sure the label is hidden

            //if the grade is less than 0 or greater than 100
            if ((grade <= 0) || (grade > 100))
            { //if they get less than 0
                lbxGrade.Items.Add(name + " scored " + grade + " = Data Error");
                lblDataError.Text = "Bad data for " + name;
                lblDataError.Visible = true; //show the label
                DataErrorProvider.SetError(this.lblDataError, "Grade is invalid.");
            }

            else if (grade < 50) //if the grade is less than 50
            {
                //this adds a new item to the listbox if it is less than 50
                lbxGrade.Items.Add(name + " scored " + grade + " = Fail");
            }
            else if (grade < 100)//if its not less than 50
            {
                //this adds a new item to the listbox if it is greater than 50
                lbxGrade.Items.Add(name + " scored " + grade + " = Pass");
            }

        }

    }
}