using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstProject_N000000.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET api/HostingCost/{id} -> "{id} fortnights at $5.50/FN = $5.50 CAD"
        //                          -> "HST 13% = $0.72 CAD"
        //                          -> "Total = $6.22 CAD"
        public IEnumerable<string> Get(int id)
        {
            double fortnights = id / 14;
            double unroundedFortnightsCost = 5.50 + (5.50 * fortnights);
            double fortnightsCost = unroundedFortnightsCost;
            double unroundedTaxRate = fortnightsCost * 0.13;
            double taxRate = Math.Round(unroundedTaxRate, 2);
            double totalPrice = fortnightsCost + taxRate;

            if (fortnights < 1)
            {
                return new string[] { fortnights + " fortnights at $5.50/FN = $" + fortnightsCost + " CAD", "HST 13% = $" + taxRate + " CAD", "Total = $" + totalPrice + " CAD" };
            }
            else
            {
                return new string[] { fortnights + " fortnights at $5.50/FN = $" + fortnightsCost, "HST 13% = $" + taxRate + " CAD", "Total = $" + totalPrice + " CAD" };
            }
            
          
            
        }

        // 0 - 13 || 0 fortnights = $5.50
        // 14 - 27 || 1 fortnight = $11 CAD
        // 28 + || 2 fortnights = $16.50
    }
}
