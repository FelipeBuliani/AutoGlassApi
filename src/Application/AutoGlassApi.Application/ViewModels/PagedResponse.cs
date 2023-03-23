namespace AutoGlassApi.Application.ViewModels
{
    public class PagedResponse<T> : SuccessResponse<T>
    {
        public int Skip { get; set; }
        public int Take { get; set; }
        public int Results { get; set; }

        public PagedResponse(T data, int skip, int take, int results)
        {
            Data = data;
            Message = null;
            Succeeded = true;
            Skip = skip;
            Take = take;
            Results = results;
        }
    }
}
