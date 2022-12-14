using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Tracking_Interface_API.Context;
using Tracking_Interface_API.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tracking_Interface_API.Controllers
{
    public class TrackingController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _env;
        public TrackingController(DataContext context , IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            this._env = webHostEnvironment;
        }

        [HttpPost]
        public IActionResult TrackingOrder([FromBody] VSTArticleDutyPaidRemain VSTArticleDutyPaid)
        {

            var query = _context.VSTArticleDutyPaidRemains.ToList();
            if (VSTArticleDutyPaid.article_code != "" && VSTArticleDutyPaid.article_code != null)
            {
                query = query.Where(x => x.article_code == VSTArticleDutyPaid.article_code).ToList();
            }
            if (VSTArticleDutyPaid.article_code_duty_paid != "" && VSTArticleDutyPaid.article_code_duty_paid != null)
            {
                query = query.Where(y => y.article_code_duty_paid == VSTArticleDutyPaid.article_code_duty_paid).ToList();
            }
            return Ok(query);
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}

