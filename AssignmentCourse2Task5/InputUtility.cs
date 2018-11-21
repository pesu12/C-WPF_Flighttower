//InputUtility.cs
//By: Per Sundberg 2018-02-25.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCourse2Task5
{
    class InputUtility
    {
        ///<summary>
        ///Method that converts string to integer.
        ///</summary>
        public static int ConvertToInteger(string input)
        {
            int output;
            if (int.TryParse(input, out output))
                return output;
            else
                output = -1;
            return output;
        }

        ///<summary>
        ///Method that converts string to double.
        ///</summary>
        public static double ConvertToDouble(string input)
        {
            double output;
            if (double.TryParse(input, out output))
                return output;
            else
                output = -1;
            return output;
        }
    }
}
