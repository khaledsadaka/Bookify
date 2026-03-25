namespace Bookify.Web.Core.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "الاسم لا يتعدي 50 حرف ")]
        public string Name { get; set; } = null!;

        public bool IsDeleted { get; set; } = false;

        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime? LastUpdatedOn { get; set; }
    }
}
