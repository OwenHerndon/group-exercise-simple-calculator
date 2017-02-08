using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using SimpleCalculator.StoredConstants;

namespace SimpleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            StoredConstants.StoredConstants constants = new StoredConstants.StoredConstants();

            while (true)
            {
                Console.WriteLine($"[{x}]>");
                // increment number of times using program
                x++;
                // user passed expression
                string input = Console.ReadLine();
                if (input.ToLower() == "quit" || input.ToLower() == "exit")
                {
                    Console.WriteLine("Bye!");
                    break;
                }

                // Regex for 1 + 1 or 1+1
                Regex r1 = new Regex(@"^(\d+)\s*([+-/%*])\s*(\d+)$");
                Match match1 = r1.Match(input);
                // Regex for a = 8 or a=8
                Regex r2 = new Regex(@"^([a-zA-Z])\s*=\s*(\d*)$");
                Match match2 = r2.Match(input);
                // Regex for x only
                Regex r3 = new Regex(@"^([a-zA-Z])$");
                Match match3 = r3.Match(input);

                // Check for single char a - Z
                if(match3.Success)
                {
                    char charEntered = Convert.ToChar(match3.Groups[1].Value.ToLower());
                    constants.GetValueFromDictionary(charEntered);
                }
                // Check for x = 1 or x=1
                else if (match2.Success)
                {
                    char charEntered = Convert.ToChar(match2.Groups[1].Value.ToLower());
                    int valEntered = Convert.ToInt32(match2.Groups[2].Value);
                    //Console.WriteLine($"charEntered={charEntered} valEntered={valEntered}");
                    constants.AddConstantsToDictionary(charEntered, valEntered);
                }
                // check for 1 + 2 or 1+2
                else if (match1.Success)
                {
                    string firstValue = match1.Groups[1].Value;
                    string operatorUsed = match1.Groups[2].Value;
                    string secondValue = match1.Groups[3].Value;
                    /*
                    Console.WriteLine("First value = {0}", firstValue);
                    Console.WriteLine("Operator =  {0}", operatorUsed);
                    Console.WriteLine("Second value =  {0}", secondValue);
                    */
                    EquationConverter conversion = new EquationConverter();
                    conversion.MathRouter(firstValue, operatorUsed, secondValue);
                }
                else
                {
                    Console.WriteLine("Please enter in the formatt of (1 + 1) or (1+1)");
                }
            }
        }
    }
}


