using System;  
using System.ComponentModel.DataAnnotations;  
  
namespace Bitmoonfasttrade.Models  
{  
    public class Wallet  
    {  
        public Guid Id { get; set; }  
         
        public string UserID { get; set; }  

        public string Email { get; set; } 
         
        public Decimal BTCBalance { get; set; }  
         
        public Decimal EthBalance { get; set; }  
         
        public Decimal LiteCoinBalance {get;set;}  
         
        public Decimal DogeCoinBalance {get;set;} 
        
        public Decimal Balance {get;set;} 
    }  
} 