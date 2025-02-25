
using EscapeGame.Properties;

namespace EscapeGame.Properties
{


    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
    {

        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        public static Settings Default
        {
            get
            {
                return defaultInstance;
            }
        }
    }
}
//Settings sınıfı, ApplicationSettingsBase sınıfından türetilmiştir. Bu sayede projede kullanılacak olan ayarların temelini oluşturur ve ApplicationSettingsBase sınıfının sağladığı özellikleri kullanabilir.

//CompilerGeneratedAttribute özniteliği, bu sınıfın derleyici tarafından oluşturulduğunu belirtir. 

//GeneratedCodeAttribute özniteliği, bu sınıfın kodun otomatik olarak oluşturulduğunu gösteririr.