using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab08Form : Form
    {
        public string name;
        public float age;

        public Lab08Form()
        {
            InitializeComponent();
        }

        
        private void submitButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            //option A
            age = Convert.ToSingle(ageTextBox.Text);

            //option B
            age = float.Parse(ageTextBox.Text);

            //option C
            float tempFloat;
            bool result = float.TryParse(ageTextBox.Text, out tempFloat);
            age = tempFloat;

            //option D
            //age = (float)ageTextBox.Text;

            clearTextBox();
        }

        private void clearTextBox()
        {
            nameTextBox.Clear();
            ageTextBox.Clear();
        }

        private void Lab08Form_Load(object sender, EventArgs e)
        {
            submitButton.Enabled = false;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            validateTextbox();
        }
        
        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            validateTextbox();
        }

        private void validateTextbox()
        {
            bool condition1, condition2;
            condition1 = condition2 = false;

            try
            {
                age = float.Parse(ageTextBox.Text);
                condition1 = true;
            }
            catch
            {
                submitButton.Enabled = false;
                condition1 = false;
            }
            condition2 = (nameTextBox.Text.Length >= 2) ? true : false;

            if (condition2 == true && condition1 == true)
            {
                submitButton.Enabled = true;
            }
            else
            {
                submitButton.Enabled = false;
            }
        }

    }
}
