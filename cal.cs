using System;
using System.Windows.Forms;

namespace finalmarkcalculator
{
    public partial class Form1 : Form
    {
        private Student student;
        public Form1()
        {
            InitializeComponent();
            student = new Student();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Assigning values from textboxes to Student class variables
                student.Test1 = Convert.ToDouble(textBox1.Text);
                student.Test2 = Convert.ToDouble(textBox2.Text);
                student.ClassTest1 = Convert.ToDouble(textBox3.Text);
                student.ClassTest2 = Convert.ToDouble(textBox4.Text);
                student.FinalExam = Convert.ToDouble(textBox5.Text);
               // Calculating the final mark
                double finalMark = student.CalculateFinalMark();
                // Displaying the result
                textBox6.Text = $"The final mark of the student is {finalMark:F2}. The result is {student.CheckPassOrFail()}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for all assessments.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Clearing all fields
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Exiting the program
            Application.Exit();
        }
    }
    public class Student
    {
        // Instance variables
        public double Test1 { get; set; }
        public double Test2 { get; set; }
        public double ClassTest1 { get; set; }
        public double ClassTest2 { get; set; }
        public double FinalExam { get; set; }
        // Constructor
        public Student()
        {
            // Initialize instance variables if needed
        }

        // Method to calculate final mark
        public double CalculateFinalMark()
        {
            // Implement the logic to calculate the final mark based on assessments and their weights
            // You can customize this logic as per your requirement
            double finalMark = (Test1 * 0.15) + (Test2 * 0.20) + (Math.Max(ClassTest1, ClassTest2) * 0.15) + (FinalExam * 0.50);
            return finalMark;
        }
        // Method to check pass or fail
        public string CheckPassOrFail()
        {
            return CalculateFinalMark() >= 50 ? "Pass" : "Fail";
        }
    }
}

