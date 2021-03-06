#region Copyright
/*
Copyright 2014 Cluster Reply s.r.l.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
#endregion

/// -----------------------------------------------------------------------------------------------------------
/// Module      :  AdoNetAdapterMetadataResolverHandler.cs
/// Description :  This class is used for performing a connection-based retrieval of metadata from the target system.
/// ----------------------------------------------------------------------------------------------------------- 

#region Using Directives
using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.ServiceModel.Channels.Common;
#endregion

namespace Reply.Cluster.Mercury.Adapters.AdoNet
{
    public class AdoNetAdapterMetadataResolverHandler : AdoNetAdapterHandlerBase, IMetadataResolverHandler
    {
        /// <summary>
        /// Initializes a new instance of the AdoNetAdapterMetadataResolverHandler class
        /// </summary>
        public AdoNetAdapterMetadataResolverHandler(AdoNetAdapterConnection connection
            , MetadataLookup metadataLookup)
            : base(connection, metadataLookup)
        {
        }

        #region IMetadataResolver Members

        /// <summary>
        /// Returns a value indicating whether the specified operation metadata is valid
        /// The DateTime field is provided to indicate when this specific operation metadata was last retrieved from the source system.
        /// The method should complete within the specified timespan or throw a timeout exception.
        /// </summary>
        public bool IsOperationMetadataValid(string operationId, DateTime lastUpdatedTimestamp, TimeSpan timeout)
        {
            //
            //TODO: Check the validity of the operation metadata on the target system.
            //      Examples include identifying any relevant changes in the target system, expiration of validity time interval etc.
            //
            throw new NotImplementedException("The method or operation is not implemented.");
        }

        /// <summary>
        /// Returns a value indicating whether the specified type metadata is valid.
        /// The DateTime field is provided to indicate when this specific type metadata was last retrieved from the source system.
        /// The method should complete within the specified timespan or throw a timeout exception.
        /// </summary>
        public bool IsTypeMetadataValid(string typeId, DateTime lastUpdatedTimestamp, TimeSpan timeout)
        {
            //
            //TODO: Check the validity of the type metadata on the target system.
            //      Metadata validity might constitute things like changes, expiry and etc.

            throw new NotImplementedException("The method or operation is not implemented.");
        }

        /// <summary>
        /// Returns an OperationMetadata object resolved from absolute name of the operation metadata object.
        /// The method should complete within the specified time span or throw a timeout exception.
        /// </summary>
        public OperationMetadata ResolveOperationMetadata(string operationId, TimeSpan timeout, out TypeMetadataCollection extraTypeMetadataResolved)
        {
            extraTypeMetadataResolved = null;

            //
            //TODO: Retrieve operation metadata from the target system and present it 
            //      as implementation of the OperationMetadata base class.
            //      Operation metadata represents operation signature, return type and etc.
            //
            throw new NotImplementedException("The method or operation is not implemented.");
        }

        /// <summary>
        /// Returns a TypeMetadata object resolved from the absolute name of the type metadata object.
        /// The method should complete within the specified time span or throw a timeout exception.
        /// </summary>
        public TypeMetadata ResolveTypeMetadata(string typeId, TimeSpan timeout, out TypeMetadataCollection extraTypeMetadataResolved)
        {
            extraTypeMetadataResolved = null;

            //
            //TODO: Retrieve type metadata from the target system and present it 
            //      as an implementation of the OperationMetadata base class.
            //      Type metadata represents target system supported types 
            //      as passed and returned through operation parameters.
            //
            throw new NotImplementedException("The method or operation is not implemented.");
        }

        #endregion IMetadataResolver Members
    }
}
