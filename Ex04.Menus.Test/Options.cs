using System;


namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;
    using Ex04.Menus.Delegates;

    public class Options
    {
        public class Date : IAction
        {
            public void Do()
            {
                Console.WriteLine(DateTime.Now.Date.ToString());
            }
        }

        public class Time : IAction
        {
            public void Do()
            {
                Console.WriteLine(DateTime.Now.TimeOfDay.ToString());
            }
        }

        public class CountCapitals : IAction
        {
            public void Do()
            {
                Console.WriteLine("Please write a sentence: ");
                string answer = Console.ReadLine();
                Console.WriteLine("Number of Capital Letters is: {0}", numberOfCapitalLetters(answer));
            }

            private int numberOfCapitalLetters(string i_String)
            {
                int count = 0;
                for (int i = 0; i < i_String.Length; i++)
                {
                    if (char.IsUpper(i_String[i])) count++;
                }
                return count;
            }
        }

        public class ShowVersion : IAction
        {
            public void Do()
            {
                Console.WriteLine("Version: 18.2.4.0");
            }
        }
    }
}
