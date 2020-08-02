using Project.Domain.BaseEntity;
using System;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Person: MultiTenantEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public string FullName { get; set; }
        public virtual Type DocumentType { get; set; }
        public int? DocumentTypeId { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? BirthdayDate { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }

        public virtual ICollection<PersonPhone> Phones { get; set; }
        public virtual ICollection<PersonAddress> Addresses { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Spending> PersonSpendings { get; set; }

        public Person()
        {
            Phones = new List<PersonPhone>();
            Providers = new List<Provider>();
            Customers = new List<Customer>();
            Employees = new List<Employee>();
            PersonSpendings = new List<Spending>();
        }
    }
}