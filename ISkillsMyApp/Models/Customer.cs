using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ISkillsMyApp.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [Required(ErrorMessage ="Id is required")]
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }
        [Required(ErrorMessage = "State is required")]
        public string State { get; set; }
        [Required(ErrorMessage = "PostalCode is required")]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email is required")]

        public string Email{ get; set; }
        [Required(ErrorMessage = "BillingAddress is required")]

        public string BillingAddress { get; set; }
        [Required(ErrorMessage = "BillingCity is required")]

        public string BillingCity { get; set; }
        [Required(ErrorMessage = "BillingState is required")]

        public string BillingState { get; set; }
        [Required(ErrorMessage = "BillingPostalCode is required")]
        public string BillingPostalCode { get; set; }
        [Required(ErrorMessage = "CardNumber is required")]
        public string CardNumber { get; set; }
        [Required(ErrorMessage = "ExpirationMonth is required")]
        public string ExpirationMonth { get; set; }
        [Required(ErrorMessage = "ExpirationYear is required")]
        public string ExpirationYear { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}