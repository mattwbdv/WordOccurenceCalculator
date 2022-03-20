using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordOccurenceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // take the text in textbox, split it into a list of words
            // Get the string from the textbox 
            String raw = textBox.Text;
            List<string> list = new List<string> { };

            list = raw.Split(' ').ToList();

            // pass it to WordCalculator
            String answer = WordCalculator.CalculateOccurrences(list);

            // display the result list of the WordOccurrence list in the label
            form_result.Text = answer;
        }
    }
}
