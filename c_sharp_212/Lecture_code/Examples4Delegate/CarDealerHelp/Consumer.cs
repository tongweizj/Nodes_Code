﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerHelp
{
    public class Consumer
    {
        private string _name;

        public Consumer(string name) => _name = name;

        public void NewCarIsHere(object sender, CarInfoEventArgs e)
        {
            Console.WriteLine($"{_name}: new {e.Car} is available now");
        }
    }
}
