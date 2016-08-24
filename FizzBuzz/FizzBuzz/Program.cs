using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FBLibrary;
using System.Configuration;

namespace FizzBuzz
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// This method requires question number as an argument. Question configuration is defined in the App.Config file
        ///Question1, Question3, Question4, Question5, Question6     
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            String question = "";

            if (args.Length > 0)
            {
                question = args[0];
            }


            string[] strValue = ConfigurationManager.AppSettings[question.ToLower()].Split(',');


            FizzBuzzLib objFizBizzLib = new FizzBuzzLib();
            string strOutput = "";
            if (question.ToLower() == "Question6".ToLower())
                strOutput = objFizBizzLib.PrintDynamicText(strValue);
            else
                strOutput = objFizBizzLib.PrintText(strValue);

            Console.WriteLine("Output for " + question + " is:\n" + strOutput);

            Console.ReadLine();
        }
    }
}
