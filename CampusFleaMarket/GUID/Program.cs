﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUID
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write(System.Guid.NewGuid().ToString());
            Console.Read();
        }
    }
}
