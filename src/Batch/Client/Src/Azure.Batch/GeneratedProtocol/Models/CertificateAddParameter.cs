// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// A certificate that can be installed on compute nodes and can be used to
    /// authenticate operations on the machine.
    /// </summary>
    public partial class CertificateAddParameter
    {
        /// <summary>
        /// Initializes a new instance of the CertificateAddParameter class.
        /// </summary>
        public CertificateAddParameter() { }

        /// <summary>
        /// Initializes a new instance of the CertificateAddParameter class.
        /// </summary>
        /// <param name="thumbprint">The X.509 thumbprint of the certificate.
        /// This is a sequence of up to 40 hex digits (it may include spaces
        /// but these are removed).</param>
        /// <param name="thumbprintAlgorithm">The algorithm used to derive the
        /// thumbprint. This must be sha1.</param>
        /// <param name="data">The base64-encoded contents of the certificate.
        /// The maximum size is 10KB.</param>
        /// <param name="certificateFormat">The format of the certificate
        /// data.</param>
        /// <param name="password">The password to access the certificate's
        /// private key.</param>
        public CertificateAddParameter(string thumbprint, string thumbprintAlgorithm, string data, CertificateFormat? certificateFormat = default(CertificateFormat?), string password = default(string))
        {
            Thumbprint = thumbprint;
            ThumbprintAlgorithm = thumbprintAlgorithm;
            Data = data;
            CertificateFormat = certificateFormat;
            Password = password;
        }

        /// <summary>
        /// Gets or sets the X.509 thumbprint of the certificate. This is a
        /// sequence of up to 40 hex digits (it may include spaces but these
        /// are removed).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or sets the algorithm used to derive the thumbprint. This must
        /// be sha1.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "thumbprintAlgorithm")]
        public string ThumbprintAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets the base64-encoded contents of the certificate. The
        /// maximum size is 10KB.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "data")]
        public string Data { get; set; }

        /// <summary>
        /// Gets or sets the format of the certificate data.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'pfx', 'cer', 'unmapped'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "certificateFormat")]
        public CertificateFormat? CertificateFormat { get; set; }

        /// <summary>
        /// Gets or sets the password to access the certificate's private key.
        /// </summary>
        /// <remarks>
        /// This is required if the certificate format is pfx. It should be
        /// omitted if the certificate format is cer.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Thumbprint == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Thumbprint");
            }
            if (ThumbprintAlgorithm == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ThumbprintAlgorithm");
            }
            if (Data == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Data");
            }
        }
    }
}
