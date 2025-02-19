﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnDelegate
{
    public class Calculator
    {
        //Declare Delegate
        public delegate int CalculatorDelegate(int x, int y);

        //Create Delegate Reference

        public CalculatorDelegate GetDelegateRef(int intoperation)
        {
            CalculatorDelegate delegateObj = null;
            //And Finally assign based on request
            switch (intoperation)
            {
                case 1:
                    delegateObj = Add;
                    break;
                case 2:
                    delegateObj = Sub;
                    break;
                case 3:
                    delegateObj = Multi;
                    break;
                case 4:
                    delegateObj = Div;
                    break;
                default: break;
            }
            return delegateObj;
        }

        private int Add(int a, int b) { return a + b; }
        private int Sub(int x, int y) { return x - y; }
        private int Multi(int x, int y) { return x * y; }
        private int Div(int x, int y) { return x / y; }

    }
}
