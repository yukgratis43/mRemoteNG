﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mRemoteNG.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.1.0.0")]
    internal sealed partial class OptionsDBsPage : global::System.Configuration.ApplicationSettingsBase {
        
        private static OptionsDBsPage defaultInstance = ((OptionsDBsPage)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new OptionsDBsPage())));
        
        public static OptionsDBsPage Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseSQLServer {
            get {
                return ((bool)(this["UseSQLServer"]));
            }
            set {
                this["UseSQLServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mssql")]
        public string SQLServerType {
            get {
                return ((string)(this["SQLServerType"]));
            }
            set {
                this["SQLServerType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SQLHost {
            get {
                return ((string)(this["SQLHost"]));
            }
            set {
                this["SQLHost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SQLReadOnly {
            get {
                return ((bool)(this["SQLReadOnly"]));
            }
            set {
                this["SQLReadOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SQLDatabaseName {
            get {
                return ((string)(this["SQLDatabaseName"]));
            }
            set {
                this["SQLDatabaseName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SQLUser {
            get {
                return ((string)(this["SQLUser"]));
            }
            set {
                this["SQLUser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SQLPass {
            get {
                return ((string)(this["SQLPass"]));
            }
            set {
                this["SQLPass"] = value;
            }
        }
    }
}
