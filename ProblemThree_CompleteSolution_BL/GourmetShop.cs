using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public abstract class GourmetShop
    {          
        public abstract double PayPerPiece(int quantity, string itemName);
        public abstract double PayPerWeight(int weight, string itemName);

        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        public Dictionary<int,Double> ItemPrice { get; set; }

        public GourmetShop(int iCode, string iName)
        {
            ItemCode = ItemCode;
            ItemName = ItemName;
        }

    }
}