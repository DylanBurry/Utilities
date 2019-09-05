using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class Utilities
{
    public static string ProcessText(string input)
    {
        int numbers = 0;
        int words = 0;
        //my code here
        //determine whetehr user has input a word or a number
        //return the string 'word' if the user enters a word
        //return the string 'number if user enters a number
        string[] splitInput = input.Split(' ');
        foreach (string stringPart in splitInput)
        {

            if (float.TryParse(stringPart, out float output)) 
            {
                numbers++;
            }
            else
            {
                words++;
            }
        }
        input = numbers.ToString() + " numbers " + words.ToString() + " words";
        return input;
    }
}
