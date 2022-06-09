using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Guest
    {
        public Guest() {}

        public Guest (string name, string email, string phone, string cpf)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Cpf = cpf;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Cpf { get; set; }

        public Room Room { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CheckInId { get; set; }
        public CheckIn CheckIn { get; set; }
    }
}