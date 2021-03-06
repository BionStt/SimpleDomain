﻿//-------------------------------------------------------------------------------
// <copyright file="FeatureNotFoundException.cs" company="frokonet.ch">
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

namespace SimpleDomain
{
    using System;

    /// <summary>
    /// Exception that is thrown when a requested feature was not found
    /// </summary>
    /// <typeparam name="TFeature">The type of the feature</typeparam>
    public class FeatureNotFoundException<TFeature> : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureNotFoundException{TFeature}"/> class.
        /// </summary>
        public FeatureNotFoundException() : base($"Feature of type {typeof(TFeature).Name} not found.")
        {
        }
    }
}