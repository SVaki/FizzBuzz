using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLibrary
{
    /// <summary>
    /// FizzBuzzLib allows users to pass configurations or mappings as arguments and the computation is done to display 
    /// appropriate string patterns. Any numbers divisible by a certain number to display a word pattern.
    /// For example, 3 for Fizz, 5 for Buzz etc..
    /// </summary>
    public class FizzBuzzLib
    {
        /// <summary>
        /// This method is to be used for displaying data being fed in this format
        /// value="Fizz,Buzz,3,5,1,1000"
        /// This is to be used for data configured in above format only - more static content for fixed mappings only
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public string PrintText(string[] strValue)
        {
            string strOutput = "";
            int min, max;
            min = int.Parse(strValue[4]);
            max = int.Parse(strValue[5]);
            for (int i = min; i <= max; i++)
            {
                string strTemp = "";
                if (i % int.Parse(strValue[2]) == 0)
                {
                    strOutput = strOutput + strValue[0];
                    strTemp = strOutput;
                }

                if (i % int.Parse(strValue[3]) == 0)
                {
                    strOutput += strValue[1];
                    strTemp = strOutput;
                }

                if (strTemp == "")
                {
                    strOutput = (strOutput + i.ToString()) + Environment.NewLine;
                }
                else
                    strOutput += Environment.NewLine;
            }
            return strOutput;
        }

        /// <summary>
        /// This method is to be used to print dynamic text based on user configuration. 
        /// Format for input = 3=FOO,5=BAR,7=BAZZ,11=BANANA,1,100 where the last two parameters
        /// define the range. In this example from 1 to 100, display FOO for numbers divisible by 3, display BAR for
        /// numbers divisble by 7
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns>Output array with a listed of printed values or text pattern</returns>
        public string PrintDynamicText(string[] strValue)
        {
            string strOutput = "";
            int min, max;
            min = int.Parse(strValue[strValue.Length - 2]);
            max = int.Parse(strValue[strValue.Length - 1]);

            for (int i = min; i <= max; i++)
            {
                string strTemp = "";
                foreach (string value in strValue)
                {
                    if (value.Contains('='))
                    {
                        String[] mapping = value.Split('=');
                        
                        if (i % int.Parse(mapping[0]) == 0)
                        {
                            strOutput = strOutput + mapping[1];
                            strTemp = strOutput;
                        }                        
                    }
                }
                if (strTemp == "")
                {
                    strOutput = (strOutput + i.ToString()) + Environment.NewLine;
                }
                else
                    strOutput += Environment.NewLine;
               
            }
            return strOutput;
        }
    }
}
