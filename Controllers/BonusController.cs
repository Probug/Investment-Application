using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bitmoonfasttrade.Models;
using Bitmoonfasttrade.Data;
using Microsoft.AspNetCore.Identity;

namespace Bitmoonfasttrade.Controllers
{
    public class BonusController : Controller
    {
        private readonly ILogger<BonusController> _logger;
        private ApplicationDbContext _dataContext;
        private readonly UserManager< ApplicationUser> _userManager;

        public BonusController(ApplicationDbContext context, ILogger<BonusController> logger, UserManager<ApplicationUser> userManager)
        {
            this._dataContext=context;
            _logger = logger;
             _userManager = userManager;
        }

        public IActionResult Index()
        {
            var UsserId= _userManager.GetUserId(HttpContext.User);

        //Get User Bonus
        ViewBag.balance = _dataContext.Transaction
                .Where(f => f.UserId.Equals(UsserId))
                .Sum(f => f.Bonus);
            return View();
        }
    }
}
