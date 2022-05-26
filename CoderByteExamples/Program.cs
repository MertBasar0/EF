using System;
using System.Collections.Generic;

namespace CoderByteExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SearchingChallenge(Console.ReadLine()));
        }
        public static string SearchingChallenge(string str)
        {

            List<string> numbers = new List<string>();
            string cumulative = "";
            int result = 0;
            string _char = "";
            string _number = "";
            foreach (var item in str)
            {
                _char = item.ToString();
                for (int i = 0; i <= 9; i++)
                {
                    _number = i.ToString();
                    if (_char == _number)
                    {
                        cumulative += _number;
                    }
                    else
                    {
                        numbers.Add(cumulative);
                        cumulative = string.Empty;
                    }
                }
            }
            foreach (var item in numbers)
            {
                result += Convert.ToInt32(item);
            }
            return result.ToString();

        }
    }
}
