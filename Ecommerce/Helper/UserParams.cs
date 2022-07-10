namespace Ecommerce.Helper
{
    public class UserParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 6;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }

        //public Guid UserId { get; set; }
        //public string Gender { get; set; }
        //public int MinAge { get; set; }
        //public int MaxAge { get; set; }
        //public string OrderBy { get; set; }
        //public bool Likees { get; set; } = false;
        //public bool Likers { get; set; } = false;
    }
}
