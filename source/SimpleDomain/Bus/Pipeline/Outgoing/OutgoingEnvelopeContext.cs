//-------------------------------------------------------------------------------
// <copyright file="OutgoingEnvelopeContext.cs" company="frokonet.ch">
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
    /// <summary>
    /// The outgoing envelope pipeline context
    /// </summary>
    public class OutgoingEnvelopeContext : PipelineContext
    {
        /// <summary>
        /// Creates a new instance of <see cref="OutgoingEnvelopeContext"/>
        /// </summary>
        /// <param name="envelope">The outgoing envelope</param>
        /// <param name="configuration">Dependency injection for <see cref="IHavePipelineConfiguration"/></param>
        public OutgoingEnvelopeContext(Envelope envelope, IHavePipelineConfiguration configuration)
            : base(configuration)
        {
            this.Envelope = envelope;
        }

        /// <summary>
        /// Gets the outgoing envelope
        /// </summary>
        public Envelope Envelope { get; private set; }
    }
}