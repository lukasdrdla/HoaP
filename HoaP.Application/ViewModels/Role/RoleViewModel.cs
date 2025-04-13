using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.Role
{
    public class RoleViewModel
    {
        public string Id { get; set; } = string.Empty;
        [Required(ErrorMessage = "Název je povinný")]
        public string Name { get; set; } = string.Empty;
    }
}
