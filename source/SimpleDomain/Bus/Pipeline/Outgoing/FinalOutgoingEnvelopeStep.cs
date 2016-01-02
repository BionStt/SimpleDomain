﻿//-------------------------------------------------------------------------------
// <copyright file="FinalOutgoingEnvelopeStep.cs" company="frokonet.ch">
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

namespace SimpleDomain.Bus.Pipeline.Outgoing
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// The final outgoing envelope pipeline step
    /// </summary>
    public class FinalOutgoingEnvelopeStep : OutgoingEnvelopeStep
    {
        private readonly Func<Envelope, Task> handleEnvelopeAsync;

        /// <summary>
        /// Creates a new instance of <see cref="FinalOutgoingEnvelopeStep"/>
        /// </summary>
        /// <param name="handleEnvelopeAsync">The last async action to be performed for an outgoing envelope</param>
        public FinalOutgoingEnvelopeStep(Func<Envelope, Task> handleEnvelopeAsync)
        {
            this.handleEnvelopeAsync = handleEnvelopeAsync;
            this.Name = "Final Outgoing Envelope Step";
        }

        /// <inheritdoc />
        public override string Name { get; }

        /// <inheritdoc />
        public override Task InvokeAsync(OutgoingEnvelopeContext context, Func<Task> next)
        {
            return this.handleEnvelopeAsync(context.Envelope);
        }
    }
}