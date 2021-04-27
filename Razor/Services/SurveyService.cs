using Razor.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor.Services
{
    public class SurveyService : ISurveyService
    {
        private List<SurveyProduct> products { get; set; }

        public List<SurveyProduct> GetSurveyProducts()
        {
            products = new List<SurveyProduct>()
            {
                new SurveyProduct() { Id = 1, Name = "Hoodies", VoteCount = 8 },
                new SurveyProduct() { Id = 2, Name = "Banners", VoteCount = 1 },
                new SurveyProduct() { Id = 3, Name = "Posters", VoteCount = 4 },
                new SurveyProduct() { Id = 4, Name = "T-Shits", VoteCount = 2 },

            };

            return products;
        }

        public void IncreaseVoteCount(int productId)
        {
            products.FirstOrDefault(u => u.Id == productId).VoteCount += 1;
        }
    }
}
