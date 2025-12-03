using System.ComponentModel.DataAnnotations;

namespace LocadoraLivros.Models
{
    public class LoanModel
    {
        [Key]
        public int LoanId { get; set; }
        [Required(ErrorMessage = "The field Receiver is required")]
        public string Receiver { get; set; }
        [Required(ErrorMessage = "The field Supplier is required")]
        public string Supplier { get; set; }
        [Required(ErrorMessage = "The field BorrowedBook is required")]
        public string BorrowedBook { get; set; }
        public DateTime LastUpdate { get; set; } = DateTime.Now;

    }
}
