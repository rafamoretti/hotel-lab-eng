using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Employee
    {
        public Employee() {}

        public Employee(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}