﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Identity.Client;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Microsoft.Azure.Commands.Common.Authentication
{
    /// <summary>
    /// Interface to the certificate store for authentication
    /// </summary>
    internal sealed class CertificateApplicationCredentialProvider : IApplicationAuthenticationProvider
    {
        private string _certificateThumbprint;

        private string[] _scopes = new string[] { };

        /// <summary>
        /// Create a certificate provider
        /// </summary>
        /// <param name="certificateThumbprint"></param>
        public CertificateApplicationCredentialProvider(string certificateThumbprint)
        {
            this._certificateThumbprint = certificateThumbprint;
        }

        /// <summary>
        /// Authenticate using certificate thumbprint from the datastore
        /// </summary>
        /// <param name="clientId">The active directory client id for the application.</param>
        /// <param name="audience">The intended audience for authentication</param>
        /// <param name="context">The AD AuthenticationContext to use</param>
        /// <returns></returns>
        public async Task<AuthenticationResult> AuthenticateAsync(string clientId, string audience)
        {
            var task = new Task<X509Certificate2>(() =>
            {
                return AzureSession.Instance.DataStore.GetCertificate(this._certificateThumbprint);
            });
            task.Start();
            var certificate = await task.ConfigureAwait(false);

            var clientCredential = new ClientCredential(new ClientAssertionCertificate(certificate));
            var context = new ConfidentialClientApplication(clientId, audience, clientCredential, new TokenCache(), new TokenCache());
            return await context.AcquireTokenForClientAsync(_scopes);
        }
    }
}
