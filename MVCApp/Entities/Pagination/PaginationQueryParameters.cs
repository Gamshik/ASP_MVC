using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Entities.Pagination
{
    public class PaginationQueryParameters
    {
        [BindRequired]
        [FromQuery(Name = "page")]
        public int Page { get; set; }

        [BindRequired]
        [FromQuery(Name = "pageSize")]
        public int PageSize { get; set; }
    }
}
