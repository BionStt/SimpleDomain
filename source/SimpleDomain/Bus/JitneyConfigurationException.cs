﻿//-------------------------------------------------------------------------------
// <copyright file="JitneyConfigurationException.cs" company="frokonet.ch">
//   Copyright (c) 2015
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

namespace SimpleDomain.Bus
{
    using System;

    /// <summary>
    /// The exception that is thrown when something is wrong with the Jitney configuration
    /// </summary>
    [Serializable]
    public class JitneyConfigurationException : Exception
    {
        /// <summary>
        /// Creates a new instance of <see cref="JitneyConfigurationException"/>
        /// </summary>
        /// <param name="message">The exception message</param>
        public JitneyConfigurationException(string message) : base(message)
        {
        }
    }
}