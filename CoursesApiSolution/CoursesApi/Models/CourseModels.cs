namespace CoursesApi.Models;

public record CourseSummaryItemResponse
{
    public string Id { get; init; } = string.Empty;
    public string Title { get; init; } = string.Empty;
}

public record CoursesResponse
{
    public List<CourseSummaryItemResponse> Data { get; init; } = new();
}


public record CourseDetailsResponse
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public decimal NumberOfHours { get; set; }
    public DeliveryLocationTypes DeliveryLocation { get; set; }
}

public enum DeliveryLocationTypes
{
    Online,
    OnPrem
}