namespace AutoGlassApi.Application.ViewModels
{
    public class SuccessResponse<T>
    {
        public SuccessResponse()
        {
        }

        public SuccessResponse(T data)
        {
            Succeeded = true;
            Message = string.Empty;
            Data = data;
        }

        public SuccessResponse(T data, string message)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }

        public T Data { get; set; }
        public bool Succeeded { get; set; }
        public string Message { get; set; }
    }
}
