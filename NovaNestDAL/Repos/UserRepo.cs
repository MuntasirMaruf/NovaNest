using NovaNestDAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaNestDAL.Repos
{
    public class UserRepo : Repo
    {
        public Customer Get(int id)
        {
            return db.Customers.Find(id);
        }

        public List<Customer> Get()
        {
            return db.Customers.ToList();
        }


        public void Create(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        public void Update(Customer customer)
        {
            var existing = db.Customers.Find(customer.Id);
            existing.Name = customer.Name;
            existing.Email = customer.Email;
            existing.PhoneNumber = customer.PhoneNumber;
            existing.Address = customer.Address;
            existing.Password = customer.Password;
            existing.Status = customer.Status;
            existing.Updated = customer.Updated;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Customers.Remove(Get(id));
        }
    }
}
