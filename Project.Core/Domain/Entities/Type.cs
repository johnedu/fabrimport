using Project.Domain.BaseEntity;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Type : MultiTenantEntity
    {
        public string Name { get; set; }
        public virtual Parameter Parameter { get; set; }
        public int ParameterId { get; set; }
        public bool Locked { get; set; }

        public virtual ICollection<Phone> PhoneTypes { get; set; }
        public virtual ICollection<Company> CompanyDocumentTypes { get; set; }
        public virtual ICollection<Person> PersonDocumentTypes { get; set; }
        public virtual ICollection<Spending> Spendings { get; set; }
        public virtual ICollection<State> States { get; set; }

        public Type()
        {
            PhoneTypes = new List<Phone>();
            CompanyDocumentTypes = new List<Company>();
            PersonDocumentTypes = new List<Person>();
            Spendings = new List<Spending>();
            States = new List<State>();
        }
    }
}