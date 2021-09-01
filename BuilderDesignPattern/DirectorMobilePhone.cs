using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class DirectorMobilePhone //Creating the director
    {
        private IBuilderMobilePhone iBuilderMobilePhone;
        public DirectorMobilePhone(IBuilderMobilePhone _iBuilderMobilePhone)
        {
            this.iBuilderMobilePhone = _iBuilderMobilePhone;
        }
        public void Construction()
        {
            this.iBuilderMobilePhone.GetBattery();
            this.iBuilderMobilePhone.GetColor();
            this.iBuilderMobilePhone.GetModel();
            this.iBuilderMobilePhone.GetOperatingSystem();
            this.iBuilderMobilePhone.GetScreen();
        }

    }
}
