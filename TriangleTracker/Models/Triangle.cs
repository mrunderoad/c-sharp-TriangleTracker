using System;

namespace Triangle
{
  public class TriangleTracker
  {

    // public bool IsEquilateral(int side1, int side2, int side3)
    // {
    //   if (side1 == side2 && side2 == side3 && side1 == side3)
    //   {
    //     return true;
    //   }
    //   else
    //   {
    //     return false;
    //   }
    // }

    // public bool IsIsosceles(int side1, int side2, int side3)
    // {
    //   if (side1 == side2 || side1 == side3 || side2 == side3)
    //   {
    //     return true;
    //   }
    //   else
    //   {
    //     return false;
    //   }
    // }

    // public bool IsScalene(int side1, int side2, int side3)
    // {
    //   if (side1 != side2 && side2 != side3 && side1 != side3)
    //   {
    //     return true;
    //   }
    //   else
    //   {
    //     return false;
    //   }
    // }

    // public bool IsNotTriangle(int side1, int side2, int side3)
    // {
    //   if (side1 > side2 + side3 || side2 > side1 + side3 || side3 > side1 + side2)
    //   {
    //     return true;
    //   }
    //   else
    //   {
    //     return false;
    //   }
    // }
    public static void Main()
    {
      Console.WriteLine("Enter side 1:");
      string sideOne = Console.ReadLine();
      int side1 = int.Parse(sideOne);

      Console.WriteLine("Enter side 2:");
      string sideTwo = Console.ReadLine();
      int side2 = int.Parse(sideTwo);

      Console.WriteLine("Enter side 3:");
      string sideThree = Console.ReadLine();
      int side3 = int.Parse(sideThree);
      IsTriangle(side1, side2, side3);
    }
    public static bool IsTriangle(int side1, int side2, int side3)
      {
      if (side1 > side2 + side3 || side2 > side1 + side3 || side3 > side1 + side2)
      {
        Console.WriteLine("Not a Triangle!");
        return false;
      }
      else if (side1 != side2 && side2 != side3 && side1 != side3)
      {
        Console.WriteLine("Is a Scalene Triangle!");
        return true;
      }
      else if (side1 == side2 || side1 == side3 || side2 == side3)
      {
        Console.WriteLine("Is an Isosceles Triangle!");
        return true;
      }
      else 
      {
        Console.WriteLine("Is an Equilateral Triangle!");
        return true;
      }
    }
  }
}