using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritacne
{
  public class Animal
    {

        public string color = "Blue";
        //public Animal()
    }
  public class Dog:Animal
    {
        public string  color = "green";

        public void ShowColor()
        {
            Console.WriteLine($"The color of dog is {color}");
            Console.WriteLine($"The color of dog is {base.color}");

        }
    }
}
