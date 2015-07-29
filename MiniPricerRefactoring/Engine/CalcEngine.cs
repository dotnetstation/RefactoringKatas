using System;
using CalcService;

namespace MiniPricerRefactoring.Engine
{
    public class CalcEngine
    {

        public void Calculate(Prd p)
        {
            DateTimerManager.from = DateTime.Today;
            DateTimerManager.to = p.date;
            var nb = DateTimerManager.GetDays();
            double raise = 0;

            for (int i = 0; i < nb; i++)
                raise += p.price * p.param/100;

            if (p.date > DateTime.Today)
                p.isFuture = true;

            p.price = raise + (p.price*nb);
        }
    }
}
