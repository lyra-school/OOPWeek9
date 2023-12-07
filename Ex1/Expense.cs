using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public enum Categories
    {
        Travel,
        Entertainment,
        Office
    }
    public class Expense
    {
        private decimal _amount;
        private DateTime _date;
        private Categories _category;

        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public Categories Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public Expense(decimal a, DateTime b, Categories c)
        {
            _amount = a;
            _date = b;
            _category = c;
        }

        public override string ToString()
        {
            return $"{Category} €{Amount} on {Date.ToShortDateString()}";
        }
    }
}
