﻿using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace Couchbase.Views
{
    /// <summary>
    /// Represents the results of a View query.
    /// </summary>
    /// <typeparam name="T">The Type parameter to be used for deserialization by the <see cref="IDataMapper"/>
    /// implementation.</typeparam>
    public class ViewResult<T> : IViewResult<T>
    {
        /// <summary>
        /// The total number of rows.
        /// </summary>
        [JsonProperty("total_rows")]
        public uint TotalRows { get; internal set; }

        /// <summary>
        /// The results of the query if successful.
        /// </summary>
        [JsonProperty("rows")]
        public List<T> Rows { get; internal set; }

        /// <summary>
        /// An error message if one occured.
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; internal set; }

        /// <summary>
        /// The HTTP Status Code for the request
        /// </summary>
        public HttpStatusCode StatusCode { get; internal set; }

        /// <summary>
        /// True if the request was successful
        /// </summary>
        public bool Success { get; internal set; }

        /// <summary>
        /// An optional message returned by the server or the client
        /// </summary>
        [JsonProperty("reason")]
        public string Message { get; internal set; }
    }
}

#region [ License information ]

/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2014 Couchbase, Inc.
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * ************************************************************/

#endregion