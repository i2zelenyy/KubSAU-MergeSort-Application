using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeSort
{
    public partial class SortForm : Form
    {
        public SortForm()
        {
            InitializeComponent();
        }

        private double[] insert_array_double;
        private string[] insert_array;

        private void Merge(double[] input, int left_point, int middle_point, int right_point)
        {
            double[] left_array = new double[middle_point - left_point + 1];
            double[] right_array = new double[right_point - middle_point];

            Array.Copy(input, left_point, left_array, 0, middle_point - left_point + 1); // makes left part (array) from the source line
            Array.Copy(input, middle_point + 1, right_array, 0, right_point - middle_point); // makes right part (array)

            int i = 0; // index for left array
            int j = 0; // index for right array
            for (int k = left_point; k < right_point + 1; k++) // through all the source array
            {
                if (i == left_array.Length) // when (left_array[i] <= right_array[j]) is true
                {
                    input[k] = right_array[j]; // then right array goes to be  the second
                    j++;
                }
                else if (j == right_array.Length)
                {
                    input[k] = left_array[i];
                    i++;
                }
                else if (left_array[i] <= right_array[j])  // left element is less than right
                {
                    input[k] = left_array[i]; // then, left array goes to be the first
                    i++; // after that goes first "if" 
                }
                else // when (left_array[i] <= right_array[j]) is false
                {
                    input[k] = right_array[j];
                    j++;
                }
            }
        }
        private void MergeSort(double[] input, int left_point, int right_point)
        {
            if (left_point < right_point)
            {
                int middle_point = (left_point + right_point) / 2;
                MergeSort(input, left_point, middle_point);
                MergeSort(input, middle_point + 1, right_point);

                Merge(input, left_point, middle_point, right_point);
            }
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            var regex = new Regex(@"^-?[0-9\s]*[0-9,\-\s]*[0-9,\.\s]*[0-9,\.\-\s]*[0-9,\,\s]*[0-9,\,\-\s]*$"); // you are allowed to enter only numbers (even with comma)


            if (regex.IsMatch(TextBox1.Text) && !string.IsNullOrEmpty(TextBox1.Text))
            {
                insert_array = Regex.Replace(TextBox1.Text, @"\s+", " ").Replace(".", ",").Split(new char[] { ' ' });
            }
            else
            {
                MessageBox.Show("Missing data");
                return;
            }

            // Deletes some extra spaces
            List<string> temp = new List<string>(insert_array);
            for (short i = 0; i < insert_array.Length; i++)
            {
                if (temp[i] == "")
                    temp.RemoveAt(i);
                insert_array = temp.ToArray();
            }

            insert_array_double = new double[insert_array.Length]; // numbers as integer


            for (int i = 0; i < insert_array_double.Length; i++) // making the first spreadsheet
            {
                if (insert_array[0] == "")
                    break;
                else
                    Grid_1.ColumnCount = insert_array_double.Length;

                Grid_1.Rows[0].Cells[i].Value = insert_array[i];
                insert_array_double[i] = Convert.ToDouble(insert_array[i]);
            }

            Sort_Button.Enabled = true;
        }

        private void Sort_Button_Click(object sender, EventArgs e)
        {
            Grid_2.ColumnCount = 0;
            MergeSort(insert_array_double, 0, insert_array_double.Length - 1);

            insert_array_double.Reverse();

            for (short i = 0; i < insert_array_double.Length; i++) // making the second spreadsheet
            {
                Grid_2.ColumnCount = insert_array_double.Length;
                Grid_2.Rows[0].Cells[i].Value = insert_array_double[i];
            }

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            MainForm Menu = new MainForm();
            Menu.Show();
            this.Hide();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }


        // Move the MainForm
        Point LastPoint;
        private void UpperPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y); // Saves last coordinates of the pointer
        }
        private void UpperPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // If left mouse button is pressed
            {
                this.Left += e.X - LastPoint.X; // Add to "X coord." a subtraction between current and next points
                this.Top += e.Y - LastPoint.Y; // Add to "Y coord." a subtraction between current and next points
            }
        }

        // Move the label on the Upper Panel
        private void MergeSort_label_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y); // Saves last coordinates of the pointer
        }
        private void MergeSort_label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // If left mouse button is pressed
            {
                this.Left += e.X - LastPoint.X; // Add to "X coord." a subtraction between current and next points
                this.Top += e.Y - LastPoint.Y; // Add to "Y coord." a subtraction between current and next points
            }
        }

        private void Help_Button_Click(object sender, EventArgs e)
        {
            HelpForm Help = new HelpForm();
            Help.Show();
            this.Hide();
        }
    }
}
