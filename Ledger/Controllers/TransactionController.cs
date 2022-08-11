using Ledger.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ledger.Controllers
{
    [Route("api/[controller]")]
    public class TransactionController : Controller
    {
        private readonly List<Transaction> transactions = new()
            {
                new Transaction()
                {
                    ProductID = Guid.Parse("ef29fc61-abcc-4ac1-9c8c-e5e17b266868"),
                    UserID = Guid.Parse("539bf338-e5de-4fc4-ac65-4a91324d8111"),
                    OccuredAt = DateTime.Now,
                    PriceAtPointInTime = 36,
                    Quantity = 5,
                    Total = 180
                },
                new Transaction()
                {
                    ProductID = Guid.Parse("d91d2019-e642-4b00-8b10-2bf07c383787"),
                    UserID = Guid.Parse("6b2c4788-e1d5-4ef4-8edf-e7d57e31bf4f"),
                    OccuredAt = DateTime.Now,
                    PriceAtPointInTime = 36,
                    Quantity = 5,
                    Total = 180
                }
            };

        [HttpGet]
        public List<Transaction> All()
        {
            return transactions;
        }

        [HttpGet("{id}")]
        public List<Transaction> GetByUserId(Guid id)
        {
            return transactions.Where(t => t.UserID == id)
                               .ToList();
        }
    }
}
