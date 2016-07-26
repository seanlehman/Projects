using System;
using System.Threading.Tasks; //

var d = new DateTime(2016, 7, 6);
var d2 = DateTime.Parse("2016-07-06T11:05:00");

var now = DateTime.Now;
var utcNow = DateTime.UtcNow;

var start = DateTime.Now;

Task.Delay(1000).Wait();// 1000 milliseconds

var end = DateTime.Now;

(end - start).TotalSeconds;

// end.ToString("r")

$"{end:r}"


