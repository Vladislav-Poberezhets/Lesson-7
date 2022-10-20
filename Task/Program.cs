namespace Lesson7
{
    class Program
    {
        static void Main()
        {
            
            
            Console.WriteLine("Enter the 1st line for comparison:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the 2nd line for comparison:");
            string str2 = Console.ReadLine();

            bool compare = Compare(str1, str2);
            Console.WriteLine(compare);

            Console.WriteLine("Enter a string for analysis:");
            string str3 = Console.ReadLine();
            Analyze(str3, out int letter, out int digits, out int separator);

            Console.WriteLine($"Quantity: \nLetters: {letter} \nSeparator: {separator} \nDigits: {digits} ");

            Console.WriteLine("Enter a string to sort by:");

            string str4 = Console.ReadLine();
            string sort = Sort(str4);
            Console.WriteLine(sort);


            Console.WriteLine("Enter a string to find a duplicate:");
            string str5 = Console.ReadLine();
            Console.WriteLine(Duplicate(str5));

            // Не зміг найти. Як повернути масив чарів в перемєнну. Щоб потім вивести їх почергово, а не строкою
        }




        static void Analyze(string str3, out int letter, out int digits, out int separator)
        {
            letter = 0; digits = 0; separator = 0;


            for (int i = 0; i < str3.Length; i++)
            {
                char.IsLetter(str3[i]);
                char.IsDigit(str3[i]);
                char.IsSeparator(str3[i]);
                if (char.IsLetter(str3[i]) == true)
                {
                    letter++;
                }
                if (char.IsDigit(str3[i]) == true)
                {
                    digits++;
                }

                if (char.IsSeparator(str3[i]) == true)
                {
                    separator++;
                }
            }



        }

        static string Sort(string str4)
        {
            char[] chars = str4.ToCharArray();
            Array.Sort(chars);
            return new String(chars);

        }


        static bool Compare(string str1, string str2)
        {
            if (str1 == str2)
            {
                return true;
            }
            else
                return false;

        }


        static char[] Duplicate(string input)
        {
            var groups = input.GroupBy(c => char.ToLower(c)).Where(g => g.Count() > 1).ToArray();

            var charArray = new char[groups.Count()];

            for (int i = 0; i < groups.Count(); i++)
            {
                charArray[i] = groups[i].Key;
            }

            return charArray;
        }
    }

}