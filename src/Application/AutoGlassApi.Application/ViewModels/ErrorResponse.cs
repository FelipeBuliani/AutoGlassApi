namespace AutoGlassApi.Application.ViewModels
{
    public class ErrorResponse
    {
        public ErrorResponse()
        {
        }

        public ErrorResponse(string errorDessage)
        {
            Succeeded = false;
            Message = errorDessage;
            Data = null;
        }

        public object Data { get; set; }
        public bool Succeeded { get; set; }
        public string Message { get; set; }
    }
}
