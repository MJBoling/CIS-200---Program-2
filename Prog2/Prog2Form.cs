// Program 2
// Due Date: 10/23/2017
// CIS 200-01
// Grading ID: C6643
// The prog2Form acts as a GUI interface to the upv class. It has menu options that allow the user to 
// input new addresses and new letters. The user can then run reports on the addresses and parcels which will
// be displayed on the read-only textbox on the Prog2Form
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private UserParcelView upv; // The user parcel view

        public Prog2Form()
        {
            InitializeComponent();

            upv = new UserParcelView();

            upv.AddAddress("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                 "  Louisville   ", "  KY   ", 40202); // Test Address 1
            upv.AddAddress("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            upv.AddAddress("Mary Sue", "123 Muffin Man Lane",
                "Detroit", "MI", 48127); // Test Address 5
            upv.AddAddress("Donald Trump", "725 5th Avenue",
                "New York", "NY", 10022); // Test Address 6
            upv.AddAddress("Logan Payton", "123 Bellamy Circle", "Apt 204",
                "Louisville", "KY", 40208); // Test Address 7
            upv.AddAddress("Donna Noble", "9876 Doctor Lane",
                "Cardiff", "NY", 13084); // Test Address 8 

            // Test Parcels
            upv.AddLetter(upv.AddressAt(7), upv.AddressAt(0), 1.50m);
            upv.AddLetter(upv.AddressAt(2), upv.AddressAt(4), 1.70m);
            upv.AddGroundPackage(upv.AddressAt(5), upv.AddressAt(4), 20, 20, 20, 50);
            upv.AddGroundPackage(upv.AddressAt(1), upv.AddressAt(6), 30, 50, 10, 90.5);
            upv.AddNextDayAirPackage(upv.AddressAt(1), upv.AddressAt(3), 20, 20, 20, 80, 3.50m);
            upv.AddNextDayAirPackage(upv.AddressAt(5), upv.AddressAt(7), 5, 5, 5, 10, 1.5m);
            upv.AddTwoDayAirPackage(upv.AddressAt(1), upv.AddressAt(4), 50, 20, 50, 150, TwoDayAirPackage.Delivery.Early);
            upv.AddTwoDayAirPackage(upv.AddressAt(2), upv.AddressAt(3), 20, 20, 20, 75, TwoDayAirPackage.Delivery.Saver);
        }
        // Displays info about assignment
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Grading ID: C6643\n" +
                $"CIS 200-01\n" +
                $"Due Date: Oct 23, 2017");
        }
        // Exits the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prog2.AddressForm addressForm = new Prog2.AddressForm();    // Creates a modal dialogue box where user can input a new address
            DialogResult result;    // holds the result of the modal dialogue box -- OK or Cancel
            result = addressForm.ShowDialog();

            string name = addressForm.NameValue;                // holds the value of the name
            string addressLine1 = addressForm.Address1Value;    // holds address line 1
            string addressLine2 = addressForm.Address2Value;    // holds address line 2
            string city = addressForm.CityValue;                // holds the city value
            string state = addressForm.StateValue;              // holds the state value
            int zipCode = int.Parse(addressForm.ZipCodeValue);  // holds the zip code

            if (result == DialogResult.OK)
                upv.AddAddress(name, addressLine1, addressLine2, city, state, zipCode);
        }
        // Precondition: Addresses must be entered into the upv class either at the initialization of the program or
        // by adding it through the AddressForm
        // Postcondition: The addresses will be displayed in list format on the reportsTextBox on the Prog2Form
         private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder addresses = new StringBuilder();      // holds the addresses

            foreach (Address add in upv.AddressList)
            {
                addresses.Append(add.ToString());
                addresses.Append(Environment.NewLine);
                addresses.Append(Environment.NewLine);
                
            }
            reportsTextBox.Text = addresses.ToString();
        }

        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prog2.LetterForm letterForm = new Prog2.LetterForm(upv.AddressList);   // Creates a letter modal dialogue box where a new letter can be input
            DialogResult result;    // holds the result -- OK or Cancel
            result = letterForm.ShowDialog();

            int originAddress = letterForm.OriginAddressValue;              // holds the originAddress value
            int destinationAddress = letterForm.DestinationAddressValue;    // holds the destinationAddress value
            decimal fixedCost = letterForm.FixedCostValue;                  // holds the fixedCost value

            if (result == DialogResult.OK)
            {
                upv.AddLetter(upv.AddressAt(originAddress), upv.AddressAt(destinationAddress), fixedCost);
            }
        }
        // Precondition: Parcels must be added to the upv class either at initialization of the program or by adding in a letter through the LetterForm
        // Postcondition: The parcels will be displayed in a list format as well as the total cost of all the parcels
        private void parcelListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal totalCost = 0;                             // holds the total cost of the parcels
            StringBuilder parcels = new StringBuilder();       // holds the parcels from upv.ParcelList

            foreach (Parcel par in upv.ParcelList)
            {
                parcels.Append(par.ToString());
                parcels.Append(Environment.NewLine);
                parcels.Append(Environment.NewLine);
                totalCost += par.CalcCost();
               
            }
            reportsTextBox.Text = parcels.ToString() +
            "Total Cost: " + totalCost.ToString("c2");
        }

        
    }
}
