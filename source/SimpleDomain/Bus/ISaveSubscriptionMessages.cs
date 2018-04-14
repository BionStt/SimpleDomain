﻿//-------------------------------------------------------------------------------
// <copyright file="ISaveSubscriptionMessages.cs" company="frokonet.ch">
//   Copyright (C) frokonet.ch, 2014-2018
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
    using System.Threading.Tasks;

    /// <summary>
    /// The subscription message persiter interface
    /// </summary>
    public interface ISaveSubscriptionMessages
    {
        /// <summary>
        /// Persists an event subscription
        /// </summary>
        /// <param name="subscriptionMessage">The subscription message</param>
        /// <returns>A <see cref="Task"/> since this is an async method</returns>
        Task SaveAsync(SubscriptionMessage subscriptionMessage);
    }
}