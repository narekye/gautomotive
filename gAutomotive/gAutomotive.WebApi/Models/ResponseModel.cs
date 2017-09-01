namespace gAutomotive.WebApi.Models
{
    public class ResponseModel<T>
    {
        public bool HasError { get; set; }
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
    }
}