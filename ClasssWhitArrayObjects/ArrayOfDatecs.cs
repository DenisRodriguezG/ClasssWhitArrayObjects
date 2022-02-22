using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasssWhitArrayObjects
{
    internal class ArrayOfDatecs
    {
        ClassDate[] arrayDate;
        int max;
        int counter;

        public ArrayOfDatecs(int max)
        {
            this.max = max;
            counter = 0;
            arrayDate = new ClassDate[max];
        }
        public bool full()
        {
            return counter == max;
        }
        public void Insert()
        {
            Console.Write("How many dates do you want: ");
            int n = int.Parse(Console.ReadLine());

            if (n > max)
                Console.WriteLine("Sorry, n must less than max");
            else
            {
                if (full())
                    Console.WriteLine("Sorry, but the array of Dates is full");
                else
                {
                    
                    Console.Write("fill the array of Date out");
                    
                    for(int i = 0; i < n; i++)
                    {
                        ClassDate CD = new ClassDate();
                        CD.Insert();
                        arrayDate[counter++] = CD;
                    }
                    
                }
            }
        }
        public void Print()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            string aux = "";
            for (int i = 0; i < counter; i++)
                aux += arrayDate[i].ToString() + "\n";
            return aux;
        }
        public void menu()
        {
            int option;

            do
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("            MENU               ");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1.- Insert date");
                Console.WriteLine("2.- Show element of the array");
                Console.WriteLine("3.- Exit");

                Console.Write("Choose a option: ");
                option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        Insert();
                        break;
                    case 2:
                        Print();
                        break;
                    case 3:
                        Console.WriteLine("Thanks for visit us");
                        break;
                }
            } while (option != 3);
        }
    }
}
