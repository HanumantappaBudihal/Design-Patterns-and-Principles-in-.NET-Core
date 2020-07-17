using Microsoft.AspNetCore.Mvc;
using Hexagonal.DesignPatterns.RepositoryDesingSample.Interfaces.Entities;
using Hexagonal.DesignPatterns.RepositoryDesingSample.Interfaces.Repository;

namespace Hexagonal.DesignPatterns.RepositoryDesingSample.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = _employeeRepository.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(IEmployee model)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.Insert(model);
                _employeeRepository.Save();
                return RedirectToAction("Index", "Employee");
            }
            return View();
        }

        [HttpGet]
        public ActionResult EditEmployee(int EmployeeId)
        {
            IEmployee model = _employeeRepository.GetById(EmployeeId);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditEmployee(IEmployee model)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.Update(model);
                _employeeRepository.Save();
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult DeleteEmployee(int EmployeeId)
        {
            IEmployee model = _employeeRepository.GetById(EmployeeId);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int EmployeeID)
        {
            _employeeRepository.Delete(EmployeeID);
            _employeeRepository.Save();
            return RedirectToAction("Index", "Employee");
        }
    }
}
