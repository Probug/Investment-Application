using System;  
using System.ComponentModel.DataAnnotations;  
  
namespace Bitmoonfasttrade.Models  
{  
    public class Transactions  
    {  
        public Guid Id { get; set; } 
        [Required]   
        public string UserId { get; set; }  
         public string Email { get; set; }
        [Required]  
        public string Type { get; set; } 
         
        public string Plan { get; set; } 
        [Required]  
        public decimal Amount {get;set;}   

        public decimal Bonus { get; set; } 
 
        public string WalletAddress { get; set; } 
        [Required]  
        public string Coin { get; set; } 
        [Required]  
        public DateTime? DateCreated { get; set; } 
        [Required]  
        public string Status { get; set; }   
        public DateTime? DateCompleted { get; set; } 
    }  
} 