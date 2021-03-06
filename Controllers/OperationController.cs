using LINQ.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LINQ.Controllers
{
    public class OperationController : Controller
    {
       
        EmployeeStructure employee = new EmployeeStructure();
        public ActionResult Index()
        {
            var employeeInfo = from x in employee.GetEmployeeList() select x;
            return View(employeeInfo);
        }

        
        public ActionResult Details(int id)
        {
            var getEmployeeDetail = employee.GetEmployeeList().Single(x => x.EmployeeID == id);
            return View(getEmployeeDetail);
        }

        public ActionResult Create()
        {
            return View();
        }

   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee collection)
        {
            try
            {
              
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

     
        public ActionResult Edit(int id)
        {
            var getEmployeeDetail = employee.GetEmployeeList().Single(x => x.EmployeeID == id);
            return View(getEmployeeDetail);
        }

        public IActionResult Sorting()
        {
            var sortList = employee.GetEmployeeList().OrderBy(x => x.Name).ToList();
            return View(sortList);
        }

        public IActionResult IdSorting()
        {
            var idSort = employee.GetEmployeeList().OrderBy(x => x.Department);
            return View(idSort);
        }

        public IActionResult AgeSorting()
        {
            var ageSort = employee.GetEmployeeList().OrderBy(x => x.Age).ToList();
            return View(ageSort);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee collection)
        {
            try
            {
                Employee updateList = employee.GetEmployeeList().Single(x => x.EmployeeID == id);
                updateList.EmployeeID = collection.EmployeeID;
                updateList.Name = collection.Name;
                updateList.Department = collection.Department;
                updateList.Age = collection.Age;
                return RedirectToAction("Index", "Operation");
            }
            catch
            {
                return View();
            }
        }

    
        public ActionResult Delete(int id)
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
