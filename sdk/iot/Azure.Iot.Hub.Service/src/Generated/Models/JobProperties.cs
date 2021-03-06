// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The JobProperties. </summary>
    public partial class JobProperties
    {
        /// <summary> Initializes a new instance of JobProperties. </summary>
        public JobProperties()
        {
        }

        /// <summary> Initializes a new instance of JobProperties. </summary>
        /// <param name="jobId"> System generated.  Ignored at creation. </param>
        /// <param name="startTimeUtc"> System generated.  Ignored at creation. </param>
        /// <param name="endTimeUtc">
        /// System generated.  Ignored at creation.
        /// 
        /// Represents the time the job stopped processing.
        /// </param>
        /// <param name="type">
        /// Required.
        /// 
        /// The type of job to execute.
        /// </param>
        /// <param name="status"> System generated.  Ignored at creation. </param>
        /// <param name="progress">
        /// System generated.  Ignored at creation.
        /// 
        /// Represents the percentage of completion.
        /// </param>
        /// <param name="inputBlobContainerUri"> URI containing SAS token to a blob container that contains registry data to sync. </param>
        /// <param name="inputBlobName"> The blob name to be used when importing from the provided input blob container. </param>
        /// <param name="outputBlobContainerUri"> URI containing SAS token to a blob container.  This is used to output the status of the job and the results. </param>
        /// <param name="outputBlobName">
        /// The name of the blob that will be created in the provided output blob container.  This blob will contain
        /// 
        /// the exported device registry information for the IoT Hub.
        /// </param>
        /// <param name="excludeKeysInExport">
        /// Optional for export jobs; ignored for other jobs.  Default: false.  If false, authorization keys are included
        /// 
        /// in export output.  Keys are exported as null otherwise.
        /// </param>
        /// <param name="storageAuthenticationType"> Specifies authentication type being used for connecting to storage account. </param>
        /// <param name="failureReason">
        /// System genereated.  Ignored at creation.
        /// 
        /// If status == failure, this represents a string containing the reason.
        /// </param>
        internal JobProperties(string jobId, DateTimeOffset? startTimeUtc, DateTimeOffset? endTimeUtc, JobPropertiesType? type, JobPropertiesStatus? status, int? progress, string inputBlobContainerUri, string inputBlobName, string outputBlobContainerUri, string outputBlobName, bool? excludeKeysInExport, JobPropertiesStorageAuthenticationType? storageAuthenticationType, string failureReason)
        {
            JobId = jobId;
            StartTimeUtc = startTimeUtc;
            EndTimeUtc = endTimeUtc;
            Type = type;
            Status = status;
            Progress = progress;
            InputBlobContainerUri = inputBlobContainerUri;
            InputBlobName = inputBlobName;
            OutputBlobContainerUri = outputBlobContainerUri;
            OutputBlobName = outputBlobName;
            ExcludeKeysInExport = excludeKeysInExport;
            StorageAuthenticationType = storageAuthenticationType;
            FailureReason = failureReason;
        }

        /// <summary> System generated.  Ignored at creation. </summary>
        public string JobId { get; set; }
        /// <summary> System generated.  Ignored at creation. </summary>
        public DateTimeOffset? StartTimeUtc { get; set; }
        /// <summary>
        /// System generated.  Ignored at creation.
        /// 
        /// Represents the time the job stopped processing.
        /// </summary>
        public DateTimeOffset? EndTimeUtc { get; set; }
        /// <summary>
        /// Required.
        /// 
        /// The type of job to execute.
        /// </summary>
        public JobPropertiesType? Type { get; set; }
        /// <summary> System generated.  Ignored at creation. </summary>
        public JobPropertiesStatus? Status { get; set; }
        /// <summary>
        /// System generated.  Ignored at creation.
        /// 
        /// Represents the percentage of completion.
        /// </summary>
        public int? Progress { get; set; }
        /// <summary> URI containing SAS token to a blob container that contains registry data to sync. </summary>
        public string InputBlobContainerUri { get; set; }
        /// <summary> The blob name to be used when importing from the provided input blob container. </summary>
        public string InputBlobName { get; set; }
        /// <summary> URI containing SAS token to a blob container.  This is used to output the status of the job and the results. </summary>
        public string OutputBlobContainerUri { get; set; }
        /// <summary>
        /// The name of the blob that will be created in the provided output blob container.  This blob will contain
        /// 
        /// the exported device registry information for the IoT Hub.
        /// </summary>
        public string OutputBlobName { get; set; }
        /// <summary>
        /// Optional for export jobs; ignored for other jobs.  Default: false.  If false, authorization keys are included
        /// 
        /// in export output.  Keys are exported as null otherwise.
        /// </summary>
        public bool? ExcludeKeysInExport { get; set; }
        /// <summary> Specifies authentication type being used for connecting to storage account. </summary>
        public JobPropertiesStorageAuthenticationType? StorageAuthenticationType { get; set; }
        /// <summary>
        /// System genereated.  Ignored at creation.
        /// 
        /// If status == failure, this represents a string containing the reason.
        /// </summary>
        public string FailureReason { get; set; }
    }
}
