using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSytems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name; int pas = 0, tran = 0;
            String[] names = { "kim", "Chan", "Mony" };
            int[] pass = { 1221, 2331, 3109 };
            Double[] money = { 123, 431, 124 };
        systems: Console.WriteLine("\tWelcome To ATM");
            Sys:Console.Write("\t1.View Balance");
            Console.Write("\t2.Deposit");
            Console.Write("\n\t3.WithDrawal");
            Console.Write("\t4.E-Cash");
            Console.Write("\n\tInput Number To Start Transaction: ");
            int num = int.Parse(Console.ReadLine());
            if ((num<4)&&(num>0))
            {
                int n = 1;
                Console.Write("\tPlease Input Account Name: ");
                name = Console.ReadLine();
                password:Console.Write("\tPlease Input your Pin Code: ");
                pas = int.Parse(Console.ReadLine());
                Boolean br = false;
                double takout = 0; int  value = 0;
                for (int i = 0; i < names.Length; i++)
                {
                    if ( (names[i].Equals(name)) && (pass[i] == pas) )
                    {
                        br = true;
                        takout = money[i];
                        name.Equals(name[i]);
                        value = i;
                    }
                }
                if (br == false)
                {
                    Console.Clear();
                    Console.WriteLine("\tIncoreect Password");
                    if (n == 3) {
                        Console.Clear();
                        Console.WriteLine("\tYou have Banned Account Due To Incoreect Password 3 Three Time");
                        goto systems;
                    }
                    else {
                        n++;
                        goto password;
                        }
                }
                else
                {
                    switch (num)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("\tAccount Name:{0} ", name);
                            Console.WriteLine("\tYour Money In Balance = {0} $", takout.ToString("#,##.00"));
                            Console.Write("\tPress Number 1  for Back To System:");
                            tran = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (tran==1) goto Sys; else goto Sys;
                            break;
                        case 2:
                            double amount = 0, sum = 0;
                            Console.Write("\tEnter Amount You Want Deposit: ");
                            amount = int.Parse(Console.ReadLine());
                            amount += takout;
                            money[value] = amount;
                            Console.Clear();
                            goto systems;
                            break;
                        case 3:
                            int cashout;
                        back: Console.Write("\tEnter Amount Money You Want Cash Out :");
                            cashout = int.Parse(Console.ReadLine());
                            if (cashout > takout)
                            {
                                Console.Clear();
                                Console.WriteLine("\tYou Cant WithDrawl more Than Balance");
                                goto back;   
                            }
                            else
                            {
                                double cashut = takout - cashout;
                                Console.WriteLine("\tYou Have Cash Out Sucessufuly");
                                Console.WriteLine("\tNow You Balance Remain{0}$", cashut);
                                money[value] = cashut;
                                Console.Write("\tPress Number 1  for Back To System:");
                                tran = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if (tran.Equals(1)) goto systems; else goto systems;
                                Console.Clear();
                            }
                            break;
                    }
                }
            }
            else
            {
                int amount, cash = 0;
                double[] ecash = { 1000, 100, 500, 300 };
                int[] codeeca = { 123456, 456789, 788910, 899910 };
                Console.Clear();
                Console.WriteLine("\tWelcome E-Cash ");
            again: Console.Write("\tEnter Amount Money: ");
                amount = Convert.ToInt32(Console.ReadLine());
                Console.Write("\tEnter Code Number: ");
                cash = Convert.ToInt32(Console.ReadLine());
                Boolean ca = false;
                int j = 0;
                foreach(int i in codeeca ) {
                    if ((ecash[j] == amount)&&(codeeca[j] == cash)) {
                        Console.Clear();
                        Console.WriteLine("\tYou have Successfuly E-cash:{0}$\n\tPlease Take Your Money", ecash[j].ToString("###.00"));
                        goto Sys;
                    }
                    j++;
                }
                    if (j != 0)
                    Console.Clear(); 
                 Console.WriteLine("\tIncorrects Pin code Please try agin"); goto again;
            }
            Console.ReadKey();
        }
    }
}
