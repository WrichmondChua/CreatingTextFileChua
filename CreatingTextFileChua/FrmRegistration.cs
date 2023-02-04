using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CreatingTextFileChua
{
    public partial class FrmRegistration : Form
    {
        public static string SetFileName2 = ".txt";
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            int StudentNumber = Convert.ToInt32(txtStudentNumber.Text.ToString());
            String LastName = txtLastName.Text;
            int Age = Convert.ToInt32(txtAge.Text.ToString());
            string Birthday = dtpBirthday.Value.ToString("yyyy-MM-dd");
            string Program = cbProgram.SelectedItem.ToString();
            string FirstName = txtFirstName.Text;
            string MiddleInitial = txtMiddleInitial.Text;
            string Gender = cbGender.SelectedItem.ToString();
            long ContactNumber = Convert.ToInt64(txtContactNumber.Text.ToString());

           

            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile2 = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile2.WriteLine("Student No.: " + StudentNumber);
                outputFile2.WriteLine("Full Name: " + LastName + ", " + FirstName + ", " + MiddleInitial);
                outputFile2.WriteLine("Program: " + Program);
                outputFile2.WriteLine("Gender: " + Gender);
                outputFile2.WriteLine("Age: " + Age);
                outputFile2.WriteLine("Birthday: " + Birthday);
                outputFile2.WriteLine("Contact No.: " + ContactNumber);

              
            }








        }
    }
}
