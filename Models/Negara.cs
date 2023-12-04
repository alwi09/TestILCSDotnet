using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestDotnet.Models
{
    [Table("negara")]
    public class Negara
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("negara_id")]
        public Guid NegaraID {get; set;} = Guid.NewGuid();

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(60, ErrorMessage = "This field must between 3 and 60 characters")]
        [MinLength(3, ErrorMessage = "This field must between 3 and 60 characters")]
        [Column("kode_negara")]
        public String KodeNegara {get; set;} = String.Empty;

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(60, ErrorMessage = "This field must between 3 and 60 characters")]
        [MinLength(3, ErrorMessage = "This field must between 3 and 60 characters")]
        [Column("ur_negara")]
        public String UrNegara {get; set;} = String.Empty;
    }
}