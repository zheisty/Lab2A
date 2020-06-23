using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter Temperature in Celsius");
    var x = Console.ReadLine();

    int tempc = Convert.ToInt32(x);

    int tempf = (tempc * 9/5) +32;

  //Displaythe equivalent of celsius in farenheit
  Console.WriteLine ("Farenheit equivalent for " + tempc + " degrees celsius is " + tempf );

  //When temp in F is less than 32, then the following will display
  if (tempf < 32)
  {
    Console.WriteLine ("This temperature is below freezing of 32 degree Farenheit");
  }
  // When Temp in F is over 212, then the following will display
  if (tempf > 212)
  {
    Console.WriteLine ("This temperature is above boiling point of 212 degree Farenheit");

  }
  }
}