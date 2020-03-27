// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The log profile resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LogProfileResource : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the LogProfileResource class.
        /// </summary>
        public LogProfileResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogProfileResource class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="locations">List of regions for which Activity Log
        /// events should be stored or streamed. It is a comma separated list
        /// of valid ARM locations including the 'global' location.</param>
        /// <param name="categories">the categories of the logs. These
        /// categories are created as is convenient to the user. Some values
        /// are: 'Write', 'Delete', and/or 'Action.'</param>
        /// <param name="retentionPolicy">the retention policy for the events
        /// in the log.</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="storageAccountId">the resource id of the storage
        /// account to which you would like to send the Activity Log.</param>
        /// <param name="serviceBusRuleId">The service bus rule ID of the
        /// service bus namespace in which you would like to have Event Hubs
        /// created for streaming the Activity Log. The rule ID is of the
        /// format: '{service bus resource ID}/authorizationrules/{key
        /// name}'.</param>
        public LogProfileResource(string location, IList<string> locations, IList<string> categories, RetentionPolicy retentionPolicy, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string storageAccountId = default(string), string serviceBusRuleId = default(string))
            : base(location, id, name, type, tags)
        {
            StorageAccountId = storageAccountId;
            ServiceBusRuleId = serviceBusRuleId;
            Locations = locations;
            Categories = categories;
            RetentionPolicy = retentionPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource id of the storage account to which you
        /// would like to send the Activity Log.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the service bus rule ID of the service bus namespace
        /// in which you would like to have Event Hubs created for streaming
        /// the Activity Log. The rule ID is of the format: '{service bus
        /// resource ID}/authorizationrules/{key name}'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceBusRuleId")]
        public string ServiceBusRuleId { get; set; }

        /// <summary>
        /// Gets or sets list of regions for which Activity Log events should
        /// be stored or streamed. It is a comma separated list of valid ARM
        /// locations including the 'global' location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.locations")]
        public IList<string> Locations { get; set; }

        /// <summary>
        /// Gets or sets the categories of the logs. These categories are
        /// created as is convenient to the user. Some values are: 'Write',
        /// 'Delete', and/or 'Action.'
        /// </summary>
        [JsonProperty(PropertyName = "properties.categories")]
        public IList<string> Categories { get; set; }

        /// <summary>
        /// Gets or sets the retention policy for the events in the log.
        /// </summary>
        [JsonProperty(PropertyName = "properties.retentionPolicy")]
        public RetentionPolicy RetentionPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Locations == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Locations");
            }
            if (Categories == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Categories");
            }
            if (RetentionPolicy == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RetentionPolicy");
            }
            if (RetentionPolicy != null)
            {
                RetentionPolicy.Validate();
            }
        }
    }
}
