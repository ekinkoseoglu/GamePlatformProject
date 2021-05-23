namespace BackBone.Utilities
{
    public interface IDataResult<T>:IResult
    {
        public T Data { get; }
    }
}
