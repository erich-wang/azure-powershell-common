// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Version2016_09_01
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BillingMetersOperations.
    /// </summary>
    public static partial class BillingMetersOperationsExtensions
    {
            /// <summary>
            /// Gets a list of meters for a given location.
            /// </summary>
            /// <remarks>
            /// Gets a list of meters for a given location.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingLocation'>
            /// Azure Location of billable resource
            /// </param>
            public static IPage<BillingMeter> List(this IBillingMetersOperations operations, string billingLocation = default(string))
            {
                return operations.ListAsync(billingLocation).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of meters for a given location.
            /// </summary>
            /// <remarks>
            /// Gets a list of meters for a given location.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingLocation'>
            /// Azure Location of billable resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingMeter>> ListAsync(this IBillingMetersOperations operations, string billingLocation = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(billingLocation, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of meters for a given location.
            /// </summary>
            /// <remarks>
            /// Gets a list of meters for a given location.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BillingMeter> ListNext(this IBillingMetersOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of meters for a given location.
            /// </summary>
            /// <remarks>
            /// Gets a list of meters for a given location.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingMeter>> ListNextAsync(this IBillingMetersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
