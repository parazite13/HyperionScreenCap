﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HyperionScreenCap.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.0.0.0")]
        public string hyperionServerIP {
            get {
                return ((string)(this["hyperionServerIP"]));
            }
            set {
                this["hyperionServerIP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("19445")]
        public int hyperionServerPort {
            get {
                return ((int)(this["hyperionServerPort"]));
            }
            set {
                this["hyperionServerPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("110")]
        public int hyperionMessagePriority {
            get {
                return ((int)(this["hyperionMessagePriority"]));
            }
            set {
                this["hyperionMessagePriority"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1500")]
        public int hyperionMessageDuration {
            get {
                return ((int)(this["hyperionMessageDuration"]));
            }
            set {
                this["hyperionMessageDuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("64")]
        public int width {
            get {
                return ((int)(this["width"]));
            }
            set {
                this["width"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("64")]
        public int height {
            get {
                return ((int)(this["height"]));
            }
            set {
                this["height"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int captureInterval {
            get {
                return ((int)(this["captureInterval"]));
            }
            set {
                this["captureInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Info")]
        public global::HyperionScreenCap.Model.NotificationLevel notificationLevel {
            get {
                return ((global::HyperionScreenCap.Model.NotificationLevel)(this["notificationLevel"]));
            }
            set {
                this["notificationLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int monitorIndex {
            get {
                return ((int)(this["monitorIndex"]));
            }
            set {
                this["monitorIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DX11")]
        public global::HyperionScreenCap.Model.CaptureMethod captureMethod {
            get {
                return ((global::HyperionScreenCap.Model.CaptureMethod)(this["captureMethod"]));
            }
            set {
                this["captureMethod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public int dx11MaxFps {
            get {
                return ((int)(this["dx11MaxFps"]));
            }
            set {
                this["dx11MaxFps"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1250")]
        public int dx11FrameCaptureTimeout {
            get {
                return ((int)(this["dx11FrameCaptureTimeout"]));
            }
            set {
                this["dx11FrameCaptureTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("32")]
        public int dx11ImageScalingFactor {
            get {
                return ((int)(this["dx11ImageScalingFactor"]));
            }
            set {
                this["dx11ImageScalingFactor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int dx11AdapterIndex {
            get {
                return ((int)(this["dx11AdapterIndex"]));
            }
            set {
                this["dx11AdapterIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int dx11MonitorIndex {
            get {
                return ((int)(this["dx11MonitorIndex"]));
            }
            set {
                this["dx11MonitorIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool apiEnabled {
            get {
                return ((bool)(this["apiEnabled"]));
            }
            set {
                this["apiEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool apiExcludedTimesEnabled {
            get {
                return ((bool)(this["apiExcludedTimesEnabled"]));
            }
            set {
                this["apiExcludedTimesEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("01/01/2001 10:00:00")]
        public global::System.DateTime apiExcludeTimeStart {
            get {
                return ((global::System.DateTime)(this["apiExcludeTimeStart"]));
            }
            set {
                this["apiExcludeTimeStart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("01/01/2001 22:00:00")]
        public global::System.DateTime apiExcludeTimeEnd {
            get {
                return ((global::System.DateTime)(this["apiExcludeTimeEnd"]));
            }
            set {
                this["apiExcludeTimeEnd"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool pauseOnUserSwitch {
            get {
                return ((bool)(this["pauseOnUserSwitch"]));
            }
            set {
                this["pauseOnUserSwitch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool pauseOnSystemSuspend {
            get {
                return ((bool)(this["pauseOnSystemSuspend"]));
            }
            set {
                this["pauseOnSystemSuspend"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool upgradeRequired {
            get {
                return ((bool)(this["upgradeRequired"]));
            }
            set {
                this["upgradeRequired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[]")]
        public string hyperionTaskConfigurations {
            get {
                return ((string)(this["hyperionTaskConfigurations"]));
            }
            set {
                this["hyperionTaskConfigurations"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool migrateLegacyHyperionConfiguration {
            get {
                return ((bool)(this["migrateLegacyHyperionConfiguration"]));
            }
            set {
                this["migrateLegacyHyperionConfiguration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool captureOnStartup {
            get {
                return ((bool)(this["captureOnStartup"]));
            }
            set {
                this["captureOnStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9191")]
        public int apiPort {
            get {
                return ((int)(this["apiPort"]));
            }
            set {
                this["apiPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool checkUpdateOnStartup {
            get {
                return ((bool)(this["checkUpdateOnStartup"]));
            }
            set {
                this["checkUpdateOnStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool migrateFromBefore2_7 {
            get {
                return ((bool)(this["migrateFromBefore2_7"]));
            }
            set {
                this["migrateFromBefore2_7"] = value;
            }
        }
    }
}
