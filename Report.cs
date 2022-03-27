using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

        //Console out put
        public List<int> OutPutConsole(List<int>values)
        {
            Console.WriteLine("Number of sentences - {0}\nNumber of vowels - {1}\nNumber of consonants - {2}\nNumber of Characters - {3}\nNumber of upper case letters - {4}\nNumber of lower case letters - {5}", values[0], values[1], values[2], values[3], values[4], values[5]);
            return null;
        }

        //File out put
        public List<int> OutPutFiles(List<int>values)
        {
            string path;
            
            path = Console.ReadLine();
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Number of sentences - {0}\nNumber of vowels - {1}\nNumber of consonants - {2}\nNumber of Characters - {3}\nNumber of upper case letters - {4}\nNumber of lower case letters - {5}", values[0], values[1], values[2], values[3], values[4], values[5]);
                    return null;
                }
        }
    }
}
