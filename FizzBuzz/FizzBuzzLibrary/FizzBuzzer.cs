﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            if (input == 3) 
                return "Fizz";
            if (input == 5)
                return "Buzz";
            return input.ToString();
        }
    }
}
