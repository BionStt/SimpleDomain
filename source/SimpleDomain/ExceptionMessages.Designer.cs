﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleDomain {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ExceptionMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SimpleDomain.ExceptionMessages", typeof(ExceptionMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An aggregate of type {0} with key {1} could not be found..
        /// </summary>
        public static string AggregateCouldNotBeFound {
            get {
                return ResourceManager.GetString("AggregateCouldNotBeFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot register a Bus when there is no IoC container..
        /// </summary>
        public static string BusCannotBeRegistered {
            get {
                return ResourceManager.GetString("BusCannotBeRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot process message of type {0} since no subscription was found..
        /// </summary>
        public static string CannotProcessMessageWithoutSubscription {
            get {
                return ResourceManager.GetString("CannotProcessMessageWithoutSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot subscribe more than one handler for command of type {0}..
        /// </summary>
        public static string CannotSubscribeMoreThanOneHandlerForCommand {
            get {
                return ResourceManager.GetString("CannotSubscribeMoreThanOneHandlerForCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot restart or reconfigure the CompositionRoot since it has already been started..
        /// </summary>
        public static string CompositionRootHasAlreadyBeenStarted {
            get {
                return ResourceManager.GetString("CompositionRootHasAlreadyBeenStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot register an EventStore when there is no IoC container..
        /// </summary>
        public static string EventStoreCannotBeRegistered {
            get {
                return ResourceManager.GetString("EventStoreCannotBeRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot register a handler when there is no IoC container..
        /// </summary>
        public static string HandlerCannotBeRegistered {
            get {
                return ResourceManager.GetString("HandlerCannotBeRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The local endpoint address has not yet been defined..
        /// </summary>
        public static string LocalEndpointAddressNotDefined {
            get {
                return ResourceManager.GetString("LocalEndpointAddressNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter cannot be empty..
        /// </summary>
        public static string ParameterCannotBeEmpty {
            get {
                return ResourceManager.GetString("ParameterCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter cannot be null..
        /// </summary>
        public static string ParameterCannotBeNull {
            get {
                return ResourceManager.GetString("ParameterCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value {0} must be between {1} and {2}..
        /// </summary>
        public static string ValueMustBeBetweenRange {
            get {
                return ResourceManager.GetString("ValueMustBeBetweenRange", resourceCulture);
            }
        }
    }
}
