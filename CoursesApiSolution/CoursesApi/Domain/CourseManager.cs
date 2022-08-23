using MongoDB.Driver;

namespace CoursesApi.Domain;

public class CourseManager
{

    private readonly MongoDbCoursesAdapter _adapter;

    public CourseManager(MongoDbCoursesAdapter adapter)
    {
        _adapter = adapter;
    }

    public async Task<CoursesResponse> GetAllCoursesAsync()
    {
        var coursesFromDatabase = await _adapter.Courses.Find(t => true).ToListAsync();

        var response = new CoursesResponse
        {
            Data = coursesFromDatabase.Select(c => new CourseSummaryItemResponse
            {
                Id = c.Id.ToString(),
                Title = c.Title
               
            }).ToList(),
        };

        return response;
    }
}
