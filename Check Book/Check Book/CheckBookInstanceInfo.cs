using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Check_Book
{
    class CheckBookInstanceInfo
    {
        // Create the getters and setters for the required fields to be entered by the user
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string Date { get; set; }
        public string Amount { get; set; }

        public CheckBookInstanceInfo(string accName, string accNumber, string date, string amount)
        {
            // Pass in the values to the variables
            AccountName = accName;
            AccountNumber = accNumber;
            Date = date;
            Amount = amount;
        }

        // Empty for the connection to run without error when creating a new record
        public CheckBookInstanceInfo()
        {

        }

        // Output all the entered info on a single line
        public override string ToString()
        {
            return AccountName + " " + AccountNumber + " " + Date + " " + Amount;
        }
    }
}