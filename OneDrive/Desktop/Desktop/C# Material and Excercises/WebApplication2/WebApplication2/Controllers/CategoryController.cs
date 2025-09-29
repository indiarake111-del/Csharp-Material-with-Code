using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CategoryController : Controller
    {
        //initialise the database context
        private readonly ApplicationDbContext _db;
        //create a constructor to inject the database context
        //dependency injection for the database context
        //constructor to inject the database context
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List <Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        // Create the table
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            //if(obj.Name == obj.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the name");
            //}
            //custom error message
            //if(obj.Name!= null && obj.Name.ToLower() == "test")
            //{
            //    ModelState.AddModelError("", "Test is an invalid Data");
            //}
            if (ModelState.IsValid)
            { 
           _db.Categories.Add(obj);
           _db.SaveChanges();
            TempData["success"] = "category Created Successfully";
            return RedirectToAction("Index");
            }
            return View();
        }

        // Update the table
        public IActionResult Edit(int? id)
        {
            if (id==null || id==0) 
            {
                return NotFound();
            }

            Category? categoryFromDb = _db.Categories.Find(id);
            if (categoryFromDb==null)
            {
                return NotFound();
            }
                return View(categoryFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "category updated Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

       
        //Delete Table Data
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? categoryFromDb = _db.Categories.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        //We are explicitly say that this end point action name is delete, even though we have a different name
        [HttpPost, ActionName("Delete")]
        // We can not use delete again because bothe name and parameter going to be same.
           public IActionResult DeletePOST(int? id)
           {
            Category? obj = _db.Categories.Find(id);

            if (obj==null)
            {
                return NotFound();
            }
               _db.Categories.Remove(obj);
                _db.SaveChanges();
            TempData["success"] = "category Deleted Successfully";
            return RedirectToAction("Index");
                      
        }

    }
}
