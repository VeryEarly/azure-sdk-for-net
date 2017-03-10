// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// A client for issuing REST requests to the Azure Batch service.
    /// </summary>
    public partial interface IBatchServiceClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        Microsoft.Rest.ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Client API Version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated
        /// and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IApplicationOperations.
        /// </summary>
        IApplicationOperations Application { get; }

        /// <summary>
        /// Gets the IPoolOperations.
        /// </summary>
        IPoolOperations Pool { get; }

        /// <summary>
        /// Gets the IAccountOperations.
        /// </summary>
        IAccountOperations Account { get; }

        /// <summary>
        /// Gets the IJobOperations.
        /// </summary>
        IJobOperations Job { get; }

        /// <summary>
        /// Gets the ICertificateOperations.
        /// </summary>
        ICertificateOperations Certificate { get; }

        /// <summary>
        /// Gets the IFileOperations.
        /// </summary>
        IFileOperations File { get; }

        /// <summary>
        /// Gets the IJobScheduleOperations.
        /// </summary>
        IJobScheduleOperations JobSchedule { get; }

        /// <summary>
        /// Gets the ITaskOperations.
        /// </summary>
        ITaskOperations Task { get; }

        /// <summary>
        /// Gets the IComputeNodeOperations.
        /// </summary>
        IComputeNodeOperations ComputeNode { get; }

    }
}
