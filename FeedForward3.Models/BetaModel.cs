using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedForward3.Models
{
    public class BetaModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public int Visits { get; set; }
        public int Price { get; set; }

        public BetaModel(int id, string title, string description, string companyName, int visits, int price)
        {
            Id = id;
            Title = title;
            Description = description;
            CompanyName = companyName;
            Visits = visits;
            Price = price;
        }
        public BetaModel() : this(0, "null", "null", "null", 0, 0)
        {
        }
    }
}
