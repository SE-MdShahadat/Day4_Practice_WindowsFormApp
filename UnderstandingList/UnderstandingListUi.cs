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
        List<int> copyNumbers = new List<int>();
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
            message = "";
            foreach(int number in numbers)
            {
                message = message + number + " ";
            }
            displayRichTextBox.Text = message;
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            numbers.Reverse();
            message = "Reverse Elements are: ";
            displayRichTextBox.Text = AllElement(message, numbers);
        }

        private string AllElement(string message, List<int> numbers)
        {
            
            foreach (int number in numbers)
            {
                message = message + number + " ";
            }
            
            return message;
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            message = "Sum of all Elements: ";
            displayRichTextBox.Text = AllElement(message,numbers) + " \nSum: " + numbers.Sum();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            copyNumbers = numbers;
            message = "All Elements of copy List: ";
            foreach(int copyNumber in copyNumbers)
            {
                message = message + " " + copyNumber;
            }
            displayRichTextBox.Text = AllElement("All Elements are: ",numbers) + "\n" + message;
        }

        private void UniqueButton_Click(object sender, EventArgs e)
        {
            List<int> uniqueNumbers = new List<int>();
            foreach(int number in numbers)
            {
                int count = 0;
                for(int index =0; index<numbers.Count; index++)
                {
                    if (numbers[index]==number)
                    {
                        count++;
                    }
                }
                if (count <= 1)
                {
                    uniqueNumbers.Add(number);
                }
            }
            displayRichTextBox.Text = AllElement("All elements are: ", numbers) + AllElement("\nAll unique numbers are: ", uniqueNumbers);
            
        }

        private void DuplicateButton_Click(object sender, EventArgs e)
        {
            int totalDuplicate = 0;
            foreach (int number in numbers)
            {
                
                int count = -1;
                for(int index=0; index<numbers.Count; index++)
                {
                    if (numbers[index] == number)
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    totalDuplicate = totalDuplicate + count;
                }
            }
            displayRichTextBox.Text = AllElement("All elements are: ", numbers) + "\nTotal Duplicate Found: " + totalDuplicate;
        }

        private void MaxMinButton_Click(object sender, EventArgs e)
        {
            displayRichTextBox.Text = AllElement("All elements are: ", numbers) + "\nMaximum Element: " + numbers.Max() + "\nMinimum Element: " + numbers.Min();
        }

        private void OddEvenButton_Click(object sender, EventArgs e)
        {
            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();
            foreach(int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }else if (number % 2 == 1)
                {
                    oddNumbers.Add(number);
                }
            }
            displayRichTextBox.Text = AllElement("All Elements are: ", numbers) + AllElement("\nOdd Numbers are: ", oddNumbers) + AllElement("\nEven Numbers are: ", evenNumbers);
        }

        private void AscendingSortButton_Click(object sender, EventArgs e)
        {
            
            numbers.Sort();
            displayRichTextBox.Text = AllElement("All Elements are: ", numbers);
        }

        private void DescendingSortButton_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            numbers.Reverse();
            displayRichTextBox.Text = AllElement("All Elements are: ", numbers);
        }
    }
}
