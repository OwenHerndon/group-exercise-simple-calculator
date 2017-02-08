using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculator.Operations;

namespace SimpleCalculator
{
    public class EquationConverter
    {
        public string lastQ { get; set; }
        public int lastA { get; set; }

        //public void ConvertString(string a, string op, string b)
        //{
        //    int firstNumberInEquation = Convert.ToInt32(a);

        //    char operatorInEquation = Convert.ToChar(op);

        //    int secondNumberInEquation = Convert.ToInt32(b);

        //    MathRouter(firstNumberInEquation, operatorInEquation, secondNumberInEquation);
        //}

        public int MathRouter(string firstInt, string operatorChar, string secondInt)
        {
            int firstNumberInEquation = Convert.ToInt32(firstInt);
            char operatorInEquation = Convert.ToChar(operatorChar);
            int secondNumberInEquation = Convert.ToInt32(secondInt);

            int result = 0;
            if (operatorInEquation == '+')
            {
                AddNumber addnumber = new AddNumber();
                result = addnumber.AddStuff(firstNumberInEquation, secondNumberInEquation);
            }
            else if (operatorInEquation == '-')
            {
                SubtractNumber subtractnumber = new SubtractNumber();
                result = subtractnumber.SubtractStuff(firstNumberInEquation, secondNumberInEquation);
            }
            else if (operatorInEquation == '*')
            {
                MultiplyNumber multiplynumber = new MultiplyNumber();
                result = multiplynumber.MultiplyStuff(firstNumberInEquation, secondNumberInEquation);

            }
            else if (operatorInEquation == '/')
            {
                DivideNumber dividenumber = new DivideNumber();
                result = dividenumber.DivideStuff(firstNumberInEquation, secondNumberInEquation);
            }
            else if (operatorInEquation == '%')
            {
                ModulusizeNumber modulusizeNumber = new ModulusizeNumber();
                result = modulusizeNumber.ModulusizeStuff(firstNumberInEquation, secondNumberInEquation);
            }

            // Set the last answer field
            LastAnswer(result);
            // Set the last question 
            //LastQuestion($"{firstInt} {operatorChar} {secondInt}");
            DisplayAnswer(result, $"{firstInt} {operatorChar} {secondInt}");
            return result;
        }
        
        public int LastAnswer(int result)
        {
            lastA = result;
            //Console.WriteLine("lastA = {0}", lastA);
            return lastA;
        }

        public string LastQuestion(string question)
        {
            lastQ = question;
            //Console.WriteLine("lastQ = {0}", lastQ);
            return lastQ;
        }

        public void DisplayAnswer(int answer, string question)
        {
            Console.WriteLine($"{question} = {answer}");
        }
    }
}
