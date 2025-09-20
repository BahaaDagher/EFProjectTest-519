using EFProjectTest_2.Data;

namespace EFProjectTest_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            //var customers = db.Customers.AsQueryable();

            // Add Filter
            //customers = customers.Where(e => e.State == "NY" || e.State == "CA");
            //customers = customers.Where(e => e.Phone == null);
            //customers = customers.Where(e => e.Email.Contains("@yahoo.com"));
            //customers = customers.Where(e => e.State == "NY").OrderBy(e => e.FirstName).ThenByDescending(e => e.LastName);
            //customers = customers.Where(e => e.State == "NY").Skip(0).Take(10);

            //foreach (var item in customers)
            //{
            //    Console.WriteLine($"Id: {item.CustomerId}, Name: {item.FirstName} {item.LastName}, State: {item.State}");
            //}

            // Single Record
            //var customer = db.Customers.Where(c=>c.CustomerId==1).FirstOrDefault();
            //var customer = db.Customers.FirstOrDefault(e => e.State == "ZZ");
            //var customer2 = db.Customers.OrderByDescending(c=>c.CustomerId).LastOrDefault(e => e.State == "NY");
            //Console.WriteLine(customer2.FirstName);

             

            var customer = db.Customers.SingleOrDefault(e => e.CustomerId == 125125); // (1 , 0 , > 1 )
            if (customer != null )
                Console.WriteLine(value: $"Id: {customer.CustomerId}, Name: {customer.FirstName} {customer.LastName}, State: {customer.State}");



        }
    }
}
