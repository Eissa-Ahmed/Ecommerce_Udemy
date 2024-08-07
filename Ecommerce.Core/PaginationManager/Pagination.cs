namespace Ecommerce.Application.PaginationManager;

public sealed class Pagination<T>
{
    public int TotalCount { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }

    public Pagination(List<T> data, int pageNumber, int pageSize, int totalCount)
    {
        Data = data;
        PageNumber = pageNumber;
        PageSize = pageSize;
        TotalCount = totalCount;
    }

    //public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
    public int TotalPages
    {
        get
        {
            if (PageSize == 0) return 0; // لتجنب القسمة على صفر
            return (int)Math.Ceiling(TotalCount / (double)PageSize);
        }
    }
    public bool HasPreviousPage => PageNumber > 1;
    public bool HasNextPage => PageNumber < TotalPages;
    public List<T> Data { get; set; }
}

