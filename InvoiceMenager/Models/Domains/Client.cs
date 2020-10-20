using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceMenager.Models.Domains
{
    public class Client
    {
        public Client()
        {
            Clients = new Collection<Client>();
        }
        

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int AddressId { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }



        public Address Address { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ApplicationUser User { get; set; }
    }
}