using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // var keyword: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/var
            var numOne = int.Parse(num1Text.Text);
            var numTwo = int.Parse(num2Text.Text);
            var numThree = int.Parse(num3Text.Text);
            
            var outputMethodRunner = MethodRunner.RunAllMethods(numOne, numTwo, numThree);
            var outputLambdaRunner = LambdaRunner.RunAllMethods(numOne, numTwo, numThree);
            
            methodOutput.Text = outputMethodRunner;
            lambdaOutput.Text = outputLambdaRunner;
            
            // ... Compare both outputs and check if they are the same
            // When they are equal, show a messagebox:
            // MessageBox.Show("Your message here");
        }
    }
}
