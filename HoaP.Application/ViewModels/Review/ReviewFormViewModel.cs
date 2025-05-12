using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.Review
{
    using System.ComponentModel.DataAnnotations;

    public class ReviewFormViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Zákazník je povinný.")]
        [Range(1, int.MaxValue, ErrorMessage = "Zákazník je povinný.")]
        public int CustomerId { get; set; }

        public string? CustomerName { get; set; }

        [Required(ErrorMessage = "Číslo pokoje je povinné.")]
        [Range(1, int.MaxValue, ErrorMessage = "Číslo pokoje je povinné.")]
        public int RoomNumber { get; set; }

        [Required(ErrorMessage = "Pokoj je povinný.")]
        public int RoomId { get; set; }

        [Required(ErrorMessage = "Hodnocení je povinné.")]
        [Range(1, 5, ErrorMessage = "Hodnocení musí být mezi 1 a 5.")]
        public int Rating { get; set; }

        [StringLength(1000, ErrorMessage = "Komentář nesmí přesáhnout 1000 znaků.")]
        public string Comment { get; set; } = string.Empty;
    }

}
