using System;

namespace ReverseAString
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			String str = "hello";
            String reverse = " ";
			for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str[i];
            }
            
			Console.WriteLine(reverse);
        }
    }
}
