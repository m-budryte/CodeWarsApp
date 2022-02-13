using System;

namespace CodeWarsApp
{
    public class ComplementaryDNAExercise
    {
        public static string MakeComplement(string dna)
        {
            string result = "";
            char[] letters = dna.ToCharArray();
            foreach (var letter in letters)
            {
                switch (letter)
                {
                    case 'A':
                        result += "T";
                        break;
                    case 'T':
                        result += "A";
                        break;
                    case 'G':
                        result += "C";
                        break;
                    case 'C':
                        result += "G";
                        break;
                }
            }
            
            return result;
        }
        
    }
}