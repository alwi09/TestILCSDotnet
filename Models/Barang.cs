using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestDotnet.Models
{
    [Table("barang")]
    public class Barang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("barang_id")]
        public Guid BarangID {get; set;} = Guid.NewGuid();

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(60, ErrorMessage = "This field must between 3 and 60 characters")]
        [MinLength(3, ErrorMessage = "This field must between 3 and 60 characters")]
        [Column("kode_negara")]
        public String KodeNegara {get; set;} = String.Empty;

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(60, ErrorMessage = "This field must between 3 and 60 characters")]
        [MinLength(3, ErrorMessage = "This field must between 3 and 60 characters")]
        [Column("ur_barang")]
        public String UrBarang {get; set;} = String.Empty;

        public Harga? Harga {get; set;}
        public Tarif? Tarif {get; set;}
    }
}