// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace RTMAutoRest.Clients.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class TestComplex
    {
        /// <summary>
        /// Initializes a new instance of the TestComplex class.
        /// </summary>
        public TestComplex() { }

        /// <summary>
        /// Initializes a new instance of the TestComplex class.
        /// </summary>
        public TestComplex(long? id = default(long?), IList<string> names = default(IList<string>))
        {
            Id = id;
            Names = names;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public IList<string> Names { get; set; }

    }
}