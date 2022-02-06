using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            if (Check(str) == true)
            {
                Console.WriteLine("скобки расставлены корректно");
            }
            else 
                Console.WriteLine("скобки расставлены некорректно");
            Console.ReadKey();

        }
        static bool Check(string str)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> task = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' },
            };
            foreach (char item in str)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    stack.Push(task[item]);
                }
                if (item == ')' || item == '}' || item == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != item)
                    {
                        return false;
                    }
                }

            }
            if (stack.Count == 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
