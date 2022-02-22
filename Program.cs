using System;
using System.Collections.Generic;

namespace OOP_sem2_week3_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a game like Hangman in which a player guesses letters to try to replicate a hidden word. 
             * Store at least eight words in an array, and randomly select one to be the hidden word. 
             * Initially, display the hidden word using asterisks to represent each letter. 
             * Allow the user to guess letters to replace the asterisks in the hidden word until the user completes the entire word. 
             * If the user guesses a letter that is not in the hidden word, display an appropriate message. 
             * If the user guesses a letter that appears multiple times in the hidden word, make sure that each correct letter is placed.
            */
            String[] option = { "incompossible", "fungible", "xenodiagnosis", "cang", "demulcent", "univocalic", "demiurge", "algor", "jejune", "vendible" };
            String[] meaning = { "not mutually possible", "interchangeable", "diagnosis of disease by allowing laboratory-bred diseases to affect material",
                "wooden yoke hung around a criminal's neck", "emulsifier; something soothing", "having only one vowel", "creative spirit or entity", "coldness", "lacking interest or significance", "capable of being sold"};
            bool end = false;
            bool letterFlag = true;
            Random rnd = new Random();
           
            do
            {
                Console.WriteLine("Would you like to play? Y or N");
                string userInput = Console.ReadLine();
                if (userInput.Equals("N"))
                    {
                    break;
                    }
                
                int optionIndex = rnd.Next(10);
                
                String hidenWord = option[optionIndex];
                //Console.WriteLine(hidenWord);
               
                //change dictionary with an array in the same order
                Dictionary<char, bool> hidenLetters = new Dictionary<char, bool>();
                
                foreach(char letter in hidenWord)
                {
                    hidenLetters.Add(letter, false);
                }
           
                
                do
                {
                    Console.WriteLine("The hiden word is: ");
                    foreach (char letter in hidenWord)
                    {
                        if (hidenLetters[letter])
                        {
                            Console.Write(letter);
                        }else
                        {
                            Console.Write("-");
                            letterFlag = false;
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Input a leter of the hiden word");
                    char userLetter = char.ToLower((Console.ReadLine().ToCharArray()[0]));
                    foreach(char letter in hidenWord)
                    {
                        if (letter.Equals(userLetter))
                        {
                            hidenLetters[letter] = true;
                        }
                    }

                } while (letterFlag);
            } while (end);
            



        }

    }
}
