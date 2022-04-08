using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.core.settings;

namespace src.core.domain
{
    public class WebDriverAdmin : BaseWebDriver
    {
        public WebDriverAdmin()
        {
            this.NavigateTo(url.BaseSite());
        }

        public void Login(){
            SetTextValueById("id_username", credential.AdminUser());
            SetTextValueById("id_password", credential.AdminPass());
            ClickButtonSubmit();
            Wait(3000);
        }

        public void Login(string user, string pass){
            SetTextValueById("id_username", user);
            SetTextValueById("id_password", pass);
            ClickButtonSubmit();
        }

        public void AddAlgorithm(){

        }

    }
}