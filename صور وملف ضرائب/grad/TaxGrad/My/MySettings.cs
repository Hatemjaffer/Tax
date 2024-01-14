namespace TaxGrad.My
{
    using Microsoft.VisualBasic.ApplicationServices;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [EditorBrowsable(EditorBrowsableState.Advanced), CompilerGenerated, GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed class MySettings : ApplicationSettingsBase
    {
        private static MySettings defaultInstance = ((MySettings) SettingsBase.Synchronized(new MySettings()));
        private static bool addedHandler;
        private static object addedHandlerLockObject = new object();

        [EditorBrowsable(EditorBrowsableState.Advanced), DebuggerNonUserCode]
        private static void AutoSaveSettings(object sender, EventArgs e)
        {
            if (MyProject.Application.get_SaveMySettingsOnExit())
            {
                MySettingsProperty.Settings.Save();
            }
        }

        public static MySettings Default
        {
            get
            {
                if (!addedHandler)
                {
                    object addedHandlerLockObject = MySettings.addedHandlerLockObject;
                    ObjectFlowControl.CheckForSyncLockOnValueType(addedHandlerLockObject);
                    lock (addedHandlerLockObject)
                    {
                        if (!addedHandler)
                        {
                            MyProject.Application.add_Shutdown(new ShutdownEventHandler(null, AutoSaveSettings));
                            addedHandler = true;
                        }
                    }
                }
                return defaultInstance;
            }
        }

        [DefaultSettingValue("Data Source=.;Initial Catalog=Gard;Integrated Security=True"), DebuggerNonUserCode, ApplicationScopedSetting, SpecialSetting(SpecialSetting.ConnectionString)]
        public string GardConnectionString =>
            Conversions.ToString(this["GardConnectionString"]);
    }
}

