﻿namespace OCP
{
    public class Invoice : IInvoice
    {
        public decimal Subtotal { get; set; }
        public decimal TaxRate { get; set; }       

        public decimal CalculateTax()
        {
            return Subtotal * TaxRate / 100;
        }

        public decimal CalculateTotal()
        {
            var result =  Subtotal + CalculateTax();

            return result;
        }
    }
}
