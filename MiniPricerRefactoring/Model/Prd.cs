using System;

namespace MiniPricerRefactoring.Model
{
    public class Prd
    {
        public Prd()
        {
            Id = new Guid();
            isFuture = false;
        }

        public Guid Id;
        public double price;
        public DateTime date;
        public double param;
        public bool isFuture;
    }
}
