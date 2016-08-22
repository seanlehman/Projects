using System.Text;

var firstName = "Sean";
var lastName = "Lehman";

// Concatenation

var s1 = firstName + " " + lastName;

// StringBuilder
var s2 =
    new StringBuilder().Append(firstName).Append(" ").Append(lastName).ToString();

// Format String
var s3 = string.Format("{0} {1}", firstName, lastName);

//String Interpolation
var s4 = $"{firstName} {lastName}";

//Using a function to combine two strings
public void name(string a, string b)
{
    Console.WriteLine("My first name is {0} and my last name is {1}.", a, b);
}
name("Sean", "Lehman");




