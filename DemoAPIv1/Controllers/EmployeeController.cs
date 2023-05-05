using DemoAPIv1.dao;
using DemoAPIv1.enties;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DemoAPIv1.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : Controller
    {
        [HttpGet]
        public ObjectResult GetAllUser()
        {
            EmployeeDao dao = new EmployeeDao();
            List<Employee> list = dao.getAllEmployes();
           
            return StatusCode((int)HttpStatusCode.OK, list);
        }


        [HttpPost]
        public ObjectResult createEmployee(Employee employee)
        {
            EmployeeDao dao = new EmployeeDao();
            Employee responseEmployee = dao.createEmployes(employee);

            return StatusCode((int)HttpStatusCode.OK, responseEmployee);

        }

    }
}
