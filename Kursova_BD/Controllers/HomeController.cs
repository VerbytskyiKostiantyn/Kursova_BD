using Kursova_BD.Models;
using Kursova_BD.Models.Tables;
using Kursova_BD.Models.ViewModels;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Kursova_BD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ShopDbContext _db;

        public HomeController(ILogger<HomeController> logger, ShopDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var model = _db.Categories.Include(q => q.Items).ToList();
            countOfOrder();
            
            
            return View(model);
        }

        public IActionResult Items(int categoryId, string categoryName)
        {
            var model = _db.Items.Where(i => i.CategoryId == categoryId).ToList();
            ItemsVM vm = new ItemsVM()
            {
                items = model,
                CategoryName = categoryName
            };
            countOfOrder();
            return View(vm);
        }

        [HttpPost]
        [Route("/orderItem/{id}/{quantity}")]
        public IActionResult Items(int id, int quantity)
        {
            var order = _db.Orders.Where(s => s.Status == "Active").FirstOrDefault();
            if (order == null)
            {
                var newOrder = new Order()
                {
                    DateOfOrder = DateTime.Now,
                    Status = "Active",
                    TotalOrderPrice = 0,
                    Items = new List<OrderItem>()
                };
                _db.Orders.Add(newOrder);
                order = newOrder;
            }
            _db.SaveChanges();

            var orderItem = new OrderItem()
            {
                ItemId = id,
                Item = _db.Items.FirstOrDefault(i => i.Id == id),
                OrderQuantity = quantity,
                OrderId = order.Id
            };
            orderItem.TotalPrice = orderItem.Item.Price * quantity;
            _db.OrderItems.Add(orderItem);

            order.Items.Add(orderItem);
            order.TotalOrderPrice = order.TotalOrderPrice + (orderItem.Item.Price * quantity);


            _db.Orders.Update(order);
            _db.SaveChanges();

            return Ok();
        }

        public IActionResult Cart()
        {
            countOfOrder();
            var model = _db.Orders.Where(s => s.Status == "Active").Include(d => d.Items).ThenInclude(i => i.Item).FirstOrDefault();
            
            return View(model);
        }

        [HttpPost]
        [Route("/finishOrder/{id}")]
        public IActionResult FinishOrder(int id)
        {
            var order = _db.Orders.FirstOrDefault(i => i.Id == id);
            order.Status = "Finished";
            _db.Orders.Update(order);
            _db.SaveChanges();
            return Ok();
        }

        [HttpPost]
        [Route("/updateQuantity/{id}/{signal}")]
        public IActionResult UpdateQuantity(int id, int signal)
        {
            var orderItem = _db.OrderItems.Include(i => i.Item).FirstOrDefault(i => i.Id == id);
            var order = _db.Orders.FirstOrDefault(i => i.Id == orderItem.OrderId);
            if (signal == 1)
            {
                orderItem.OrderQuantity++;
                orderItem.TotalPrice = orderItem.TotalPrice + orderItem.Item.Price;

                order.TotalOrderPrice = order.TotalOrderPrice + orderItem.Item.Price;
            }
            else
            {
                if (orderItem.OrderQuantity > 1)
                {
                    orderItem.OrderQuantity--;
                    orderItem.TotalPrice = orderItem.TotalPrice - orderItem.Item.Price;

                    order.TotalOrderPrice = order.TotalOrderPrice - orderItem.Item.Price;
                }
                else
                {
                    DeleteItemFromOrder(id);
                    return Ok();
                }
            }


            _db.OrderItems.Update(orderItem);
            _db.Orders.Update(order);
            _db.SaveChanges();

            return Ok();
        }




        [HttpPost]
        [Route("/deleteItemFromOrder/{id}")]
        public IActionResult DeleteItemFromOrder(int id)
        {
            var orderItem = _db.OrderItems.FirstOrDefault(i => i.Id == id);
            var order = _db.Orders.FirstOrDefault(i => i.Id == orderItem.OrderId);
            order.TotalOrderPrice = order.TotalOrderPrice - (orderItem.TotalPrice);

            _db.OrderItems.Remove(orderItem);

            if (order.Items.Count == 1)
            {
                _db.Orders.Remove(order);
                _db.SaveChanges();
                return Ok();
            }


            _db.Orders.Update(order);

            _db.SaveChanges();
            return Ok();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        private void countOfOrder()
        {
            var ord = _db.Orders.Where(s => s.Status == "Active").Include(d => d.Items).FirstOrDefault();


            if (ord != null)
            {
                
                ViewData["Count"] = ord.Items.Count;
            }
            else
            {
                ViewData["Count"] = 0;
            }
        }

    }
}
