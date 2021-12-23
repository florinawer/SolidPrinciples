using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagLib.Models
{
    public class Market
    {
        public int MarketId { get; protected set; }


        /// <summary>
        /// Nombre
        /// </summary>
        public string Name { get; protected set; }


        public string Description { get; protected set; }

        public int CountryId {  get; protected set; }

        public Country Country { get; protected set; }


        public short TimeZone { get; protected set; }


        public int CurrencyId { get; protected set; }

        public Currency Currency { get; set; }


        public Market(int marketId, string name, string description, int countryId, short timeZone = 0)
        {
            MarketId = marketId;
            Name = name;
            Description = description;
            CountryId = countryId;
            TimeZone = timeZone;
        }
    }
}
