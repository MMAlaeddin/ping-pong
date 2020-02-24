using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
       Console.WriteLine("Give Me a Number");
       string userStr = Console.ReadLine();
       int userInt = int.Parse(userStr);
       List<string> print = new List<string> {};
       for (int i = 0; i < userInt; i ++)
      {
       if(i%5 == 0 && i%3 == 0)
        {
          print.Add("ping-pong");
       }
        else if(i%3 == 0)
        {
        print.Add("ping");
       }
       else if(i%5 == 0)
        {
          print.Add("pong");
       }
       else
        {
          print.Add(i.ToString());
        }
        Console.WriteLine(print[i]);
    }
  }
}