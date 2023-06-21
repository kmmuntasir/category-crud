using CategoryCrud.Enum;

namespace CategoryCrud.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public Status Status { get; set; } = Status.INACTIVE;
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime UpdatedTime { get; set;} = DateTime.Now;
    }
}
