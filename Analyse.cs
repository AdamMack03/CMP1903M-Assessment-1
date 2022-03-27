using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<6; i++)
            {
                values.Add(0);
            }

            for (int i = 0; i < input.Length; i++)
            {
            //Counts sentences
                if (input[i] == '.' || input[i] == '!' || input[i] == '?')
                {
                    values[0]++;
                }
            //Counts vowels
                else if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                {
                    values[1]++;
                    values[3]++;
                    if (input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                    {
                        values[4]++;
                    }
                    else
                    {
                        values[5]++;
                    }
                }
            //Counts consonants
                else if (input[i] >= 'a' && input[i] <= 'z' || input[i] >= 'A' && input[i] <= 'Z')
                {
                    values[2]++;
                    values[3]++;

                    if (input[i] >= 'A' && input[i] <= 'Z')
                    {
                        values[4]++;
                    }
                    else
                    {
                        values[5]++;
                    }
                }
            }
            return values;
        }
    }
}
