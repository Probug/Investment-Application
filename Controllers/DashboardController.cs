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
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;
        private ApplicationDbContext _dataContext;
        private readonly UserManager< ApplicationUser> _userManager;

        public DashboardController(ApplicationDbContext context, ILogger<DashboardController> logger, UserManager<ApplicationUser> userManager)
        {
            this._dataContext=context;
            _logger = logger;
             _userManager = userManager;
        }

        public IActionResult Index()
        {
            var UsserId= _userManager.GetUserId(HttpContext.User);

        //Get User Currently Invested
        ViewBag.invested = _dataContext.Transaction
                .Where(f => f.UserId.Equals(UsserId))
                .Where(f => f.Type.Equals("Deposit"))
                .Where(f => f.Status.Equals("Completed"))                      
                .Sum(f => f.Amount);
        
        //Get User Total Withdrawal       
        ViewBag.withdrawal = _dataContext.Transaction
                .Where(f => f.UserId.Equals(UsserId))
                .Where(f => f.Type.Equals("Withdrawal"))
                .Where(f => f.Status.Equals("Completed"))
                .Sum(f => f.Amount);

        //Get User Available Balance
        
        ViewBag.balance = _dataContext.Wallet
                .Where(f => f.UserID.Equals(UsserId))
                .Select(u => u.Balance)
                .FirstOrDefault();

        //Get User Bonus
        ViewBag.bonus = _dataContext.Transaction
                .Where(f => f.UserId.Equals(UsserId))
                .Sum(f => f.Bonus);

            return View();
        }
    }
}
