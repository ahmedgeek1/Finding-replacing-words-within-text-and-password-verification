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

namespace Assessment10B
{
    public partial class WorkingWithDataIIForm : Form
    {
        public WorkingWithDataIIForm()
        {
            InitializeComponent();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {   //on click on the button start
            listBoxStartingPositions.Items.Clear(); //clear whatever in the listbox
            //declare variables
            String longText, shortText;
            int numberOfmatches;
            longText = richTxtBoxUserInput.Text.Trim();
            shortText = txtBoxWordToFind.Text.Trim();
            if (longText.Length > 0)
            {//check if the user has entered a text
                if (shortText.Length > 0)
                {//check if the user has entered a text to find
                    numberOfmatches = numberOfMatches(longText, shortText);
                    lblNumberOfMatches.Text = numberOfmatches.ToString();
                    indexesOfMatch(longText, shortText);
                    replaceMatches(longText, shortText, txtBoxWordToReplace.Text.Trim());
                }
                else
                {//show error message
                    MessageBox.Show("Please enter a word/phrase to search for in your text!");
                    txtBoxWordToFind.Focus();
                }
            }
            else
            {//show error message
                MessageBox.Show("Please enter a text to analyse!");
                richTxtBoxUserInput.Focus();
            }
        }

        private int numberOfMatches(String longText, String shortText)
        {//method that returns the number of matches found in the text enteredt by the user
            int num = Regex.Matches(Regex.Escape(longText), shortText).Count;
            return num;
        }

        private void indexesOfMatch(String longText, String shortText)
        {//method that add the index of the text matched in a listbox
            foreach (Match match in Regex.Matches(longText, shortText))
            {//using foreach loop to check for every match case
                int indexOfMatch = match.Index;
                int indexOfMatchReal = indexOfMatch + 1;
                listBoxStartingPositions.Items.Add("Index of match: " + indexOfMatchReal); //adding to the listbox
            }

        }

        private void replaceMatches(String longText, String shortText, String replacement)
        {//method to replace the matches in case the user entered a text to be replaced with 
            string result;
            if (replacement.Length > 0)
            {//if the user entered a text in the replace with field 
                foreach (Match match in Regex.Matches(longText, shortText))
                {
                    Regex rgx = new Regex(shortText);
                    result = rgx.Replace(longText, replacement);
                    richTxtBoxUserInput.Text = result;
                }
            }
        }

        private void txtBoxPasswordInput_TextChanged(object sender, EventArgs e)
        {//while writing the password in the textbox, a verification is made for every case
            string password = txtBoxPasswordInput.Text; //hold the input by the user in a variable
            int counter = 0; //a counter to count how many matches the password made, in every verified case the counter increment

            if (checkLength(password)){ checkBoxLength.Checked = true; counter++;} else {checkBoxLength.Checked = false;}
            if (hasUpperCase(password)) {checkBoxUpperCase.Checked = true; counter++;} else {checkBoxUpperCase.Checked = false;}
            if (hasLowerCase(password)) {checkBoxLowerCase.Checked = true; counter++; } else { checkBoxLowerCase.Checked = false; }
            if (hasNumericValue(password)) { checkBoxHasNumber.Checked = true; counter++; } else  {  checkBoxHasNumber.Checked = false;  }
            if (hasSpace(password)) { checkBoxSpace.Checked = true; counter++; } else { checkBoxSpace.Checked = false; }
            if (hasSpecialCharacter(password)) { checkBoxSpecialCarachter.Checked = true; counter++; } else { checkBoxSpecialCarachter.Checked = false; }
            //if all cases are valid, then the background becomes green, otherwise the background is red
            if (counter == 6) { txtBoxPasswordInput.BackColor = Color.Green; } else { txtBoxPasswordInput.BackColor = Color.Red;}
        }

        private Boolean checkLength(string password)
        {   //method to check the length of the password
            Boolean passwordIs8Long = false;
            if (password.Length >= 8)
            {
                passwordIs8Long = true;
            }
            else
            {
                passwordIs8Long = false;
            }
            return passwordIs8Long;
        }

        private Boolean hasUpperCase(string password)
        {//a method to check if the password has at least 1 upper case
            Boolean hasUpper = false;
            foreach (char ch in password)
            {
                if (char.IsUpper(ch))
                {
                    hasUpper = true;
                    break;
                }
            }
            return hasUpper;
        }
        private Boolean hasLowerCase(string password)
        {//a method to check if the password has at least 1 lower case
            Boolean hasLower = false;
            foreach (char ch in password)
            {
                if (char.IsLower(ch))
                {
                    hasLower = true;
                    break;
                }
            }
            return hasLower;
        }

        private Boolean hasNumericValue(string password)
        {//a method to check if the password has at least 1 numeric value
            Boolean hasNumeric = false;
            foreach (char ch in password)
            {
                if (char.IsNumber(ch))
                {
                    hasNumeric = true;
                    break;
                }
            }
            return hasNumeric;

        }

        private Boolean hasSpace(string password)
        {//a method to check if the password has at least 1 space character
            Boolean hasSpace = false;

            if (password.Contains(" "))
            {
                hasSpace = true;
            }
            return hasSpace;

        }
        private Boolean hasSpecialCharacter(string password)
        {//a method to check if the password has at least 1 special character
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (password.Contains(item)) return true;
            }

            return false;

        }

        private void btnClear_Click(object sender, EventArgs e)
        { //clearing all checkboxes, listbox, textboxes and label
            richTxtBoxUserInput.Text = "";
            txtBoxWordToFind.Text = "";
            txtBoxWordToReplace.Text = "";
            txtBoxPasswordInput.Text = "";
            lblNumberOfMatches.Text = "";
            listBoxStartingPositions.Items.Clear();
            checkBoxHasNumber.Checked = false;
            checkBoxLength.Checked = false;
            checkBoxLowerCase.Checked = false;
            checkBoxSpace.Checked = false;
            checkBoxUpperCase.Checked = false;
            checkBoxSpecialCarachter.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }
    }
}