using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text;
        List<string> paragraph = new List<string>();

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            while (true)
            {
                text = Console.ReadLine();
                int textLength = text.Length;

                if (text[textLength - 1] == '*')
                {
                    paragraph.Add(text);
                    text = string.Join("", paragraph.ToArray());
                    break;
                }
                else
                {
                    paragraph.Add(text);
                    continue;
                }
                
            }
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            try
            {
                string text;
                text = System.IO.File.ReadAllText(fileName);
                return text;
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be found.");
                Console.WriteLine("Re-enter file name and make sure the file is in the right location.");
                return null;
            }
            return null;
        }
    }
}
