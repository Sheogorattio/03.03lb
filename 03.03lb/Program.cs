using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03._03lb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            {
                Regex regex = new Regex(@"^(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
                Console.WriteLine("Enter IPv4");
                string ip = Console.ReadLine();
                if (regex.IsMatch(ip)) { Console.WriteLine("Correct"); }
                else { Console.WriteLine("Incorrecr"); }
            }
            #endregion
            #region task 2
            {
                Regex regex = new Regex("a|o|e|i|u|y", RegexOptions.IgnoreCase);
                Console.WriteLine("Enter text");
                string text = Console.ReadLine();
                Match m = regex.Match(text);
                int count = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (regex.IsMatch(text[i].ToString())) { count++; }
                }

                Console.WriteLine(count);
            }
            #endregion
            #region task 3
            {
                Regex regex = new Regex(@"^(http(s)?):\/\/(www\.)?\s{2,1000}\.[a-z]{2,6}");
                Console.WriteLine("Enter url");
                string url = Console.ReadLine();
                if (regex.IsMatch(url)) { Console.WriteLine("Correct"); }
                else { Console.WriteLine("Incorrect"); }
            }
            #endregion
            #region task 4
            {
                Regex regex = new Regex(@"\w{1,}");
                Console.WriteLine("Enter text");
                string text = Console.ReadLine();
                if (regex.IsMatch(text)) { Console.WriteLine("OK"); }
                else { Console.WriteLine("Error"); }
            }
            #endregion
            #region task 5
            {
                Regex regex = new Regex(@"^(([01][0-9])|([2][0-3])):[0-5][0-9](:[0-5][0-9])?$");
                Console.WriteLine("Enter time(h:m:s)");
                string time = Console.ReadLine();
                if (regex.IsMatch(time)) { Console.WriteLine("OK"); }
                else { Console.WriteLine("Error"); }
            }
            #endregion
            #region task 6
            {
                Regex regex = new Regex(@"^([1-9]{1})[0-9]{4}$");
                Console.WriteLine("Enter index");
                string index = Console.ReadLine();
                if(regex.IsMatch(index)) { Console.WriteLine("OK"); }
                else { Console.WriteLine("Error"); }
            }
            #endregion
            Console.Read();
        }
    }
}
