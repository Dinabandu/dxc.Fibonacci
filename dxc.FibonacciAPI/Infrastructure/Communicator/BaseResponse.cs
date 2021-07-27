namespace dxc.FibonacciAPI.Infrastructure.Communicator
{
    public class BaseResponse<T>
    {
        #region Base
        /// <summary>
        /// Success
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// Payload
        /// </summary>
        public T Payload { get; set; }
        /// <summary>
        /// ErrorMessage
        /// </summary>
        public string ErrorMessage { get; set; }

        #endregion Base
    }
}