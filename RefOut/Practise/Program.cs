﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{

    class Program
    {
        public static string GetNextNameByOut(out int id)
        {
            id = 5;
            string returnText = "Next-" + id.ToString();
            return returnText;
        }
        /*
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Previous value of integer i:" + i.ToString());
            string test = GetNextNameByOut(out i);
            Console.WriteLine("Current value of integer i:" + i.ToString());
            Console.Read();
        }*/
    }
}
