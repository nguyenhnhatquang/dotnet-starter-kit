namespace SharedKernel.Results;

public sealed record PaginatedResult<T>
{
    public ICollection<T> Data { get; init; }
    public PaginationMetadata Pagination { get; init; }
    
    public PaginatedResult(ICollection<T> data, PaginationMetadata pagination)
    {
        Data = data;
        Pagination = pagination;
    }
}

public sealed record PaginationMetadata
{
    public int CurrentPage { get; init; }
    public int PageSize { get; init; }
    public int TotalCount { get; init; }
    public int TotalPages { get; init; }
    public bool HasNextPage { get; init; }
    public bool HasPreviousPage { get; init; }
    
    public PaginationMetadata(int currentPage, int pageSize, int totalCount)
    {
        CurrentPage = currentPage;
        PageSize = pageSize;
        TotalCount = totalCount;
        TotalPages = (int)Math.Ceiling((double)totalCount / pageSize);
        HasNextPage = CurrentPage < TotalPages;
        HasPreviousPage = CurrentPage > 1;
    }
    
}
