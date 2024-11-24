using Kursova_BD.Models;
using Kursova_BD.Models.Tables;
using Kursova_BD.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace Kursova_BD.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ShopDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AdminController(ILogger<HomeController> logger, ShopDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _db = db;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            countOfOrder();
            return View();
        }
        public IActionResult Create()
        {
            countOfOrder();

            var categories = _db.Categories.ToList();

            var vm = new CreateEditVM()
            {
                Item = new Item(),
                Categories = categories
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(Item item, IFormFile file)
        {
            if (file != null)
            {
                    string uniqueFileName = $"{Guid.NewGuid()}_{file.FileName}";

                    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                    Directory.CreateDirectory(uploadsFolder);

                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyToAsync(fileStream);
                    }

                    item.ImagePath = $"/images/{uniqueFileName}";

                    _db.Items.Add(item);
                    _db.SaveChanges();
                    countOfOrder();
                    return RedirectToAction("Index");
            }
            var categories = _db.Categories.ToList();

            var vm = new CreateEditVM()
            {
                Item = item,
                Categories = categories
            };
            countOfOrder();
            return View(vm);
        }

        public IActionResult Edit(int id)
        {
            countOfOrder();

            var categories = _db.Categories.ToList();
            var item = _db.Items.FirstOrDefault(i => i.Id == id);

            var vm = new CreateEditVM()
            {
                Item = item,
                Categories = categories
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(Item item, IFormFile? imageFile)
        {

            try
            {
                var existingItem = _db.Items.FirstOrDefault(i => i.Id == item.Id);

                existingItem.Name = item.Name;
                existingItem.Price = item.Price;
                existingItem.CategoryId = item.CategoryId;

                if (imageFile != null)
                {
                    string uniqueFileName = $"{Guid.NewGuid()}_{imageFile.FileName}";
                    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                    Directory.CreateDirectory(uploadsFolder);

                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        imageFile.CopyToAsync(fileStream);
                    }

                    existingItem.ImagePath = $"/images/{uniqueFileName}";
                }

                _db.SaveChanges();
                countOfOrder();
                return RedirectToAction("Index");
            }
            catch
            {
                var categories = _db.Categories.ToList();

                var vm = new CreateEditVM()
                {
                    Item = item,
                    Categories = categories
                };
                countOfOrder();
                return View(vm);
            }
        }

        [HttpGet]
        [Route("/getAllItems")]
        public string GetAllItems()
        {
            var items = _db.Items.Include(c => c.Category).ToList();
            return JsonSerializer.Serialize(items);
        }

        [HttpPost]
        [Route("/deleteItem/{id}")]
        public IActionResult DeleteItem(int id)
        {
            var item = _db.Items.FirstOrDefault(i => i.Id == id);
            _db.Items.Remove(item);

            _db.SaveChanges();
            return Ok();
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
