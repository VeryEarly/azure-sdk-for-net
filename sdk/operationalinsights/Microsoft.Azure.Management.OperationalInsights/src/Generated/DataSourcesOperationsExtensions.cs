// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DataSourcesOperations.
    /// </summary>
    public static partial class DataSourcesOperationsExtensions
    {
            /// <summary>
            /// Create or update a data source.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace that will contain the datasource
            /// </param>
            /// <param name='dataSourceName'>
            /// The name of the datasource resource.
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to create or update a datasource.
            /// </param>
            public static DataSource CreateOrUpdate(this IDataSourcesOperations operations, string resourceGroupName, string workspaceName, string dataSourceName, DataSource parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, dataSourceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a data source.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace that will contain the datasource
            /// </param>
            /// <param name='dataSourceName'>
            /// The name of the datasource resource.
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to create or update a datasource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataSource> CreateOrUpdateAsync(this IDataSourcesOperations operations, string resourceGroupName, string workspaceName, string dataSourceName, DataSource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, dataSourceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a data source instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace that contains the datasource.
            /// </param>
            /// <param name='dataSourceName'>
            /// Name of the datasource.
            /// </param>
            public static void Delete(this IDataSourcesOperations operations, string resourceGroupName, string workspaceName, string dataSourceName)
            {
                operations.DeleteAsync(resourceGroupName, workspaceName, dataSourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a data source instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace that contains the datasource.
            /// </param>
            /// <param name='dataSourceName'>
            /// Name of the datasource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDataSourcesOperations operations, string resourceGroupName, string workspaceName, string dataSourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, dataSourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a datasource instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace that contains the datasource.
            /// </param>
            /// <param name='dataSourceName'>
            /// Name of the datasource
            /// </param>
            public static DataSource Get(this IDataSourcesOperations operations, string resourceGroupName, string workspaceName, string dataSourceName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, dataSourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a datasource instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// Name of the Log Analytics Workspace that contains the datasource.
            /// </param>
            /// <param name='dataSourceName'>
            /// Name of the datasource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataSource> GetAsync(this IDataSourcesOperations operations, string resourceGroupName, string workspaceName, string dataSourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, dataSourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the first page of data source instances in a workspace with the link
            /// to the next page.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The workspace that contains the data sources.
            /// </param>
            /// <param name='skiptoken'>
            /// Starting point of the collection of data source instances.
            /// </param>
            public static IPage<DataSource> ListByWorkspace(this IDataSourcesOperations operations, ODataQuery<DataSourceFilter> odataQuery, string resourceGroupName, string workspaceName, string skiptoken = default(string))
            {
                return operations.ListByWorkspaceAsync(odataQuery, resourceGroupName, workspaceName, skiptoken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the first page of data source instances in a workspace with the link
            /// to the next page.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The workspace that contains the data sources.
            /// </param>
            /// <param name='skiptoken'>
            /// Starting point of the collection of data source instances.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DataSource>> ListByWorkspaceAsync(this IDataSourcesOperations operations, ODataQuery<DataSourceFilter> odataQuery, string resourceGroupName, string workspaceName, string skiptoken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByWorkspaceWithHttpMessagesAsync(odataQuery, resourceGroupName, workspaceName, skiptoken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the first page of data source instances in a workspace with the link
            /// to the next page.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DataSource> ListByWorkspaceNext(this IDataSourcesOperations operations, string nextPageLink)
            {
                return operations.ListByWorkspaceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the first page of data source instances in a workspace with the link
            /// to the next page.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DataSource>> ListByWorkspaceNextAsync(this IDataSourcesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByWorkspaceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
