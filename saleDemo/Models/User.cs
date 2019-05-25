using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace saleDemo.Models
{
    public class User
    {
        private int id;
        private string name;
        private string password;
        private int roleId;

        public User()
        {
        }

        public int Id { get => id; set => id = value; }

        [Required]
        public string Name { get => name; set => name = value; }

        [Required]
        public string Password { get => password; set => password = value; }

        [Required]
        public int RoleId { get => roleId; set => roleId = value; }
    }
}
