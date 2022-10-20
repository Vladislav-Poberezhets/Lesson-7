

namespace Lesson8
{
    class Program
    {
        static void Main()
        {
            string str4 = Console.ReadLine();

            string str5 = Sort(str4);
            Console.WriteLine(str5);
        }
        static string Sort(string str4)
        {
            char[] chars = str4.ToCharArray();
            Array.Sort(chars);
            return new String(chars);

        }
    }
}
