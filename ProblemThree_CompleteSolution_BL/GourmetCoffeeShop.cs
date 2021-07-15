using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetCoffeeShop : GourmetShop, ITaxCompute
    {
        public double TotalBillValue { get; set; }

        public override double PayPerPiece(int quantity)
        {

            return TotalBillValue;
        }
        public override double PayPerWeight(int weight)
        {

            return TotalBillValue;
        }

        public double TaxOnTotalBill()
        {
            return 0.05;
        }

        public GourmetCoffeeShop(int iCode, string iName, Dictionary<int, double> iPrice) : base(iCode, iName)
        {
            ItemPrice = iPrice;
        }
    }
}
