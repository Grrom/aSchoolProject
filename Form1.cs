using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            StudentInfoClass.FirstName = firstNameBox.Text.Trim();
            StudentInfoClass.LastName = lastNameBox.Text.Trim();
            StudentInfoClass.MiddleName = middleNameBox.Text.Trim();
            StudentInfoClass.Program = programBox.Text.Trim();
            StudentInfoClass.Address = addressBox.Text.Trim();


            long.TryParse(ageBox.Text, out StudentInfoClass.Age);
            long.TryParse(contactBox.Text, out StudentInfoClass.ContactNo);
            long.TryParse(studentNoBox.Text, out StudentInfoClass.StudentNo);

            new Form2().Show();
        }

    }
}
