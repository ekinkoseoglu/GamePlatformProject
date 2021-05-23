namespace BackBone.Utilities
{
    public interface IResult
    {
        public string Message { get; }
        public bool Success { get; }
    }
}
