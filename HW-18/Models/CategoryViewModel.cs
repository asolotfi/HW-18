using System.ComponentModel.DataAnnotations;

namespace HW_18.Models
{
    public class CategoryViewModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }    
    }
}
