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
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Reply.Cluster.Mercury.Adapters.Schedule.Messages
{
    [DataContract(Name = "ScheduleEvent", Namespace = Constants.MESSAGENAMESPACE)]
    public class ScheduleEvent
    {
        [DataMember]
        public string Uri { get; set; }

        [DataMember]
        public DateTime ExecutionDate { get; set; }
    }

    [MessageContract(IsWrapped = false)]
    public class ScheduleEventMessage
    {
        [MessageBodyMember(Name = "ScheduleEvent")]
        public ScheduleEvent Body { get; set; }
    }
}
