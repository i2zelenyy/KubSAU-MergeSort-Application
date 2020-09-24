using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeSort
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            SortForm Sort = new SortForm();
            Sort.Show();
            this.Hide();
        }
        private void About_Button_Click(object sender, EventArgs e)
        {
            AboutForm About = new AboutForm();
            About.Show();
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

        private void Start_Picture_Click(object sender, EventArgs e)
        {

        }
    }
}
