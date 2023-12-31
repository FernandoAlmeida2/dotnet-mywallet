namespace dotnet_mywallet.Models
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;

        public void HandleError (string message) {
            Success = false;
            Message = message;
        }
    }
}