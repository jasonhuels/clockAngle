using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter a time of day: ");
    string timeString = Console.ReadLine();
    string temp = timeString.Remove(timeString.IndexOf(':'), 1);
    int time = int.Parse(temp);
    int hours = time / 100;
    int minutes = time - (hours*100);
    Console.WriteLine(hours.ToString() + " " + minutes.ToString());
    timeAngle(hours, minutes);
  }

  static void timeAngle(int hours, int minutes) {
    int degree;
    int minuteDegree = minutes * 6;
    int hourDegree = hours * 30;
    hourDegree = hourDegree + minutes / 2;
    if(hourDegree > minuteDegree){
      degree = hourDegree - minuteDegree;
    } else {
      degree = minuteDegree - hourDegree;
    }
    if(degree > 180) {
      Console.WriteLine(360 - degree);
    } else {
      Console.WriteLine(degree);
    }
  }
}
