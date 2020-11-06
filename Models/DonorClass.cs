using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace LowVision.Models
{
    public class DonorClass
    {
        [Required]
        public int DonorId { get; set; }

        [Display(Name = "Full name")]
        [Required(ErrorMessage ="Please enter Full name")]
        public string DonorName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter email")]
        public string Email { get; set; }

        
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Please enter Country")]
        public string Country { get; set; }

        
        [Display(Name = "Donation Amount")]
        [Required(ErrorMessage = "Please enter Donation Amount")]
        public int DonationAmt { get; set; }

        
        [Display(Name = "Cardholder name")]
        [Required(ErrorMessage = "Please enter card-holder name")]
        public string CCname { get; set; }

        
        [Display(Name = "Card number")]
        [Required(ErrorMessage = "Please enter card-holder number")]
        public int CCnumber { get; set; }

        
        [Display(Name = "Card expiration date")]
        [Required(ErrorMessage = "Please enter card expiration date")]
        public string CCexpiration { get; set; }

        
        [Display(Name = "Card CSC")]
        [Required(ErrorMessage = "Please enter card CSC number")]
        public int CCcsc { get; set; }
    }
}
