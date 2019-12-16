using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace SessionDemo.Models
{
    public class Basket
    {
        public Guid Id { get; protected set; } = Guid.NewGuid();
        public decimal Price { get; set; }

        [IgnoreDataMember]
        public decimal PriceWithVat => Price * vat;

        [Display(Name = "Popis produktu")]
        [IgnoreDataMember]
        public string Description { get; set; }

        private decimal vat { get; } = 1.21m;
    }
}
