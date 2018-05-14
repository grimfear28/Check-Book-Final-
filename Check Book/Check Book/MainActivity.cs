using Android.App;
using Android.Widget;
using Android.Views;
using Android.Runtime;
using Android.Content;
using Android.OS;
using SQLite;
using System;
using System.IO;

namespace Check_Book
{
    [Activity(Label = "Checkbook Keeper", MainLauncher = true)]
    public class MainActivity : Activity
    {
        // Creation of path for the databse
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "checkBook4.db10");

        // Create local access to controls
        Button btnGo;
        public ProgressBar pb1;
        public EditText accName;
        public EditText Number;
        public EditText Date;
        public EditText Amount;

        public int counter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            btnGo = FindViewById<Button>(Resource.Id.btnAddCheck);
            pb1 = FindViewById<ProgressBar>(Resource.Id.progressBar1);
            accName = FindViewById<EditText>(Resource.Id.txtAccountName);
            Number = FindViewById<EditText>(Resource.Id.txtAccountNumber);
            Date = FindViewById<EditText>(Resource.Id.txtDate);
            Amount = FindViewById<EditText>(Resource.Id.txtAmount);
            TextView showText = FindViewById<TextView>(Resource.Id.showInfoText);

            // Allow access the the AddCheck button as btnAdd
            Button btnAdd = FindViewById<Button>(Resource.Id.btnAddCheck);

            // Connection to the database
            var db2 = new SQLiteConnection(dbPath);


            var table2 = db2.Table<CheckBookInstanceInfo>();

                    foreach (var item in table2)
                    {
                        // Display the database records
                        CheckBookInstanceInfo newInstance = new CheckBookInstanceInfo(item.AccountName, item.AccountNumber, item.Date, item.Amount);
                        showText.Text += newInstance + "\n";
                    }


            btnGo.Click += delegate
                {
                    if (accName.Text != string.Empty && Number.Text != string.Empty && Date.Text != string.Empty && Amount.Text != string.Empty && accName.Text.Length <= 20 && Number.Text.Length == 16)
                    {

                        //pb1.Visibility = Android.Views.ViewStates.Visible;
                       // pb1.Visibility = 0;

                        // Delay the event for 1 second
                        //System.Threading.Thread.Sleep(500);

                        //pb1.Visibility = ViewStates.Invisible;

                        //pb1.Visibility = Android.Views.ViewStates.Invisible;

                        // Clear the textview
                        showText.Text = string.Empty;

                        // Connection to the database
                        var db = new SQLiteConnection(dbPath);

                        // Create table
                        db.CreateTable<CheckBookInstanceInfo>();

                        // Create new object of the CheckBookInstanceInfo
                        CheckBookInstanceInfo newCheckBookInstanceInfo = new CheckBookInstanceInfo(accName.Text, Number.Text, Date.Text, Amount.Text);

                        // Store the info from the newCheckBookInstanceInfo into the database table
                        db.Insert(newCheckBookInstanceInfo);

                        counter = 0;
                    }
                    else
                    {
                        // Display an error message to the user
                        string message = "You must fill out all fields with valid info. Account Name permits a length of 20 and a Checking Number must be 16 digits in length. Please try again.";
                        Toast.MakeText(this, message, ToastLength.Long).Show();

                        // Increment the counter
                        counter = 1;
                    }
                };

            // Only connect with the database and display if the counter is equal to 0
            if (counter == 0)
            {
                Button getButton = FindViewById<Button>(Resource.Id.btnAddCheck);
                getButton.Click += delegate
                {
                    // Connect with the database through sqlite and use table as the variable connection
                    var db = new SQLiteConnection(dbPath);

                    var table = db.Table<CheckBookInstanceInfo>();

                    if (counter == 0)
                    {
                        if (showText.Text == string.Empty)
                        foreach (var item in table)
                        {
                            // Display the database records
                            CheckBookInstanceInfo newInstance = new CheckBookInstanceInfo(item.AccountName, item.AccountNumber, item.Date, item.Amount);
                            showText.Text += newInstance + "\n";
                        }
                        else
                        {
                            foreach (var item in table)
                            {
                                // Display the database records
                                CheckBookInstanceInfo newInstance = new CheckBookInstanceInfo(item.AccountName, item.AccountNumber, item.Date, item.Amount);
                                showText.Text += newInstance + "\n";
                            }
                        }
                    }
                };
            }
            else
            {
                // Clear the textview
                showText.Text = string.Empty;
            }
        }
    }
}