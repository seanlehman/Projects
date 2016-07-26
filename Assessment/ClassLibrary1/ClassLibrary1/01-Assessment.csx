using System;

// Part Zero 1.

int i = 0;
bool b = true;
string s = "A string";
double dbl = 7.69;
decimal d = 7.6m;


// Part Zero 2.

string Married(string s, decimal d)  //Signature - returns something
{
    return $"I have been married to {s} for {d} years.";
}

var s = "A String";
decimal d = 7.6m;

Console.WriteLine(Married(s, d));


// Part Zero 4.

var myArray = new string[3]; 
myArray[0] = "Jeff Sexton";
myArray[1] = "Jeff Simon";
myArray[2] = "Mark Lucas";

// Part Zero 5.

for (var x = 0; x < myArray.Length; x++)
{
    Console.WriteLine(myArray[x]);
}

//  Part Two  

public enum Gender { Unknown, Male, Female };

public class Customer
{
    public string _name;
    public Gender _gender;
    public string _purchase;
    
    public Customer(string name, Gender gender, string purchase)
    {
        _name = name;
        _gender = gender;
        _purchase = purchase;
    }

    public void thankYou()
    {
        Console.WriteLine($"Thank you {_name} for buying a {_purchase}!");
    }

    public void SendSaleNotice(string theDate)
    {
        Console.WriteLine($"Hello {_name}, We wanted to let you there's a sale coming up on {theDate}. ");
    }

    public void SendSaleNotice(string product, string theDate)
    {
        Console.WriteLine($"Hello {_name}, We wanted to let you there's a sale on {product} coming up on {theDate}. ");
    }

    public virtual void PrintCustomerInfo()
    {
        Console.WriteLine($"{_name} - {_purchase} - {_gender}");
    }
}

sealed class InactiveCustomer : Customer
{
    public enum notPurchasing { Irate, Moved, Uninterested };

    public int MonthsInactive;
    public notPurchasing _inactive;
        
    public InactiveCustomer(string name, Gender gender, string purchase, int monthsInactive, notPurchasing inactive) : base(name, gender, purchase)
    {
        MonthsInactive = monthsInactive;
        _inactive = inactive;
    }

    public void remindCustomer()
    {
        Console.WriteLine($"Thanks for shopping with us {_name}.  We saw that you purchased an {_purchase} from us {MonthsInactive} months ago.  We'd like to know if you'd like to take a look at some of our current deals.");
    }
    public override void PrintCustomerInfo()
    {
        Console.WriteLine($"{_name} - {_purchase} - {_gender} - {MonthsInactive}- {_inactive }");
    }
}



var cust = new Customer("Fred", Gender.Male, "car");

var dateTest = DateTime.Now.ToShortDateString();

cust.SendSaleNotice(dateTest);

var product = "Apple iPhones";

cust.SendSaleNotice(product, dateTest);

var oldCust = new InactiveCustomer("Fred", Gender.Male, "Apple iPhone", 4, InactiveCustomer.notPurchasing.Moved);

oldCust.remindCustomer();

var prnt = new Customer("Paul", Gender.Male, "Fender Jazz Bass Guitar");

prnt.PrintCustomerInfo();

var custInfo = new InactiveCustomer("Michael", Gender.Male, "desk", 4, InactiveCustomer.notPurchasing.Moved);

custInfo.PrintCustomerInfo();














