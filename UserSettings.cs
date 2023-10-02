using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOTArbitradorPUTs
{
    internal class UserSettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        public string UsuarioIOL
        {
            get
            {
                return ((string)this["UsuarioIOL"]);
            }
            set
            {
                this["UsuarioIOL"] = (string)value;
            }
        }

    }
}
