using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //overloaded constructor = technique to create multiple constructors
            //                          with a diff set of parameters.
            //                           name + parameters = signature



            Pizza pizza = new Pizza("stffed crust", "red sauce", "mozarela", "pepporoni");


           

            Console.WriteLine();

           


            Console.ReadKey();

        }

    }
    class Pizza
    {

        String bread;
        String sauce;
        String cheese;
        String topping;


        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
            

        }

        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            
        }

        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }





    }
}






