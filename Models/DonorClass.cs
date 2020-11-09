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
        [MaxLength(70, ErrorMessage ="Full Name cannot exceed 70 characters")]
        [Display(Name = "Full name")]
        [Required(ErrorMessage ="Please enter Full name")]
        public string DonorName { get; set; }

        [Display(Name = "Email")]
        [Required]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Please Enter valid Email")]
        public string Email { get; set; }

        
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Please enter Country")]
        public string Country { get; set; }

        [Range(5,500)]
        [Display(Name = "Donation Amount ($NZD)")]
        [Required(ErrorMessage = "Please enter Donation Amount more than $5 NZD as a whole number")]
        public int DonationAmt { get; set; }

        
        [Display(Name = "Cardholder name")]
        [Required(ErrorMessage = "Please enter card-holder name")]
        public string CCname { get; set; }

        
        [Display(Name = "Card number")]
        [Required(ErrorMessage = "Please enter card-holder number")]
        public int CCnumber { get; set; }

        [Display(Name = "Card Expiry: Month")]
        [Required(ErrorMessage = "Please enter card expiration date")]
        [DataType(DataType.Date)]
        public int CCmonth { get; set; }

        [Display(Name = "Year: ")]
        [Required(ErrorMessage = "Please enter card expiration date")]
        [DataType(DataType.Date)]
        public int CCyear { get; set; }



        [Display(Name = "Card CSC")]
        [Required(ErrorMessage = "Please enter card CSC number")]
        public int CCcsc { get; set; }
    }
}
