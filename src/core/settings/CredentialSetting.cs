using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace src.core.settings
{
    public class CredentialSetting : BaseSetting
    {

        public string AdminUser(){
            return Get("Admin:User");
        }

        public string AdminPass(){
            return Get("Admin:Pass"); 
        }
    }
}