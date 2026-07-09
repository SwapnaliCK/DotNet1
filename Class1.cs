using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet1
{
    internal class Class1
    {

        // Abstract Class
        class Animal
        {
            
            public  void Sound()
            {
                Console.WriteLine("Animal makes a sound");
            }

            // Normal Method
            public void Eat()
            {
                Console.WriteLine("Animal is Eating");
            }
        }

        class Dog : Animal
        {
            public void Run()
            {
                                Console.WriteLine("Dog is Running");
            }
        }
            
        


        //// Derived Class
        //class Dog : Animal
        //{
        //    public override void Sound()
        //    {
        //        Console.WriteLine("Dog Barks");
        //    }
        //}


        static void Main(string[] args)
            {
                Dog d = new Dog();

                 d.Sound();
                  d.Run();
                   d.Eat();
            Console.ReadLine();

            }
        }
    }







