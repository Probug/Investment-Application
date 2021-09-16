using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bitmoonfasttrade.Data;
using Bitmoonfasttrade.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Bitmoonfasttrade.Controllers 
{
     public class DepositController : Controller
  {
    // Declares the DbContext class
    private ApplicationDbContext _dataContext;
    private readonly UserManager< ApplicationUser> _userManager;

        // The instance of DbContext is passed via dependency injection
    public DepositController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
      this._dataContext=context;
      _userManager = userManager;
    }
   

        // GET: /<controller>/
        // Return the list of cars to the caller view
    public IActionResult Index()
    {

      return View();
    }

    public IActionResult Completed()
    {
      var transaction = _dataContext.Transaction
                    .Where(f => f.Status.Equals("Completed")) 
                    .Where(f => f.Type.Equals("Deposit"))           
                    .ToList();
      return View(transaction);
    }

    public IActionResult CreateBonus()
    {
      return View();
    }
    public IActionResult Pending()
    {
      var transaction = _dataContext.Transaction
                    .Where(f => f.Status.Equals("Pending"))
                    .Where(f => f.Type.Equals("Deposit"))            
                    .ToList();
      return View(transaction);
    }
    public IActionResult Transaction()
    { 
      var Id = _userManager.GetUserId(HttpContext.User);
      var transaction = _dataContext.Transaction
                    .Where(f => f.UserId.Equals(Id))            
                    .ToList();
      return View(transaction);
    }

    public IActionResult Create()
    {
      ViewBag.DateCreated = DateTime.UtcNow;
      var userID = _userManager.GetUserId(HttpContext.User);
      ViewBag.userEmail = _dataContext.Users
                     .Where(f => f.Id.Equals(userID))
                     .Select(u => u.Email)
                     .SingleOrDefault();
      
       ViewBag.userId = userID;
      return View();
    }

    public IActionResult _EditCompletedDeposit()
    {
      return View();
    }

    // Add a new object via a POST request
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Transactions transaction, Wallet wallet)
    {
      // If the data model is in a valid state ...
      if (ModelState.IsValid)
      {  
        //retrieve userId and User Email
        var userId = _userManager.GetUserId(HttpContext.User);
         var userEmail = _dataContext.Users
                     .Where(f => f.Id.Equals(userId))
                     .Select(u => u.Email)
                     .SingleOrDefault();

          var walletDetails = new Wallet(){
      
          UserID = userId,
          Email = userEmail,
      };
    
        //Insert User details to wallet
        _dataContext.Wallet.Add(walletDetails);

        // ... add the new object to the collection
        _dataContext.Transaction.Add(transaction);
        // Save changes and return to the Index method
        _dataContext.SaveChanges();
        return PartialView("Create");
        //return RedirectToAction("/Deposit/Create");
      }
      return PartialView("Create");
      //return Redirect("/Deposit/Create#modal-BTC");
      //return RedirectToAction("/Deposit/Create#modal-BTC");
    }
   
   // Get Bonus/Edit/Id?
       [HttpGet]
    public async Task <IActionResult> EditBonus(Guid? Id)
    {
      if (Id == null)
      {
          return NotFound();
      }

      var transactions = await _dataContext.Transaction.FindAsync(Id);
      if (transactions == null)
      {
          return NotFound();
      }
          return View("CreateBonus", transactions);
    }
   
    // Get Deposit/Edit/id?
    [HttpGet]
    public async Task <IActionResult> Edit(Guid? Id)
    {
      if (Id == null)
      {
          return NotFound();
      }

      var transactions = await _dataContext.Transaction.FindAsync(Id);
      if (transactions == null)
      {
          return NotFound();
      }
          return View("_EditCompletedDeposit", transactions);
    }

        
    [HttpPost]
    [ValidateAntiForgeryToken] 
    public ActionResult Edit(Guid Id, Transactions transaction)
    {

        if (Id != transaction.Id)
        {
            return NotFound();
        }
    
            // Use of lambda expression to access
            // particular record from a database
            var data = _dataContext.Transaction.FirstOrDefault(x => x.Id == Id); 
              
            // Checking if any such record exist 
            if (data != null) 
            {
                data.UserId = transaction.UserId;
                data.Type = transaction.Type;
                data.Bonus = transaction.Bonus;
                data.Amount = transaction.Amount;
                data.WalletAddress = transaction.WalletAddress;
                data.Coin = transaction.Coin;
                data.Status = transaction.Status;
                data.DateCompleted = transaction.DateCompleted;
                _dataContext.SaveChanges();
                TempData["msg"] = "Operation was successful";   
                // It will redirect to 
                // the Read method
                return RedirectToAction("Completed"); 
            }
            else
            return RedirectToAction("Edit");
    }
    public IActionResult Delete()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteCON(Guid Transactionid)
    {
      if (Transactionid == null)
      {
        return RedirectToAction("GetAll");
      }
      Transactions data = _dataContext.Transaction.Single(x => x.Id == Transactionid);
      if (data == null)
      {
        return RedirectToAction("GetAll");
      }
      return View(data);
    }
    // POST: Cars/Delete/5
    // Delete an object via a POST request
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(Guid Transactionid)
    {
      Transactions data = _dataContext.Transaction.FirstOrDefault(x => x.Id == Transactionid);
      // Remove the car from the collection and save changes

      if (data != null) {
      _dataContext.Transaction.Remove(data);
      _dataContext.SaveChanges();
      TempData["msg"] = "Operation was successful";
      return RedirectToAction("Completed");
      }
      else
      return View();
    }
  }
}
