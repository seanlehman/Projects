var t1 = 123.GetType();  //Reports Integer
var t2 = "123".GetType();  //Reports String

var x = new System.Text.StringBuilder();
var t3 = x.GetType();

// Convert string to a number
var i1 = int.Parse("123");

// use to see if returning right format
int i1;
var success = int.TryParse("123", out i1);

// Convert numbr to string
// 123.ToString()

//
short sh = 32676;
byte by = 255;

// by = (short)by;

sh = (short)by;




