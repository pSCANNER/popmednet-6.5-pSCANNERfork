#region Legal Information

// ====================================================================================
//  
//      Center for Population Health Informatics
//      Solution: Lpp.Adapters
//      Project: Lpp.Scanner.DataMart.Model.Processors
//      Last Updated By: Westerman, Dax Marek
// 
// ====================================================================================

#endregion

#region Using



#endregion

using Lpp.Scanner.DataMart.Model.Processors.DataSetMapping;


namespace Lpp.Scanner.DataMart.Model.Processors.Common.Base {

    public abstract class BaseRequestParameter {

        /// <summary>
        /// </summary>
        public enum RequestForEnum {

            PostRequest,
            RequestId,
            RequestXml,
            GetResponse,
            GetStatus,
            StopRequest,
            Undefined

        }

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseRequestParameter" /> class.
        /// </summary>
        /// <param name="requestParameter">The request parameter.</param>
        protected BaseRequestParameter(BaseRequestParameter requestParameter) : this(requestParameter.RequestId, requestParameter.RequestFor, new EmptyConnection()) {}

        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseRequestParameter" /> class.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="requestFor">The request for.</param>
        /// <param name="dataSetConnection"></param>
        protected BaseRequestParameter(string requestId, RequestForEnum requestFor, BaseDataSetConnection dataSetConnection) : this(requestId, requestFor) {
            DataSetConnection = dataSetConnection;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseRequestParameter" /> class.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="requestFor">The request for.</param>
        protected BaseRequestParameter(string requestId, RequestForEnum requestFor) {
            RequestFor = requestFor;
            RequestId = requestId;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the data set connection.
        /// </summary>
        /// <value>
        ///     The data set connection.
        /// </value>
        public BaseDataSetConnection DataSetConnection { get; private set; }

        /// <summary>
        ///     Gets or sets the type of the request.
        /// </summary>
        /// <value>
        ///     The type of the request.
        /// </value>
        public RequestForEnum RequestFor { get; private set; }

        /// <summary>
        ///     Gets the request identifier.
        /// </summary>
        /// <value>
        ///     The request identifier.
        /// </value>
        public string RequestId { get; private set; }

        #endregion

        /// <summary>
        ///     Sets the request for.
        /// </summary>
        /// <param name="requestFor">The request for.</param>
        public void SetRequestFor(RequestForEnum requestFor) {
            RequestFor = requestFor;
        }

    }

}