using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Product() { }
        public Product(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;

        }
        private int GetId()
        {
            return this.Id;
        }

        private string GetName()
        {
            return this.Name;
        }
        private string GetDescription()
        {
            return this.Description;
        }

        public void GetData()
        {
            this.GetName();
            this.GetDescription();
        }

        public void GetInfo()
        {
            this.GetId();
            this.GetName();
            this.GetDescription();

            this.ToString();
        }

        public override string ToString()
        {
            return $"Id: {this.Id}, Name: {this.Name}, Description: {this.Description}";
        }

    }
}
