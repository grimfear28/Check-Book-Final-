# Checkbook Keeper
![CP Inc](/Images/CPInc.png "CP Inc")

# Description

The Checkbook Keeper application allows a user to open up the app, and see a list of available fields to fill out. The pre-existing records for the Checkbook Keeper are shown as soon as it is opened. The user is allowed to enter an account name, account number, date, and amount.

If you experience any issues with a file path, you may need to adjust the path through the solution explorer by right-clicking the Checkbook application name and going to properties.

# Main Application Screen

This is the main screen of the Cheeckbook Keeper application that greets the user and provides all data in an instant from a database through the use of SQLite.

![Main Screen](/Images/MainForm.png "Main Screen")

# Main Activity Code

The MainActivity of the Checkbook Keeper contains most of the code for the application, where the database is created, a path is initialized, and the database data is shown to the user. The controls of the application are also declared within this activity.

![Main Activity 1](/Images/MainActivity1.png "Main Activity 1")
![Main Activity 2](/Images/MainActivity2.png "Main Activity 2")
![Main Activity 3](/Images/MainActivity3.png "Main Activity 3")
![Main Activity 4](/Images/MainActivity4.png "Main Activity 4")

# Checkbook Instance Info Class

The CheckbookInfoClass allows the user to send data from the MainActivity to here, passing the data into a constructor and then formatting it back to a string to store in the database.

![Class 1](/Images/Class1.png "Class 1")
![Class 2](/Images/Class2.png "Class 2")


