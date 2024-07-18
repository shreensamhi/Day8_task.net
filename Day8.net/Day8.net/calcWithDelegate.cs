using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.net
{
    public class Calculator<T>
    {
        public Func<T, T, T> Add { get; set; }
        public Func<T, T, T> Subtract { get; set; }
        public Func<T, T, T> Multiply { get; set; }
        public Func<T, T, T> Divide { get; set; }

        public Calculator()
        {
            Add = (x, y) => (dynamic)x + (dynamic)y;
            Subtract = (x, y) => (dynamic)x - (dynamic)y;
            Multiply = (x, y) => (dynamic)x * (dynamic)y;
            Divide = (x, y) =>
            {
                if ((dynamic)y == 0)
                    throw new DivideByZeroException("Cannot divide by zero.");
                return (dynamic)x / (dynamic)y;
            };
        }
    }
}
