﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            StreamEditing streamEditing = new StreamEditing();
            streamEditing.FilterController();
            Console.ReadKey();
        }
    }
}
