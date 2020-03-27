// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PrivateLinkScopesOperations operations.
    /// </summary>
    public partial interface IPrivateLinkScopesOperations
    {
        /// <summary>
        /// Gets a list of all Azure Monitor PrivateLinkScopes within a
        /// subscription.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseCommonException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<AzureMonitorPrivateLinkScope>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of Azure Monitor PrivateLinkScopes within a resource
        /// group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseCommonException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<AzureMonitorPrivateLinkScope>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a Azure Monitor PrivateLinkScope.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='scopeName'>
        /// The name of the Azure Monitor PrivateLinkScope resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseCommonException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string scopeName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a Azure Monitor PrivateLinkScope.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='scopeName'>
        /// The name of the Azure Monitor PrivateLinkScope resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseCommonException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AzureMonitorPrivateLinkScope>> GetWithHttpMessagesAsync(string resourceGroupName, string scopeName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates (or updates) a Azure Monitor PrivateLinkScope. Note: You
        /// cannot specify a different value for InstrumentationKey nor AppId
        /// in the Put operation.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='scopeName'>
        /// The name of the Azure Monitor PrivateLinkScope resource.
        /// </param>
        /// <param name='azureMonitorPrivateLinkScopePayload'>
        /// Properties that need to be specified to create or update a Azure
        /// Monitor PrivateLinkScope.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseCommonException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AzureMonitorPrivateLinkScope>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string scopeName, AzureMonitorPrivateLinkScope azureMonitorPrivateLinkScopePayload, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates an existing PrivateLinkScope's tags. To update other fields
        /// use the CreateOrUpdate method.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='scopeName'>
        /// The name of the Azure Monitor PrivateLinkScope resource.
        /// </param>
        /// <param name='tags'>
        /// Resource tags
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseCommonException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AzureMonitorPrivateLinkScope>> UpdateTagsWithHttpMessagesAsync(string resourceGroupName, string scopeName, IDictionary<string, string> tags = default(IDictionary<string, string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a Azure Monitor PrivateLinkScope.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='scopeName'>
        /// The name of the Azure Monitor PrivateLinkScope resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseCommonException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string scopeName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of all Azure Monitor PrivateLinkScopes within a
        /// subscription.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseCommonException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<AzureMonitorPrivateLinkScope>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of Azure Monitor PrivateLinkScopes within a resource
        /// group.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseCommonException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<AzureMonitorPrivateLinkScope>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
