using Gulf_Logistics.DAL;
using Gulf_Logistics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gulf_Logistics.Controllers
{
    public class LogisticController : Controller
    {
        public readonly OrderDal _orderdal;

        public LogisticController(OrderDal orderdal)
        { 
          _orderdal = orderdal;
        }
        public IActionResult Home()
        {

            _orderdal.GetOrderList();
            return View();
        }

        public IActionResult Order(IEnumerable<Orders> orders)
        {
            return View(orders);
        }
    }
}
