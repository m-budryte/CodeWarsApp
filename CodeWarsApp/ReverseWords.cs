using System;
using System.Linq;

namespace CodeWarsApp
{
    public class ReverseWordsExercise
    {
        public static string ReverseWords(string thisIsAnExample)
        {
            var words = thisIsAnExample.Split(Convert.ToChar(" "));
            string result = "";
            
            foreach (string word in words)
            {
                char[] array = word.ToCharArray();
                Array.Reverse(array);
                
                if (result == "")
                {
                    result += new string(array);
                }
                else
                {
                    result += $" {new string(array)}";
                }
            }

            return result;
        }
    }
}