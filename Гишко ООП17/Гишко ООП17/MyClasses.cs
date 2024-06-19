using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Гишко_ООП17
{
    public abstract class Currency
    {
        public double Amount { get; set; }

        public Currency(double amount)
        {
            Amount = amount;
        }

        // Віртуальна функція для переведення в рублі
        public abstract void ToRubles();
    }

    public class Dollar : Currency
    {
        private const double ExchangeRateToRubles = 76.50; // Курс долара до рубля
        public double mon;

        public Dollar(double amount) : base(amount) { ToRubles(); }

        // Реалізація переведення в рублі
        public override void ToRubles()
        {
            mon = Amount * ExchangeRateToRubles;
        }

        public override string ToString()
        {
            return mon.ToString();
        }
    }

    public class Euro : Currency
    {
        private const double ExchangeRateToRubles = 82.10; // Курс євро до рубля
        public double mon;

        public Euro(double amount) : base(amount) { ToRubles(); }

        // Реалізація переведення в рублі
        public override void ToRubles()
        {
            mon = Amount * ExchangeRateToRubles;
        }

        // Реалізація виводу на екран
        public override string ToString()
        {
            return mon.ToString();
        }
    }
}
