﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Autofac.Configuration {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ConfigurationSettingsReaderResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConfigurationSettingsReaderResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Autofac.Configuration.ConfigurationSettingsReaderResources", typeof(ConfigurationSettingsReaderResources).Assembly);
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
        ///   Looks up a localized string similar to The {0} may not be empty..
        /// </summary>
        internal static string ArgumentMayNotBeEmpty {
            get {
                return ResourceManager.GetString("ArgumentMayNotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find specified configuration file..
        /// </summary>
        internal static string ConfigurationFileNotFound {
            get {
                return ResourceManager.GetString("ConfigurationFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must initialize the section handler on the module before executing the load operation..
        /// </summary>
        internal static string InitializeSectionHandler {
            get {
                return ResourceManager.GetString("InitializeSectionHandler", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No XML content nodes found in configuration. Check the XML reader to ensure configuration is in place..
        /// </summary>
        internal static string NoXmlInConfiguration {
            get {
                return ResourceManager.GetString("NoXmlInConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration section &apos;{0}&apos; could not be read..
        /// </summary>
        internal static string SectionNotFound {
            get {
                return ResourceManager.GetString("SectionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If &apos;name&apos; is specified, &apos;service&apos; must also be specified (component name=&apos;{0}&apos;.).
        /// </summary>
        internal static string ServiceTypeMustBeSpecified {
            get {
                return ResourceManager.GetString("ServiceTypeMustBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to convert object of type &apos;{0}&apos; to type &apos;{1}&apos;..
        /// </summary>
        internal static string TypeConversionUnsupported {
            get {
                return ResourceManager.GetString("TypeConversionUnsupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; specified in the TypeConverterAttribute is not a TypeConverter..
        /// </summary>
        internal static string TypeConverterAttributeTypeNotConverter {
            get {
                return ResourceManager.GetString("TypeConverterAttributeTypeNotConverter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; could not be found. It may require assembly qualification, e.g. &quot;MyType, MyAssembly&quot;..
        /// </summary>
        internal static string TypeNotFound {
            get {
                return ResourceManager.GetString("TypeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; is not valid for the auto-activate attribute. Valid values are &apos;yes&apos; and &apos;no&apos;..
        /// </summary>
        internal static string UnrecognisedAutoActivate {
            get {
                return ResourceManager.GetString("UnrecognisedAutoActivate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; is not valid for the inject-properties attribute. Valid values are &apos;yes&apos; and &apos;no&apos;..
        /// </summary>
        internal static string UnrecognisedInjectProperties {
            get {
                return ResourceManager.GetString("UnrecognisedInjectProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; is not valid for the ownership attribute. Valid values are &apos;lifetime-scope&apos; (the default) and &apos;external&apos;..
        /// </summary>
        internal static string UnrecognisedOwnership {
            get {
                return ResourceManager.GetString("UnrecognisedOwnership", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; is not valid for the instance-scope attribute. Valid values are &apos;single-instance&apos;, &apos;per-dependency&apos; (the default) and &apos;per-lifetime-scope&apos;..
        /// </summary>
        internal static string UnrecognisedScope {
            get {
                return ResourceManager.GetString("UnrecognisedScope", resourceCulture);
            }
        }
    }
}
