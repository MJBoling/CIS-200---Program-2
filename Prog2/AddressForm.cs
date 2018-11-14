// Program 2
// Due Date: 10/23/2017
// CIS 200-01
// Grading ID: C6643
// The AddressForm is a modal dialogue box where the user can input a new address to be added to the upv.AddressList.
// The AddressForm performs validation and will not allow the user to submit an address that does not abide by 
// the validation rules.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
            
            // Adds the states to the stateComboBox
            stateComboBox.Items.Add("AL");
            stateComboBox.Items.Add("AK");
            stateComboBox.Items.Add("AZ");
            stateComboBox.Items.Add("AR");
            stateComboBox.Items.Add("CA");
            stateComboBox.Items.Add("CO");
            stateComboBox.Items.Add("CT");
            stateComboBox.Items.Add("DE");
            stateComboBox.Items.Add("FL");
            stateComboBox.Items.Add("GA");
            stateComboBox.Items.Add("HI");
            stateComboBox.Items.Add("ID");
            stateComboBox.Items.Add("IL");
            stateComboBox.Items.Add("IN");
            stateComboBox.Items.Add("IA");
            stateComboBox.Items.Add("KS");
            stateComboBox.Items.Add("KY");
            stateComboBox.Items.Add("LA");
            stateComboBox.Items.Add("ME");
            stateComboBox.Items.Add("MD");
            stateComboBox.Items.Add("MA");
            stateComboBox.Items.Add("MI");
            stateComboBox.Items.Add("MN");
            stateComboBox.Items.Add("MS");
            stateComboBox.Items.Add("MO");
            stateComboBox.Items.Add("MT");
            stateComboBox.Items.Add("NE");
            stateComboBox.Items.Add("NV");
            stateComboBox.Items.Add("NH");
            stateComboBox.Items.Add("NJ");
            stateComboBox.Items.Add("NM");
            stateComboBox.Items.Add("NY");
            stateComboBox.Items.Add("NC");
            stateComboBox.Items.Add("ND");
            stateComboBox.Items.Add("OH");
            stateComboBox.Items.Add("OK");
            stateComboBox.Items.Add("OR");
            stateComboBox.Items.Add("PA");
            stateComboBox.Items.Add("RI");
            stateComboBox.Items.Add("SC");
            stateComboBox.Items.Add("SD");
            stateComboBox.Items.Add("TN");
            stateComboBox.Items.Add("TX");
            stateComboBox.Items.Add("UT");
            stateComboBox.Items.Add("VT");
            stateComboBox.Items.Add("VA");
            stateComboBox.Items.Add("WA");
            stateComboBox.Items.Add("WV");
            stateComboBox.Items.Add("WI");
            stateComboBox.Items.Add("WY");
        }

        internal string NameValue
        {
            // Precondition: None
            // Postcondition: The value entered in nameTextBox is returned
            get { return nameTextBox.Text; }

            //Precondition: nameTextBox is returned
            // Postcondition: The value in nameTextBox is set to value
            set { nameTextBox.Text = value; }
        }

        internal string Address1Value
        {
            // Precondition: None
            // Postcondition: The value entered in addressLine1TextBox is returned
            get { return addressLine1TextBox.Text; }

            // Precondition: addressLine1TextBox is returned
            // Postcondition: The value in addressLine1TextBox is set to value
            set { addressLine1TextBox.Text = value; }
        }

        internal string Address2Value
        {
            // Precondition: None
            // Postcondition: The value entered in addressLine2TextBox is returned
            get { return addressLine2TextBox.Text; }

            // Precondition: addressLine2TextBox is returned
            // Postcondition: The value in addressLine2TextBox is set to value
            set { addressLine2TextBox.Text = value; }
        }

        internal string CityValue
        {
            // Precondition: None
            // Postcondition: The value entered in cityTextBox is returned
            get { return cityTextBox.Text; }

            // Precondition: cityTextBox is returned
            // Postcondition: The value in cityTextBox is set to value
            set { cityTextBox.Text = value; }
        }

        internal string StateValue
        {
            // Precondition: None
            // Postcondition: The value entered in stateComboBox is returned
            get { return stateComboBox.Text; }

            // Precondition: stateComboBox is returned
            // Postcondition: The value in stateComboBox is set to value
            set { stateComboBox.Text = value; }
        }

        internal string ZipCodeValue
        {
            // Precondition: None
            // Postcondition: The value entered in zipCodeTextBox is returned
            get { return zipCodeTextBox.Text; }

            // Precondition: zipCodeTextBox is returned
            // Postcondition: The value in zipCodeTextBox is set to value
            set { zipCodeTextBox.Text = value; }
        }

        // Precondition: None
        // Postcondition: The textBox is tested to whether there is text entered, if there is not, an error
        // message is provided and the user cannot move on the next input 
         private void nameText_Validating(object sender, CancelEventArgs e)
        {
            string name = nameTextBox.Text; // value entered into nameTextBox

            if (string.IsNullOrWhiteSpace(name))
            {
                e.Cancel = true; // Stops focus changing process
                errorProvider1.SetError(nameTextBox, "Please enter a name.");
                nameTextBox.SelectAll();
            }
        }

        // Precondition: The nameTextBox data has been validated
        // Postcondition: Any error message that had previously appeared is erased and the user can move to the next input
        private void nameText_Validated(object sender, EventArgs e) 
        {
            errorProvider1.SetError(nameTextBox, "");
        }

        // Precondition: The address1TextBox data has been validated
        // Postcondition: Any error message that had previously appeared is erased and the user can move to the next input
        private void address1Text_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(addressLine1TextBox, "");
        }

        // Precondition: None
        // Postcondition: The textBox is tested to whether there is text entered, if there is not, an error
        // message is provided and the user cannot move on the next input 
        private void address1Text_Validating(object sender, CancelEventArgs e)
        {
            string addressLine1 = addressLine1TextBox.Text; // Value entered into addressLine1TextBox

            if (string.IsNullOrWhiteSpace(addressLine1))
            {
                e.Cancel = true;
                errorProvider1.SetError(addressLine1TextBox, "Please enter a valid address.");
                addressLine1TextBox.SelectAll();
            }
            
        }

        // Precondition: The cityTextBox data has been validated
        // Postcondition: Any error message that had previously appeared is erased and the user can move to the next input
        private void cityTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cityTextBox, "");
        }

        // Precondition: None
        // Postcondition: The textBox is tested to whether there is text entered, if there is not, an error
        // message is provided and the user cannot move on the next input
        private void cityTextBox_Validating(object sender, CancelEventArgs e)
        {
            string city = cityTextBox.Text;

            if (string.IsNullOrWhiteSpace(city))
            {
                e.Cancel = true;
                errorProvider1.SetError(cityTextBox, "Please enter a city name.");
                cityTextBox.SelectAll();
            }
        }

        // Precondition: The stateTextBox data has been validated
        // Postcondition: Any error message that had previously appeared is erased and the user can move to the next input
        private void stateComboBox_Validated(object sender, EventArgs e)
        {
            if (!stateComboBox.SelectedIndex.Equals(-1))
                errorProvider1.SetError(stateComboBox, "");
        }

        // Precondition: None
        // Postcondition: The comboBox is tested to see whether there is a state is chosen, if there is not an error message is provided 
        // and the user cannot move onto the next input
        private void stateComboBox_Validating(object sender, CancelEventArgs e)
        {
            string state = stateComboBox.SelectedIndex.ToString();

            if (stateComboBox.SelectedIndex.Equals(-1))
            {
                e.Cancel = true;
                errorProvider1.SetError(stateComboBox, "Please select a state.");

            }
        }

        // Precondition: The zipCodeTextBox data has been validated
        // Postcondition: Any error message that had previously appeared is erased and the user can move to the next input
        private void zipCodeTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(zipCodeTextBox, "");
        }

        // Precondition: None
        // Postcondition: The textBox is tested to whether there is text entered, if there is not, an error
        // message is provided and the user cannot move on the next input
        private void zipCodeTextBox_Validating(object sender, CancelEventArgs e)
        {
            int zipCode;

            if (string.IsNullOrWhiteSpace(zipCodeTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(zipCodeTextBox, "Zip Code must have a value entered.");
                zipCodeTextBox.SelectAll();
            }

            if (int.TryParse(zipCodeTextBox.Text, out zipCode))
            {
                if (zipCode < 00000 || zipCode > 99999)

                {
                    e.Cancel = true;
                    errorProvider1.SetError(zipCodeTextBox, "Zip Code must be between the values of 00000 and 99999.");
                    zipCodeTextBox.SelectAll();
                }
            }
        }

        // Precondition: Every other input has been validated
        // Postcondition: DialogResult is set to OK and is sent to the parent form
        private void addAddressButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Precondition: None
        // Postcondition: DialogResult is set to cancel and the user may cancel the form without entering in any data
        private void cancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            this.DialogResult = DialogResult.Cancel;
            
        }
    }
        
}
