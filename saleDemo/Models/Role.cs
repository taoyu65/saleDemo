using System;
using System.ComponentModel.DataAnnotations;
namespace saleDemo.Models
{
    public class Role
    {
        private int id;
        private string roleName;

        public Role()
        {

        }

        public int Id { get => id; set => id = value; }

        [Required]
        public string RoleName { get => roleName; set => roleName = value; }
    }
}
