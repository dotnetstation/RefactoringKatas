using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcService;
using MiniPricerRefactoring;

namespace Panama
{
    class Program
    {
        static void Main(string[] args)
        {
            double pr = 0;
            DateTime dt = new DateTime();
            bool notValid = true;
            double vo = 0;

            while (notValid)
            {
                Console.WriteLine("Enter your price");
                var p = Console.ReadLine();
                notValid = !double.TryParse(p, out pr);
                if (notValid)
                    ServiceLocator.Instance.Logger.Log(string.Format("The price {0} is not valid !", p));
            }

            notValid = true;
            while (notValid)
            {
                Console.WriteLine("Enter future date");
                var d = Console.ReadLine();
                notValid = !DateTime.TryParse(d, out dt);
                if (notValid)
                    ServiceLocator.Instance.Logger.Log(string.Format("The future date {0} is not valid !", d));
            }

            notValid = true;
            while (notValid)
            {
                Console.WriteLine("Enter volatility");
                var v = Console.ReadLine();
                notValid = !double.TryParse(v, out vo);
                if(notValid)
                    ServiceLocator.Instance.Logger.Log(string.Format("The vloatility {0} is not valid !", v));
            }

            var pro = new Prd() {date = dt, param = vo, price = pr};
            ServiceLocator.Instance.Calc.Calculate(pro);
            Console.WriteLine(pro.price);
        }
    }
}
