/* ***************************************************************************
 *
 * BRIEF //
 *   Your firm is implementing its student management prototype in Python.
 *   It's a command-line program, which the registrar's office will use to
 *   add students to the database upon enrollment.
 *
 *   The program should prompt the user for a student's 
 		first name; 
 		last name;
 *   	middle initial; 
 		physical address; 
 		email address; and 
 		phone number.
 *
 *   After each prompt, the program should wait for the user's input. 
 *
 *   Once the user has entered every piece of information, the program should
 *   print it all back to the console, and prompt the user to enter Y if the
 *   information is correct, or any other key otherwise.
 *
 *   For now, you should collect the user's response--i.e., y or otherwise--but
 *   don't worry about handling it. We'll get to that shorly.
 *
 ******************************************************************************/

using System;

class Program
{
	static void Main(string[] args)
	{
		Console.Write("What's your first name?");
		string firstName = System.Console.ReadLine();

		Console.Write("What's your middle initial?");
		string mInitial = System.Console.ReadLine();

		Console.Write("What's your last name?");
		string surname = System.Console.ReadLine();

		Console.Write("What's your address?");
		string address = System.Console.ReadLine();

		Console.Write("What's your email?");
		string email = System.Console.ReadLine();

		Console.Write("What's your phone number?");
		string phoneNumber = System.Console.ReadLine();

		Console.WriteLine("Your full name is " + firstName + " "+ mInitial + ". " + surname + ".");
		Console.WriteLine("You live here: " + address);
		Console.WriteLine("Your email is " + email + " and your phone number is " + phoneNumber + ".");
	}
}

// What function prints a message to the screen and waits for user input?
// Use it here to collect a student's information--first name, last name, etc.
// ***************************************************************************
// ...Your Code Here...

// Once you've gotten all of that, print it all back to the screen. 
// ***************************************************************************
// ...Your Code Here...

// Then, use the same function you used to prompt users for information to ask 
// them to confirm whether or not the information is correct. Save their 
// response, but don't worry about doing anything with it yet!
// ***************************************************************************
// ...Your Code Here...
