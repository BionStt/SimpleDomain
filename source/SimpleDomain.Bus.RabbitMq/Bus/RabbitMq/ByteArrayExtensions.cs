﻿//-------------------------------------------------------------------------------
// <copyright file="ByteArrayExtensions.cs" company="frokonet.ch">
//   Copyright (c) 2014-2018
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace SimpleDomain.Bus.RabbitMq
{
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// Extensions methods for byte arrays
    /// </summary>
    public static class ByteArrayExtensions
    {
        private static readonly JsonSerializerSettings DefaultSerializerSettings =
            new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Objects
                };

        /// <summary>
        /// Deserializes a Json string encoded in a byte array to an untyped object
        /// </summary>
        /// <param name="byteArray">The byte array</param>
        /// <returns>A deserialized untyped object</returns>
        public static object Deserialize(this byte[] byteArray)
        {
            var json = Encoding.UTF8.GetString(byteArray);
            return JsonConvert.DeserializeObject(json, DefaultSerializerSettings);
        }
    }
}