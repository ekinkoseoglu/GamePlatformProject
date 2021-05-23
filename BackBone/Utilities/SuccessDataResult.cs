namespace BackBone.Utilities
{
    public class SuccessDataResult<T> : DataResult<T>, IResult
    {
        public SuccessDataResult(T data, string message) : base(data, message, true)
        {
        }

        public SuccessDataResult(T data) : base(data, true)
        {
        }

        public SuccessDataResult(string message) : base(default, message, true)
        {

        }

        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
