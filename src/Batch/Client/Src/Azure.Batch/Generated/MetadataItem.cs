// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A name-value pair associated with a Batch service resource. The Batch service does not assign any meaning to this 
    /// metadata; it is solely for the use of user code.
    /// </summary>
    public partial class MetadataItem : ITransportObjectProvider<Models.MetadataItem>, IPropertyMetadata
    {
        private readonly string name;
        private readonly string value;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataItem"/> class.
        /// </summary>
        /// <param name='name'>The name of the <see cref="MetadataItem"/>.</param>
        /// <param name='value'>The value of the <see cref="MetadataItem"/>.</param>
        public MetadataItem(
            string name,
            string value)
        {
            this.name = name;
            this.value = value;
        }

        internal MetadataItem(Models.MetadataItem protocolObject)
        {
            this.name = protocolObject.Name;
            this.value = protocolObject.Value;
        }

        #endregion Constructors

        #region MetadataItem

        /// <summary>
        /// Gets the name of the <see cref="MetadataItem"/>.
        /// </summary>
        public string Name
        {
            get { return this.name; }
        }

        /// <summary>
        /// Gets the value of the <see cref="MetadataItem"/>.
        /// </summary>
        public string Value
        {
            get { return this.value; }
        }

        #endregion // MetadataItem

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata

        #region Internal/private methods

        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.MetadataItem ITransportObjectProvider<Models.MetadataItem>.GetTransportObject()
        {
            Models.MetadataItem result = new Models.MetadataItem()
            {
                Name = this.Name,
                Value = this.Value,
            };

            return result;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects.
        /// </summary>
        internal static IList<MetadataItem> ConvertFromProtocolCollection(IEnumerable<Models.MetadataItem> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<MetadataItem> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new MetadataItem(o));

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, in a frozen state.
        /// </summary>
        internal static IList<MetadataItem> ConvertFromProtocolCollectionAndFreeze(IEnumerable<Models.MetadataItem> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<MetadataItem> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new MetadataItem(o).Freeze());

            converted = UtilitiesInternal.CreateObjectWithNullCheck(converted, o => o.Freeze());

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, with each object marked readonly
        /// and returned as a readonly collection.
        /// </summary>
        internal static IReadOnlyList<MetadataItem> ConvertFromProtocolCollectionReadOnly(IEnumerable<Models.MetadataItem> protoCollection)
        {
            IReadOnlyList<MetadataItem> converted =
                UtilitiesInternal.CreateObjectWithNullCheck(
                    UtilitiesInternal.CollectionToNonThreadSafeCollection(
                        items: protoCollection,
                        objectCreationFunc: o => new MetadataItem(o).Freeze()), o => o.AsReadOnly());

            return converted;
        }

        #endregion // Internal/private methods
    }
}