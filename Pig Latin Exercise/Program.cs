using System;

namespace Pig_Latin_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pig Latin Translator!");
            bool program = true;
            while (program == true)
            {
                //take user input for word and convert to lowercase
                Console.WriteLine("Please type in a word!");
                string word = Console.ReadLine().ToLower();
                Console.WriteLine(PigLatin(word));
                Console.WriteLine("Would you like to type in another word? y/n?");

                //break loop if they choose not to enter another word
                string keepGoing = Console.ReadLine().ToLower();
                if (keepGoing == "y")
                {
                    program = true;
                }
                else
                {
                    program = false;
                }

            }
        }

        //method for finding out if the word starts with a vowel or consonant
        public static string PigLatin(string translate)
        {
            string addWay = "way";
            string addAy = "ay";
            char[] vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };

            //starts with a vowel
            foreach (char x in vowel)
            {
                if (translate[0] == x)
                {
                    return translate + addWay;
                }
            }

            //starts with a consonant, cycle to find first vowel
            string piggy = translate.Substring(translate.IndexOfAny(vowel));
            string bacon = translate.Substring(0, translate.IndexOfAny(vowel));
            return piggy + bacon + addAy;
        }
    }
}

