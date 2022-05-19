using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompleteProject.Controllers
{
    public class TableChairController : Controller
    {
        private readonly DataRepo repo = new DataRepo();

        public IActionResult Index()
        {
            var model = repo.Bills.Include(x => x.Buyer).Include(x => x.Seller).Include(x => x.Shop).Include(x => x.Manufacturers).ToList();
            return View(model);
        }
        public IActionResult BuyerDetail(int id)
        {
            var model = repo.Buyers.SingleOrDefault(x => x.Id == id);
            return View(model);
        }
        public IActionResult SellerDetail(int id)
        {
            var model = repo.Sellers.SingleOrDefault(x => x.Id == id);
            return View(model);
        }
        public IActionResult ManDetail(int id)
        {
            var model = repo.Manufacturers.Include(x => x.Bills).SingleOrDefault(x => x.Id == id);
            return View(model);
        }
        public IActionResult ShopDetail(int id)
        {
            var model = repo.Shops.SingleOrDefault(x => x.Id == id);
            return View(model);
        }
    }
}
