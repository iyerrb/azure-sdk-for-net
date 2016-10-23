// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for ElasticPoolActivityOperations.
    /// </summary>
    public static partial class ElasticPoolActivityOperationsExtensions
    {
            /// <summary>
            /// Returns information about Azure SQL elastic pool activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool for which to get the current
            /// activity.
            /// </param>
            public static System.Collections.Generic.IEnumerable<ElasticPoolActivity> ListByElasticPool(this IElasticPoolActivityOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IElasticPoolActivityOperations)s).ListByElasticPoolAsync(resourceGroupName, serverName, elasticPoolName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about Azure SQL elastic pool activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool for which to get the current
            /// activity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<ElasticPoolActivity>> ListByElasticPoolAsync(this IElasticPoolActivityOperations operations, string resourceGroupName, string serverName, string elasticPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByElasticPoolWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
