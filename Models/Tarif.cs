using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestDotnet.Models
{
    [Table("tarif")]
    public class Tarif
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("tarif_id")]
        public Guid TarifID {get; set;} = Guid.NewGuid();

        [Required(ErrorMessage = "This field is required")]
        [Column("barang_id")]
        public Guid? BarangID {get; set;}

        [Required(ErrorMessage = "This field is required")]
        [Column("persentase")]
        public decimal Persentase {get; set;}

        public Barang? Barang {get; set;}
    }
}