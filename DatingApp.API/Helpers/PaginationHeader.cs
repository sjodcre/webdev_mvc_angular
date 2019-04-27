namespace DatingApp.API.Helpers
{
    public class PaginationHeader
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }

        public PaginationHeader(int currentpage, int itemsPerPAge, int totalItems, int totalPages)
        {
            this.CurrentPage = currentpage;
            this.TotalItems = totalItems;
            this.TotalPages = totalPages;
            this.ItemsPerPage = itemsPerPAge;
        }
    }

    
}