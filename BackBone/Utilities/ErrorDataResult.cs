namespace BackBone.Utilities
{
    public class ErrorDataResult<T> : DataResult<T>, IResult
    {
        public ErrorDataResult(T data, string message) : base(data, message, false)
        {
        }

        public ErrorDataResult(T data) : base(data, false)
        {
        }

        public ErrorDataResult(string message):base(default,message,false)      
        {
            
        }

        public ErrorDataResult():base(default,false)
        {
            
        }
    }
}
