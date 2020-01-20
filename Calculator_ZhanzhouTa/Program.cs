using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_ZhanzhouTa
{
    class Program
    {

        static void Main(string[] args)
        {
            Boolean c = true;
            decimal input1;
            decimal input2;
            String funct;
            while(c == true)
            {
                Console.WriteLine("Please input the First Number.");
                //validater the input
                input1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please select the Function + - * / .");
                funct = Console.ReadLine();
                Console.WriteLine("Please input the Second Number.");
                input2 = Convert.ToDecimal(Console.ReadLine());

                if (funct == "/"&& input2 == 0){
                    Console.WriteLine("Dividing by zero, pleae re-input the second number");
                    input2 = Convert.ToDecimal(Console.ReadLine());
                }

                getResault(funct,input1,input2);

                Console.WriteLine("Do you want continue? y/n");
                String ifContinue = Console.ReadLine();
                if(ifContinue == "n")
                {
                c=false;
                    break;
                }
                

            }
        }
        static void getResault( string funct,decimal input1,decimal input2)
        {
            decimal res = 0;
            string symble = "";
            switch (funct)
            {
                case "+":
                    res = input1+input2;
                    symble = "+";
                    break;
                case "-":
                    res = input1-input2;
                    symble = "-";
                    break;
                case "x":
                    res = input1*input2;
                    symble = "x";
                    break;
                case "/":
                    res = input1/input2;
                    symble = "/";
                    break;
            }
        Console.WriteLine("{0}{2}{1}={3}",input1,input2,symble,res);
        }    
    }
    
}
