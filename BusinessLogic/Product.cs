using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Product
    {
        public Product()
        {

        }

        public Product(string id, string name, string details, double cost, double price, string creationDate, string dueDate, string category, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Details = details;
            this.Cost = cost;
            this.Price = price;
            this.CreationDate = creationDate;
            this.DueDate = dueDate;
            this.Category = category;
            this.Status = status;
        }

        public string ID { get; set; }
        public string Name { get; set;}
        public string Details { get; set;}
        public double Cost { get; set;}
        public double Price { get; set;}
        public string CreationDate { get; set;}
        public string DueDate { get; set;}
        public string Category { get; set;}
        public string Status { get; set;}
    }
}
