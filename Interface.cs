using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet1
{
    interface IShape
    {
        void Draw();//method declare.

    }
    interface IShape2
    {
        void Colour();
    }
    interface IShape3
    {
        void Fill();
    }

    //when we apply single interface then no inheritance get applied , interface is for multiple inheritance i.e IShape, Ishape2 
    //class Square : IShape
    //{
    //    public void Draw()
    //    {
    //        Console.WriteLine("Drawing Circle");
    //    }
    //}

    class Pentagaon : IShape, IShape2, IShape3 //n number  of interfaces can be implemented in a single class

    {
        public void Draw()
        {
            Console.WriteLine("Drawing Pentagon");
        }
        public void Colour()
        {
            Console.WriteLine("Colouring Pentagon");
        }
        public void Fill()//method implementation
        {
            Console.WriteLine("Filling Pentagon");
        }
    }
    internal class Interface

    {
        static void Main(string[] args)
        {
            //Square c = new Square();
            //c.Draw();
           Pentagaon p = new Pentagaon();
            p.Draw();
            p.Colour();
            p.Fill();




        }
    }
}
