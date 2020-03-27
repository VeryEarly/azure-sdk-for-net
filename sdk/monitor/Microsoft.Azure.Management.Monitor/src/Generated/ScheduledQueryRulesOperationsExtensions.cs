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
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ScheduledQueryRulesOperations.
    /// </summary>
    public static partial class ScheduledQueryRulesOperationsExtensions
    {
            /// <summary>
            /// Creates or updates an log search rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            /// <param name='parameters'>
            /// The parameters of the rule to create or update.
            /// </param>
            public static LogSearchRuleResource CreateOrUpdate(this IScheduledQueryRulesOperations operations, string resourceGroupName, string ruleName, LogSearchRuleResource parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, ruleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an log search rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            /// <param name='parameters'>
            /// The parameters of the rule to create or update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LogSearchRuleResource> CreateOrUpdateAsync(this IScheduledQueryRulesOperations operations, string resourceGroupName, string ruleName, LogSearchRuleResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, ruleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an Log Search rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            public static LogSearchRuleResource Get(this IScheduledQueryRulesOperations operations, string resourceGroupName, string ruleName)
            {
                return operations.GetAsync(resourceGroupName, ruleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an Log Search rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LogSearchRuleResource> GetAsync(this IScheduledQueryRulesOperations operations, string resourceGroupName, string ruleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, ruleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update log search Rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            /// <param name='parameters'>
            /// The parameters of the rule to update.
            /// </param>
            public static LogSearchRuleResource Update(this IScheduledQueryRulesOperations operations, string resourceGroupName, string ruleName, LogSearchRuleResourcePatch parameters)
            {
                return operations.UpdateAsync(resourceGroupName, ruleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update log search Rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            /// <param name='parameters'>
            /// The parameters of the rule to update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LogSearchRuleResource> UpdateAsync(this IScheduledQueryRulesOperations operations, string resourceGroupName, string ruleName, LogSearchRuleResourcePatch parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, ruleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Log Search rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            public static void Delete(this IScheduledQueryRulesOperations operations, string resourceGroupName, string ruleName)
            {
                operations.DeleteAsync(resourceGroupName, ruleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Log Search rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IScheduledQueryRulesOperations operations, string resourceGroupName, string ruleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, ruleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List the Log Search rules within a subscription group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IEnumerable<LogSearchRuleResource> ListBySubscription(this IScheduledQueryRulesOperations operations, ODataQuery<LogSearchRuleResource> odataQuery = default(ODataQuery<LogSearchRuleResource>))
            {
                return operations.ListBySubscriptionAsync(odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the Log Search rules within a subscription group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<LogSearchRuleResource>> ListBySubscriptionAsync(this IScheduledQueryRulesOperations operations, ODataQuery<LogSearchRuleResource> odataQuery = default(ODataQuery<LogSearchRuleResource>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the Log Search rules within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IEnumerable<LogSearchRuleResource> ListByResourceGroup(this IScheduledQueryRulesOperations operations, string resourceGroupName, ODataQuery<LogSearchRuleResource> odataQuery = default(ODataQuery<LogSearchRuleResource>))
            {
                return operations.ListByResourceGroupAsync(resourceGroupName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the Log Search rules within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<LogSearchRuleResource>> ListByResourceGroupAsync(this IScheduledQueryRulesOperations operations, string resourceGroupName, ODataQuery<LogSearchRuleResource> odataQuery = default(ODataQuery<LogSearchRuleResource>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
