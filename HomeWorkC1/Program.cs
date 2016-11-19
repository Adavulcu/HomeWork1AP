using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENÜ");
            Console.WriteLine("___________");
            Console.WriteLine("1). Ters Faktöriyel");
            Console.WriteLine("2). Collatz döngüsü");
            Console.WriteLine("3). en uzun collatz");
            Console.WriteLine("4). Çıkış");
            do
            {
                try
                {

                    Console.Write("bir işlem seciniz:  ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 4)
                    {
                        Console.WriteLine("güle güle");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("*****************");
                        Console.Write("deger giriniz:  ");
                        int value = Convert.ToInt32(Console.ReadLine());

                        switch (input)
                        {
                            case 1:
                                faktoriel(value);
                                break;
                            case 2:
                                collatz(value);
                                break;
                            case 3:
                                longestCollatz(value);
                                break;
                            default:
                                Console.WriteLine("gecersiz giriş");
                                break;

                        }
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("bir deger giriniz");
                }
            } while (true);
        }
        public static void faktoriel(int val)
        {
            int temp = val;
            int counter = 2;
            while(true)
            {
                if (val % counter == 0)
                    val = val / counter;
                else
                {
                    Console.WriteLine(temp + "   faktöriyel degildir");
                    break;
                }
                if(val==1)
                {
                    Console.WriteLine(counter);
                    break;
                }
                counter++;
            }
        }
        public static void collatz(int val)
        {
            Console.Write(val+"\t");
            while(true)
            {
                if(val%2==0)
                {
                    val = val / 2;
                    Console.Write(val + "\t");
                }
                else
                {
                    val = 3 * val + 1;
                    Console.Write(val + "\t");
                }
                if (val == 1)
                {
                    Console.WriteLine();      
                    break;
                }

            }
        }
        public static void longestCollatz(int val)
        {
            int maxLoop = 0,tempMaxLoop=0;
            int counter = 1,value=0,temp;
           
            while (val > 0)
            {
                temp = val;
                while (true)
                {
                    if (val == 1)
                        break;
                    else if (temp% 2 == 0)
                    {
                        temp = temp / 2;
                        counter++;
                    }
                    else
                    {
                        temp= 3 * temp + 1;
                        counter++;
                    }
                    if (temp == 1)
                    {
                       
                        break;
                    }
                }
              
              
                tempMaxLoop = counter;
                counter = 1;
                if (tempMaxLoop > maxLoop)
                {
                    maxLoop = tempMaxLoop;
                    value = val;

                }
                tempMaxLoop = 0;
                val--;
            }
            Console.WriteLine("En cok döngü  :{0} , sayı  :{1}",maxLoop,value);
           
        }
        
    }
}
