using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.core.settings
{
    public class UrlSetting : BaseSetting
    {

        public string BaseSite(){
            return Get("Admin:Url:BaseSite");
        }
    }
}