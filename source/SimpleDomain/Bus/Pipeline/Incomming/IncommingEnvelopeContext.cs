﻿//-------------------------------------------------------------------------------
// <copyright file="IncommingEnvelopeContext.cs" company="frokonet.ch">
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

namespace SimpleDomain.Bus.Pipeline.Incomming
{
    /// <summary>
    /// The incomming envelope pipeline context
    /// </summary>
    public class IncommingEnvelopeContext : PipelineContext
    {
        /// <summary>
        /// Creates a new intstance of <see cref="IncommingEnvelopeContext"/>
        /// </summary>
        /// <param name="envelope">The incomming envelope</param>
        /// <param name="configuration">Dependency injection for <see cref="IHavePipelineConfiguration"/></param>
        public IncommingEnvelopeContext(Envelope envelope, IHavePipelineConfiguration configuration)
            : base(configuration)
        {
            this.Envelope = envelope;
        }

        /// <summary>
        /// Gets the incomming envelope
        /// </summary>
        public Envelope Envelope { get; private set; }

        /// <summary>
        /// Gets the incomming message
        /// </summary>
        public IMessage Message { get; private set; }

        /// <summary>
        /// Sets the incomming message
        /// </summary>
        public virtual void SetMessage()
        {
            if (this.Message == null)
            {
                this.Message = this.Envelope.Body;
            }
        }
    }
}