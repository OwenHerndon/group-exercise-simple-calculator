using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.StoredConstants
{
    public class StoredConstants
    {
        Dictionary<char, int> constantDictionary = new Dictionary<char, int>();

        // Used to test for values in Dictionary
        public void AddConstantsToDictionary()
        {
            constantDictionary.Add('a', 2);
            constantDictionary.Add('b', 1);
            constantDictionary.Add('c', 100);
        }

        /*  a side effect of using the .Add method is that it throws an error 
            if the key already exists, so we don't need a seperate method  
            checking if the key exist
        */
        public Dictionary<char, int> AddConstantsToDictionary(char userKey, int userValue)
        {
            try
            {
                constantDictionary.Add(userKey, userValue);
                return constantDictionary;
            }
            catch(Exception)
            {
                Console.WriteLine("Sorry that variable already exists");
                return constantDictionary;
            }
        }

        //public bool IsValueInDictionary(char inDictionary)
        //{
        //    if (constantDictionary.ContainsKey(inDictionary))
        //        return true;
        //    else
        //        return false;
        //}

        public void GetValueFromDictionary(char key)
        {
            if(constantDictionary.ContainsKey(key))
                Console.WriteLine($"The Value of {key} is {constantDictionary[key]}");
            else
                Console.WriteLine("That variable is not defined yet.");
        }
    }
}
