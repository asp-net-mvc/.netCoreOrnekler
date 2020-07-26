using manymany.Data;
using manymany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace manymany.Controllers.api
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CustomerController(ApplicationDbContext context)
        {
            _db = context;
        }
        // GET: api/values
        [HttpGet]
        public IActionResult get()
        {
            return Json(_db.customer.Include(x => x.supplier).ToList());
        }
        [HttpPost]
        public IActionResult post([FromBody] Customer _customer)
        {
            Customer dbCustomer = new Customer();

            dbCustomer.fullName = _customer.fullName;

            _db.customer.Add(dbCustomer);
            _db.SaveChanges();

            return Json(dbCustomer);
        }
        [Route("addsup")]
        [HttpPost("{id}/{supplierId}")]
        public IActionResult addSuplier(int id, int supplierId)
        {
            Customer dbCustomer = _db.customer.Where(x => x.id == id).Include(x => x.supplier).TagWith("Get post counts for blogs").First();
            Supplier dbSupplier = _db.supplier.Where(x => x.id == supplierId).First();

            dbCustomer.supplier.Add(new CustomerSupplier { suplier = dbSupplier });

          // _db.SaveChanges();

            return Json(dbCustomer);
        }
    }
}
