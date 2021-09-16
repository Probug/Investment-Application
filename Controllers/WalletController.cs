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
     public class WalletController : Controller
  {
    private ApplicationDbContext _dataContext;
    private readonly UserManager< ApplicationUser> _userManager;

        // The instance of DbContext is passed via dependency injection
    public WalletController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
      this._dataContext=context;
      _userManager = userManager;
    }

    // GET: /<controller>/
    // Return the list of cars to the caller view
    public IActionResult Index()
    { 
       var data = _dataContext.Wallet.ToList();
      return View(data);
    }

    public IActionResult EditWallet()
    {
      return View();
    }
    public IActionResult Delete()
    {
        return View();
    }
    
     public async Task<IActionResult> Edit(Guid? Id)
    {
      if (Id == null)
      {
          return NotFound();
      }

      var wallet = await _dataContext.Wallet.FindAsync(Id);
      if (wallet == null)
      {
          return NotFound();
      }
        //var transaction = _dataContext.Transaction.Where(x => x.Id == Id).SingleOrDefault();
        return View("EditWallet", wallet);
    }
        
    [HttpPost]
    [ValidateAntiForgeryToken] 
    public ActionResult Edit(Guid? Id, Wallet wallet)
    {
        if (Id != wallet.Id)
        {
            return NotFound();
        }   
            // Use of lambda expression to access
            // particular record from a database
            var data = _dataContext.Wallet.FirstOrDefault(x => x.Id == Id); 
              
            // Checking if any such record exist 
            if (data != null) 
            {
                data.UserID = wallet.UserID;
                data.Email = wallet.Email;
                data.BTCBalance = wallet.BTCBalance;
                data.EthBalance = wallet.EthBalance;
                data.LiteCoinBalance = wallet.LiteCoinBalance;
                data.DogeCoinBalance = wallet.DogeCoinBalance;
                data.Balance = wallet.Balance;
                _dataContext.SaveChanges();
                
                TempData["msg"] = "Operation was successful";
                  
                // It will redirect to 
                // the Read method
                return RedirectToAction("Index"); 
            }
            else
            return RedirectToAction("EditWallet");
    }

    // POST: Cars/Delete/5
    // Delete an object via a POST request
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(Guid Id)
    {



      Wallet data = _dataContext.Wallet.FirstOrDefault(x => x.Id == Id);
      // Remove the car from the collection and save changes

      if (data != null) {
      _dataContext.Wallet.Remove(data);
      _dataContext.SaveChanges();
      TempData["msg"] = "Operation was successful";
      return RedirectToAction("Completed");
      }
      else
      return View();
    }
  }
}