using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnderstandingList
{
    public partial class UnderstandingListUi : Form
    {
        List<int> numbers = new List<int>();
        int index = 0;
        string message="All elements are: ";
        public UnderstandingListUi()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            numbers.Add(Convert.ToInt32(inputTextBox.Text));
            displayRichTextBox.Text = "Element: " + inputTextBox.Text + " , Saved!!!";
            inputTextBox.Clear();
            
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            foreach(int number in numbers)
            {
                message = message + number + " ";
            }
            displayRichTextBox.Text = message;
        }
    }
}
