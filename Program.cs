//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            Console.WriteLine("1. Do you want to enter the text via the keyboard?");
            Console.WriteLine("2. Do you want to read in the text from a file?");
            Console.WriteLine("Enter '1' for option 1 or enter '2' for option 2.");

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input input = new Input();
            string choice;
            string inputText;
            string inputText2;

            while (true)
            {
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Option 1 selected.Write what you want to have analysed.");
                    inputText = input.manualTextInput();
                    break;
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Option 2 selected.\nEnter file name and location. Make sure to have '.txt' at the end of the file name.");
                    while(true)
                    {
                        inputText = input.fileTextInput(Console.ReadLine());
                        if (inputText == null)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                    break;
                    
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
            }

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            Analyse analyse = new Analyse();
            string analysedText = inputText;
            parameters = analyse.analyseText(inputText);

            //Receive a list of integers back

            List<int> parametersList = parameters;

            //Report the results of the analysis
            Report report = new Report();

            Console.WriteLine("1. Do you want to recieve your report via the console?");
            Console.WriteLine("2. Do you want to recieve your report via a new file?");

            while (true)
            {
                inputText2 = Console.ReadLine();
                if (inputText2 == "1")
                {
                    parametersList = report.OutPutConsole(parametersList);
                    break;
                }
                else if (inputText2 == "2")
                {
                    Console.WriteLine("Enter where the name of the new text file and where you want it saved.\nIf location isn't entered the report will be saved by the executable in the net6.0 folder.");
                    parametersList = report.OutPutFiles(parametersList);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
            }
            //TO ADD: Get the frequency of individual letters?
        }
    }
}