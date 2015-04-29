Author: Nicholas Muesch

The way I have been running the program is by opening the solution in Visual Studios 2010 and click the play button. I have run it in both Debug and Release Mode. The files "project4.xml" and "wishlist.xml" need to both be in the Debug or Release folder when running this way.

I believe the following problem is fixed so this shouldnt be necessary. I leave it here just in case.
One problem I have noticed when opening the solution on a new computer is that I have to open a class file and then in VS click on "Add Existing Item" under the "Project" tab. Then I add all classes to the project. I am not sure why this isn't happening automatically in the solution.

There is a preset login so that you can see the what changes about the UI when a user logs in. The Directory Panel changes and a button appears on the album specific page when a user is logged in. The credentials are as follows:
	username: username
	password: password


The main form is in the file Main Screen.vb
The Wishlist form is in Wishlist.vb
The Registration form is in Registration.vb
There are more files with code, theses are just the main forms

Known Problems
	This code does not let a user register a new account. The registration form appears when the user clicks "Register" but it will not do anything in that form. I have included the form regardless to display how it should look. 
	The user cannot login on an album page and see the "Add to wishlist button" The user needs to have logged prior to this page in order to see that button.
	Adding and removing albums to and from a wishlist are not currently available. I have described in my paper how those should work. Again, the buttons are included to show how the UI looks.
	If I had more time I would have liked to implement watermark text so that the user can see the format of the data they were supposed to input. Here are a few examples of that
	Date of Birth TextBox: MM DD YYYY
	Username TextBox: Enter username
	etc