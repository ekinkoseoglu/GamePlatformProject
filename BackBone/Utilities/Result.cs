namespace BackBone.Utilities
{
    public class Result : IResult
    {
        public Result(string message, bool success) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public string Message { get; }
        public bool Success { get; }
    }
}
