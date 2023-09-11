using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Entities
{
    public class Info
    {
        [Required(ErrorMessage = "This field can't be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field can't be empty")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "This field can't be empty")]
        public string Phone { get; set; }
    }
}
