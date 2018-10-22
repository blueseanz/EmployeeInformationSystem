using BusinessLogicLayer;
using BusinessObjectLayer;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace API.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeBusinessLogic employeeObjBs;

        public EmployeeController()
        {
            employeeObjBs = new EmployeeBusinessLogic();
        }

        [ResponseType(typeof(IEnumerable<Employee>))]
        public IHttpActionResult Get()
        {
            return Ok(employeeObjBs.GetALL());
        }

        [ResponseType(typeof(Employee))]
        public IHttpActionResult Get(string id)
        {
            Employee employee = employeeObjBs.GetByID(id);
            if (employee != null)
                return Ok(employee);
            else
                return NotFound();
        }

        [ResponseType(typeof(Employee))]
        public IHttpActionResult Post(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeObjBs.Insert(employee);
                return CreatedAtRoute("DefaultApi", new { id = employee.EmployeeId }, employee);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [ResponseType(typeof(Employee))]
        public IHttpActionResult Put(string id, Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeObjBs.Update(employee);
                return Ok(employee);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [ResponseType(typeof(Employee))]
        public IHttpActionResult Delete(string id)
        {
            Employee employee = employeeObjBs.GetByID(id);
            if (employee != null)
            {
                employeeObjBs.Delete(id);
                return Ok(employee);
            }
            else
            {
                return NotFound();
            }

        }
    }
}
