using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bitmoonfasttrade.Data;
using Bitmoonfasttrade.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Bitmoonfasttrade.Controllers 
{
     public class WithdrawalController : Controller
  {
    private ApplicationDbContext _dataContext;
    private readonly UserManager< ApplicationUser> _userManager;

        // The instance of DbContext is passed via dependency injection
    public WithdrawalController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
      this._dataContext=context;
      _userManager = userManager;
    }

    // GET: /<controller>/
    // Return the list of cars to the caller view
    public IActionResult Index()
    { 
        //get User ID
        
        var UsserId= _userManager.GetUserId(HttpContext.User);
        ViewBag.userId = UsserId;

        //Get User Email
        ViewBag.userEmail = _dataContext.Users
                .Where(f => f.Id.Equals(UsserId))
                .Select(u => u.Email)
                .SingleOrDefault();

        //Get User Total Withdrawal
        
        ViewBag.balance = _dataContext.Wallet
                .Where(f => f.UserID.Equals(UsserId))
                .Select(u => u.Balance)
                .SingleOrDefault();

        //Get User Available Balance
        
        ViewBag.balance = _dataContext.Wallet
                .Where(f => f.UserID.Equals(UsserId))
                .Select(u => u.Balance)
                .SingleOrDefault();

        //Get current date
        ViewBag.DateCreated = DateTime.UtcNow;
        return View();
    }
    public IActionResult Create()
    {
      return View();
    }

    public IActionResult _EditCompletedWithdrawal()
    {
      return View();
    }

    public IActionResult Pending()
    {
        var transaction = _dataContext.Transaction
            .Where(f => f.Status.Equals("Pending")) 
            .Where(f => f.Type.Equals("Withdrawal"))                       
            .ToList();
        return View(transaction);
    }
        public IActionResult Completed()
    {
        var transaction = _dataContext.Transaction
            .Where(f => f.Status.Equals("Completed")) 
            .Where(f => f.Type.Equals("Withdrawal"))           
            .ToList();
      return View(transaction);
    }

    // Add a new object via a POST request
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Transactions transaction)
    {
      // If the data model is in a valid state ...
      if (ModelState.IsValid)
      {
                //  // ... add the new object to the collection
        //  _dataContext.Transaction.Add(transaction);
        // // // Save changes and return to the Index method
        //  _dataContext.SaveChanges();
        //  TempData["msg"] = "Operation was successful";

        //  return View("Index");

         var amt = transaction.Amount;

        //get userID
        var Id = _userManager.GetUserId(HttpContext.User);
        //get Wallet Balance
        var balance = _dataContext.Wallet
                     .Where(f => f.UserID.Equals(Id))
                     .Select(u => u.Balance)
                     .SingleOrDefault(); 
                
        //Compare Amount to balance
        if(amt >= balance)
        {
        // ... add the new object to the collection
        _dataContext.Transaction.Add(transaction);
        // Save changes and return to the Index method
        _dataContext.SaveChanges();
        TempData["msg"] = "Operation was successful";
        return View(); 
        }
        else
        {
        TempData["msg"] = "Insufficient Fund";
        return View();
         }
      }
       return RedirectToAction("Index");
      //return View("Index");
    }
    public async Task<IActionResult> Edit(Guid? Id)
    {
      if (Id == null)
      {
          return NotFound();
      }

      var transaction = await _dataContext.Transaction.FindAsync(Id);
      if (transaction == null)
      {
          return NotFound();
      }
        //var transaction = _dataContext.Transaction.Where(x => x.Id == Id).SingleOrDefault();
        return View("_EditCompletedWithdrawal", transaction);
    }
        
    [HttpPost]
    [ValidateAntiForgeryToken] 
    public ActionResult Edit(Guid? Id, Transactions transaction)
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
                data.Amount = transaction.Amount;
                data.WalletAddress = transaction.WalletAddress;
                data.Coin = transaction.Coin;
                data.Status = transaction.Status;
                data.DateCompleted = transaction.DateCompleted;
                _dataContext.SaveChanges();
                TempData["msg"] = "Operation was successful";
                  
                // It will redirect to 
                // the Read method
                return RedirectToAction("Edit"); 
            }
            else
            return RedirectToAction("Completed");
    }
    public IActionResult Delete()
    {
        return View();
    }

    // POST: Cars/Delete/5
    // Delete an object via a POST request
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(Guid Id)
    {



      Transactions data = _dataContext.Transaction.FirstOrDefault(x => x.Id == Id);
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