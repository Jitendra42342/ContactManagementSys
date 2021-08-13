using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.BusinessLayer.Models
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ContactId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Status { get; set; }
    }
}
