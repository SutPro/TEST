//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Petteys.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public Customer()
        {
            this.Customer2 = new HashSet<Customer2>();
            this.Orders = new HashSet<Orders>();
            this.Pet = new HashSet<Pet>();
            this.Product = new HashSet<Product>();
            this.Trainer = new HashSet<Trainer>();
        }
    
        public int cus_Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string fistname { get; set; }
        public string lastname { get; set; }
        public string sex { get; set; }
        public System.DateTime brithdate { get; set; }
        public int age { get; set; }
        public string Tel { get; set; }
        public string e_mail { get; set; }
        public string address { get; set; }
        public string User_type { get; set; }
    
        public virtual ICollection<Customer2> Customer2 { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Pet> Pet { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<Trainer> Trainer { get; set; }
    }
}
