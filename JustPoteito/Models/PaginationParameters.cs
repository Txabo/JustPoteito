namespace JustPoteito.Models
{
    public class PaginationParameters
    {
        public int pageSize { get; set; }
        public int firstElement { get; set; }
        public int lastElement { get; set; }
        public int totalPages { get; set; }
        public int actualPage { get; set; }
    }
}
