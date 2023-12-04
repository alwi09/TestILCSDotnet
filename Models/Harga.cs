using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestDotnet.Models
{
    [Table("harga")]
    public class Harga
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("harga_id")]
        public Guid HargaID {get; set;} = Guid.NewGuid();

        [Required(ErrorMessage = "This field is required")]
        [ForeignKey("Barang")]
        [Column("barang_id")]
        public Guid? BarangID {get; set;}

        [Required(ErrorMessage = "This field is required")]
        [Column("jumlah")]
        public decimal Jumlah {get; set;}

        public Barang? Barang {get; set;}
    }
}