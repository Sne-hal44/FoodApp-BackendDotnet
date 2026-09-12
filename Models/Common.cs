namespace FoodApp.Models
{
    public class Common 
    {
        public bool IsActive { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set;  }
    }
}
