using System.ComponentModel.DataAnnotations;

namespace FinanceManager.Server.Data.Entities
{

    public class EachPurchaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string BillName {  get; set; } = string.Empty;

        [Required]
        public int BillAmount { get; set; } = 0;

        [Required]
        public DateTime BillDate { get; set; } = DateTime.Now;

        [Required]
        public string SelectOption { get; set; } = "Entertainment";

    }

}
