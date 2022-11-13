﻿
using _02_AluguelCarrosComInterface.Services;

namespace _01_AluguelCarrosSemInterface.Services
{
    internal class BrasilTaxService:ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
