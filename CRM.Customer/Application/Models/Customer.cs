using JsonApi.Attributes;
namespace CRM.Customer.Application.Models;

public class Customer : Identifiable<int>
    {
        [Attr()]
        public int Id { get; init; }
        public string CustomerId { get; init; }
        public string Name { get; init; }
        public string Email { get; init; }
        public string PhoneNumber { get; init; }
        public List<string> Tests { get; set; }
    }