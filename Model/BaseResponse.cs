
namespace Model
{
    public class BaseResponse<T>
{
    // <summary>
    // Gets or sets a value indicating whether the API request was successful.
    // </summary>
    public bool Success { get; set; }

    // <summary>
    // Gets or sets the error message if the API request was not successful.
    // </summary>
    public string ErrorMessage { get; set; }

    // <summary>
    // Gets or sets the data contained in the response.
    // </summary>
    public T? Data { get; set; }

    // <summary>
    // Constructs a new instance of the ApiResponse class.
    // </summary>
    public BaseResponse()
    {
        Success = true;
        ErrorMessage = string.Empty;
        Data = default(T);
    }
    public BaseResponse(bool success, string errorMessage, T data)
    {
        Success = success;
        ErrorMessage = errorMessage;
        Data = data;
    }
    public BaseResponse(bool success, string errorMessage)
    {
        Success = success;
        ErrorMessage = errorMessage;
        Data = default(T);
    }
    public BaseResponse(T data)
    {
        Success = true;
        ErrorMessage = string.Empty;
        Data = data;
    }
}
}


//    public enum ResponseStatus
//    {
//        Error, Success, ModelIsNotValid, ObjectNotFound, ServerExeption
//    }





//    public interface IResponseStatus
//    {
//        string MessageCode { get; }
//        string EndUserMessage { get; }
//        ResponseStatus Status { get; set; }
//    }



//    public static class BaseResponseExtension
//    {
//        public static TResponse SetLogMessage<TResponse>(this TResponse response, string log) where TResponse : BaseResponse
//        {
//            response.LogMessage = log;
//            return response;
//        }
//    }




//    /// <summary>
//    /// Base response for api methods
//    /// </summary>
//    public class BaseResponse : IResponseStatus
//    {
//        public static BaseResponse Error(ResponseStatus status, string endUserMessage = null)
//        {
//            return new BaseResponse() { Status = status, EndUserMessage = endUserMessage };
//        }
//        //public static BaseResponse Error(ResponseStatus status, AppMessage.MessageData message)
//        //{
//        //    var rslt = new BaseResponse() { Status = status };
//        //    rslt.AddMessage(message);
//        //    return rslt;
//        //}

//        //public static BaseResponse FromResponse<TResponse>(TResponse sourceResponse) where TResponse : BaseResponse
//        //{
//        //    var rslt = new BaseResponse() { Status = sourceResponse.Status };
//        //    if (string.IsNullOrEmpty(sourceResponse.EndUserMessage))
//        //        rslt.SetEndUserMessage(sourceResponse.EndUserMessage);
//        //    if (sourceResponse.Messages?.Any() == true)
//        //        rslt.CopyMessages(sourceResponse);
//        //    return rslt;
//        //}

//        //public void CopyMessages(BaseResponse baseResponse)
//        //{
//        //    Messages = baseResponse.Messages;
//        //}

//        public static BaseResponse Success => new BaseResponse(ResponseStatus.Success);


//        public static BaseResponse ModelIsInvalid(string errorMessage = null)
//            => new BaseResponse() { Status = ResponseStatus.ModelIsNotValid, EndUserMessage = errorMessage };

//        //public static BaseResponse ModelIsInvalid(AppMessage.MessageData message)
//        //{
//        //    var rslt = new BaseResponse() { Status = ResponseStatus.ModelIsNotValid };
//        //    rslt.AddMessage(message);
//        //    return rslt;
//        //}

//        public static BaseResponse ObjectNotFound(string errorMessage = null)
//          => new BaseResponse() { Status = ResponseStatus.ObjectNotFound, EndUserMessage = errorMessage };

//        //public static BaseResponse ObjectNotFound(AppMessage.MessageData message)
//        //{
//        //    var rslt = new BaseResponse() { Status = ResponseStatus.ObjectNotFound };
//        //    rslt.AddMessage(message);
//        //    return rslt;
//        //}

//        public static BaseResponse ServerException(string errorMessage = null)
//            => new BaseResponse() { Status = ResponseStatus.ServerExeption, EndUserMessage = errorMessage };


//        public BaseResponse()
//        {
//        }
//        public BaseResponse(ResponseStatus status)
//        {
//            Status = status;
//        }
//        public string MessageCode { get; private set; }
//        private string _EndUserMessage;
//        public string EndUserMessage
//        {
//            get
//            {
//                return _EndUserMessage;
//            }
//            set
//            {
//                _EndUserMessage = value;
//            }
//        }
//        public BaseResponse SetEndUserMessage(string endUserMessage)
//        {
//            EndUserMessage = endUserMessage;
//            return this;
//        }
//        //public void ClearMessages() => Messages.Clear();
//        public ResponseStatus Status { get; set; }
//        [Newtonsoft.Json.JsonIgnore]
//        public bool IsSuccessful => Status == ResponseStatus.Success;
//        [Newtonsoft.Json.JsonIgnore]
//        public bool IsFailed => !IsSuccessful;
//        [Newtonsoft.Json.JsonIgnore]
//        public string LogMessage { get; set; }


//    }

//    public class RootResponse<TResponse> : BaseResponse where TResponse : BaseResponse, new()
//    {
//        public new static TResponse Error(ResponseStatus status, string endUserMessage = null)
//        {
//            return new TResponse() { Status = status, EndUserMessage = endUserMessage };
//        }



//        public static new TResponse Success => new TResponse { Status = ResponseStatus.Success };
//    }
//}