namespace Entities.Pagination
{
    public class PaginationQueryParameters
    {
        //[BindRequired]
        //[FromQuery(Name = "page")]
        public int page { get; set; }

        //[BindRequired]
        //[FromQuery(Name = "pageSize")]
        public int pageSize { get; set; }
    }
}
