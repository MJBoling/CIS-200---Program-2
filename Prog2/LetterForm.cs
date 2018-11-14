// Program 2
// Due Date: 10/23/2017
// CIS 200-01
// Grading ID: C6643
// The LetterForm is a modal dialogue box where the user can inpt information for a new letter which will then be added 
// to the upv.ParcelList
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
    public partial class LetterForm : Form
    {
        internal List<Address> addressList;
        public LetterForm(List<Address> addresses)

        {
            InitializeComponent();
            addressList = addresses;

        }

        internal int OriginAddressValue
        {
            // Precondition: None
            // Postcondition: The SelectedIndex of the originAddress ComboBox is returned
            get { return originAddressCB.SelectedIndex; }

            // Precondition: The SelectedIndex of the originAddress ComboBox has been returned 
            // Postcondition: Value is set to the SelectedIndex 
            set { value = originAddressCB.SelectedIndex; }
        }

        internal int DestinationAddressValue
        {
            // Precondition: None
            // Postcondition: The SelectedIndex of the destinationAdd ComboBox is returned
            get { return destinationAddCB.SelectedIndex; }

            // Precondition: The SelectedIndex of the destinationAdd ComboBox has been returned 
            // Postcondition: Value is set to the SelectedIndex 
            set { value = destinationAddCB.SelectedIndex; }
        }

        internal decimal FixedCostValue
        {
            // Precondition: None
            // Postcondition: The value entered into the fixedCostTextBox has been parsed and returned
            get { return decimal.Parse(fixedCostTextBox.Text); }

            // Precondition: The value entered into the fixedCostTextBox has been parsed and returned
            // Postcondition: Value is set to the parsed value that was previously returned
            set { value = decimal.Parse(fixedCostTextBox.Text); }
        }

        // Precondition: A value in the originAddressCB has been chosen
        // Postcondition: Validation will be carried out. If there is no selection the user will
        // not be able to move onto the next selection and an error will appear
        private void originAddressCB_Validating(object sender, CancelEventArgs e)
        {
            if (originAddressCB.SelectedIndex < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(originAddressCB, "You must select an origin address.");
            }
        }

        // Precondition: The value selected has been validated
        // Postcondition: Any error message that has previously appeared disappears
        private void originAddressCB_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(originAddressCB, "");
        }

        // Items are added to the comboBoxes when the LetterForm loads
        private void LetterForm_Load(object sender, EventArgs e)
        {
            foreach (Address address in addressList)
            {
                originAddressCB.Items.Add(address.Name);
                destinationAddCB.Items.Add(address.Name);
            }
        }

        // Precondition: A value in the destinationAddCB has been chosen
        // Postcondition: Validation will be carried out. If there is no selection the user will
        // not be able to move onto the next selection and an error will appear
        private void destAddCB_Validating(object sender, CancelEventArgs e)
        {
            if (destinationAddCB.SelectedIndex < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(destinationAddCB, "You must select a destination address");
            }
            else if (destinationAddCB.SelectedIndex == originAddressCB.SelectedIndex)
            {
                e.Cancel = true;
                errorProvider1.SetError(destinationAddCB, "Destination address cannot be the same as origin address");
            }
        }

        // Precondition: The value selected has been validated
        // Postcondition: Any error message that has previously appeared disappears
        private void destAddCB_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(destinationAddCB, "");
        }

        // Precondition: The cancelButton is clicked with a left-mouse click
        // Postcondition: The DialogRestult is set to cancel and the user can exit the form without submitting any information
        private void cancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }

        // Precondition: A value has been entered into the fixedCostTextBox
        // Postcondition: Validation is carried out to make sure a value has been entered and that the value can
        // be parsed into a decimal. If the value is not validated then the user will not be able to add the letter
        // and an error message will be provided.
        private void fixedCostTextBox_Validating(object sender, CancelEventArgs e)
        {
            decimal fixedCost;

            if (String.IsNullOrWhiteSpace(fixedCostTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(fixedCostTextBox, "Value must be a valid non-negative number in the format #.##");
                fixedCostTextBox.SelectAll();
            }
            else if (decimal.TryParse(fixedCostTextBox.Text, out fixedCost))
            {
                if (fixedCost < 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(fixedCostTextBox, "Value be a non-negative number");
                    fixedCostTextBox.SelectAll();
                }
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(fixedCostTextBox, "Value must be a valid number in the format: #.##");
                fixedCostTextBox.SelectAll();
            }
        }

        // Precondition: The value entered into the fixedCostTextBox has been validated.
        // Postcondition: Any error that may have appeared now disappears and the user can go ahead and add the letter
        private void fixedCostTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(fixedCostTextBox, "");
        }

        // Precondition: All other information has been validated
        // Postcondition: The letter has been added the upv.Parcel list
        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
    }
}
