// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Internal.Resources.Models
{
    using Azure;
    using Management;
    using Internal;
    using Resources;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Deployment information.
    /// </summary>
    public partial class DeploymentExtended
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentExtended class.
        /// </summary>
        public DeploymentExtended() { }

        /// <summary>
        /// Initializes a new instance of the DeploymentExtended class.
        /// </summary>
        /// <param name="name">The name of the deployment.</param>
        /// <param name="id">The ID of the deployment.</param>
        /// <param name="properties">Deployment properties.</param>
        public DeploymentExtended(string name, string id = default(string), DeploymentPropertiesExtended properties = default(DeploymentPropertiesExtended))
        {
            Id = id;
            Name = name;
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the ID of the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets deployment properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public DeploymentPropertiesExtended Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}

