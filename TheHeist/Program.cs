using System;

namespace TheHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Plan Your Heist!");

      Console.WriteLine("Enter team member's name: ");
      var name = Console.ReadLine();

      Console.WriteLine("Enter " + name + "'s skill level: ");
      var skill = Int32.Parse(Console.ReadLine());

      if (skill < 0)
      {
        skill = 0;
      }

      Console.WriteLine("Enter " + name + "'s courage factor");
      var courage = Decimal.Parse(Console.ReadLine());

      if (courage < 0)
      {
        courage = 0m;
      }
      else if (courage > 2.0m)
      {
        courage = 2.0m;
      }

      Console.WriteLine("Team Member's name is " + name);
      Console.WriteLine(name + "'s skill level is " + skill);
      Console.WriteLine(name + "'s courage factor is " + courage);

    }
  }
}
