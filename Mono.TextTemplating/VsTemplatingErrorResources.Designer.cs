﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mono.TextTemplating {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class VsTemplatingErrorResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal VsTemplatingErrorResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Mono.TextTemplating.VsTemplatingErrorResources", typeof(VsTemplatingErrorResources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assembly &quot;{0}&quot; Load Error: {1}.
        /// </summary>
        internal static string AssemblyLoadError {
            get {
                return ResourceManager.GetString("AssemblyLoadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} engine host does not derive from {1}..
        /// </summary>
        internal static string EngineHostNotSubClassOfProcessEngineHost {
            get {
                return ResourceManager.GetString("EngineHostNotSubClassOfProcessEngineHost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error initializing the transformation object..
        /// </summary>
        internal static string ErrorInitializingTransformationObject {
            get {
                return ResourceManager.GetString("ErrorInitializingTransformationObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Error Generating Output.
        /// </summary>
        internal static string ErrorOutput {
            get {
                return ResourceManager.GetString("ErrorOutput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception: {0}.
        /// </summary>
        internal static string Exception {
            get {
                return ResourceManager.GetString("Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error Instanciating Object: .
        /// </summary>
        internal static string ExceptionInstantiatingTransformationObject {
            get {
                return ResourceManager.GetString("ExceptionInstantiatingTransformationObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception Processing Template: {0}.
        /// </summary>
        internal static string ExceptionProcessingTemplate {
            get {
                return ResourceManager.GetString("ExceptionProcessingTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception setting host property on: {0}.
        /// </summary>
        internal static string ExceptionSettingHost {
            get {
                return ResourceManager.GetString("ExceptionSettingHost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception setting session on: {0}.
        /// </summary>
        internal static string ExceptionSettingSession {
            get {
                return ResourceManager.GetString("ExceptionSettingSession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Host Property Not Found On: {0}.
        /// </summary>
        internal static string HostPropertyNotFound {
            get {
                return ResourceManager.GetString("HostPropertyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something bad happened while prepping transformation..
        /// </summary>
        internal static string SessionHostMarshalError {
            get {
                return ResourceManager.GetString("SessionHostMarshalError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Session host session is not initialized for {0}..
        /// </summary>
        internal static string SessionHostSessionNotInitialized {
            get {
                return ResourceManager.GetString("SessionHostSessionNotInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transformation runner, {0}, does not exist. use {1} create a runner..
        /// </summary>
        internal static string TransformationRunnerDoesNotExists {
            get {
                return ResourceManager.GetString("TransformationRunnerDoesNotExists", resourceCulture);
            }
        }
    }
}
