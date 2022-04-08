using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace src.core.settings
{
    public abstract class BaseSetting
    {
        private IConfiguration config { get; set; }

        public BaseSetting()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile($"appsettings.json", true, true);

           this.config = builder.Build();
        }

        public string Get(string path){
            return this.config[path];
        }


    }
}