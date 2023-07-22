using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A13
{
    
    internal class Program
    {
        public static void CalculateFactorial(int num)
        {
            int prod = 1;
            Console.WriteLine($"Factorial of {num} is :");
            while (num != 0)
            {
                prod *= num;
                num = num - 1;
            }
            Console.WriteLine(prod);
        }
        static void Main(string[] args)
        {
            int task;
            char ch;
            do
            {
                Console.WriteLine("select the task you want to perform\n1.Helloworld\n2.Variables and input\n3.Basic arithmetic operations\n4.Control structures\n5.loops\n6.arrays\n7.Methods\n8.Exceptional handling ");
                task = int.Parse(Console.ReadLine());
                switch (task)
                {
                    case 1:
                        Console.WriteLine("\"Hello, World!\"");
                        break;
                    case 2:
                        string name;
                        Console.WriteLine("Enter the username");
                        name = Console.ReadLine();
                        Console.WriteLine("Hello, "+name+"!");
                        break;
                    case 3:
                        int a, b;
                        char q,op;
                        Console.WriteLine("Enter number 1");
                        a= int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2");
                        b = int.Parse(Console.ReadLine());
                        do {
                            Console.WriteLine("Select operation to perform\na.Addition\nb.subtraction\nc.Multiplication\nd.Divition\ne.Modulus");
                            op= char.Parse(Console.ReadLine());
                            switch(op)
                            {
                                case 'a':
                                    Console.WriteLine($"{a}+{b} = {a+b}");
                                    break;
                                case 'b':
                                    Console.WriteLine($"{a}-{b} = {a - b}");
                                    break;
                                case 'c':
                                    Console.WriteLine($"{a}*{b} = {a * b}");
                                    break;
                                case 'd':
                                    try
                                    {
                                        int res = a / b;
                                        Console.WriteLine($"{a}/{b} = {res} ");
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error !!!!!"+ex.Message);
                                    }
                                    break;
                                case 'e':
                                    Console.WriteLine($"{a}%{b} = {a % b}");
                                    break;
                                default:
                                    Console.WriteLine("Invalid operation");
                                    break;
                            }
                            Console.WriteLine("If you want to continue press y");
                            q= char.Parse(Console.ReadLine());
                        } while (q == 'y');
                        break;
                    case 4:
                        int num;
                        Console.WriteLine("Enter an integer");
                        num = int.Parse(Console.ReadLine());
                        if (num % 2 == 0)
                        {
                            Console.WriteLine($"{num} is even");
                        }
                        else
                        {
                            Console.WriteLine($"{num} is odd");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Printing numbers from 1 to 10 using for loop");
                        for(int i = 1; i <= 10; i++)
                        {
                            Console.Write(i+" ");
                        }
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        int[] arr = { 1, 2, 3, 4, 5 };
                        int sum=0;
                        double avg = 0;
                        foreach(int i in arr)
                        {
                            sum += i;
                        }
                        avg= sum/arr.Length;
                        Console.WriteLine("Sum of elements in array is : "+sum);
                        Console.WriteLine("Average of elements in arrar is : "+avg);
                        break;
                    case 7:
                        int n;
                       take: Console.WriteLine("Enter a number");
                        n = int.Parse(Console.ReadLine());
                        if (n <= 0)
                        {
                            Console.WriteLine("Enter positive number");
                            goto take;
                        }
                        else
                        {
                            CalculateFactorial(n);
                        }
                        break;
                    case 8:
                        int age;
                        input: Console.WriteLine("Enter age");
                        bool result=int.TryParse(Console.ReadLine(),out age);
                        if (!result)
                        {
                            Console.WriteLine("Error !!!!");
                            goto input;
                        }
                        if (age < 18)
                        {
                            Console.WriteLine("Person is minor");
                        }
                        else if(age>=18 && age <= 65)
                        {
                            Console.WriteLine("Person is adult");
                        }
                        else
                        {
                            Console.WriteLine("Person is Senior citizen");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid task"); break;

                }
                Console.WriteLine("If you want to continue press y ");
                ch=char.Parse(Console.ReadLine());
            } while (ch == 'y');
        }
    }
}
