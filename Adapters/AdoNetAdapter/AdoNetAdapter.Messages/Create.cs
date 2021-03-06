﻿#region Copyright
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
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Reply.Cluster.Mercury.Adapters.AdoNet.Messages
{
    [CollectionDataContract(Name = Constants.CREATE, ItemName = Constants.ROW, Namespace = Constants.MESSAGENAMESPACE)]
    public class Create<T> : List<T>
    {
        public Create() : base() { }
        public Create(IEnumerable collection) : base(collection.OfType<T>()) { }
        public Create(IEnumerable<T> collection) : base(collection) { }
    }

    [DataContract(Name = Constants.CREATE_RESULT, Namespace = Constants.MESSAGENAMESPACE)]
    public class CreateResult : Result { }

    [MessageContract(IsWrapped = false)]
    public class CreateMessage<T>
    {
        public CreateMessage()
        {
            Body = new Create<T>();
        }

        public CreateMessage(IEnumerable collection)
        {
            Body = new Create<T>(collection);
        }

        public CreateMessage(IEnumerable<T> collection)
        {
            Body = new Create<T>(collection);
        }

        [MessageBodyMember(Name = Constants.CREATE, Namespace = Constants.MESSAGENAMESPACE)]
        public Create<T> Body { get; set; }
    }

    [MessageContract(IsWrapped = false)]
    public class CreateResultMessage
    {
        [MessageBodyMember(Name = Constants.CREATE_RESULT, Namespace = Constants.MESSAGENAMESPACE)]
        public CreateResult Body { get; set; }
    }
}
