using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passByRef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // a variable must be initialized before passing
            // an argument by reference using "reference" parameter variable.

            int num1 = 98;
            int num2 = 99;
            int num3 = 100;


            outputListBox.Items.Clear();

            outputListBox.Items.Add("number1 is set to " + num1);
            outputListBox.Items.Add("number2 is set to " + num2);
            outputListBox.Items.Add("number3 is set to " + num3);


            // control goes to SetToZero method with 
            // value being passed by reference.

            // in pass by reference, parameter variable is reference to the argument, it means 
            // when argument is passed as a reference its value is changed instead of parameter variable.

            // a keyword "ref" has been added to identify it as argument been passed by reference.

            SetToZero(ref num1);
            SetToZero(ref num2);
            SetToZero(ref num3);

            outputListBox.Items.Add("==========================");
            outputListBox.Items.Add("number1 is set to " + num1);
            outputListBox.Items.Add("number2 is set to " + num2);
            outputListBox.Items.Add("number3 is set to " + num3);
        }
        private void SetToZero(ref int number) // number par variable references to num1 variable.
        {
            number = 0;
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
