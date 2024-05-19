namespace DataAnnotations.Application.Dtos
{
    public class BaseReturnApresentations<T>
    {
        public bool Success { get; private set; }
        public dynamic Errors { get; private set; }
        public T Result { get; private set; }

    }
    public class BaseReturnApresentationsList<T>
    {
        public bool Success { get; private set; }
        public dynamic Errors { get; private set; }
        public List<T> Result { get; private set; }

    }
    public class BaseReturn
    {
        public bool Success { get; set; }
        public dynamic Results { get; set; }
        public dynamic Errors { get; set; }
    }
}
