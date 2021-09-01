using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class AndroidMobilePhone : IBuilderMobilePhone
    {
        MobilePhone objMobilePhone; //Create object of mobile phone
        public AndroidMobilePhone()
        {
            objMobilePhone = new MobilePhone();
        }
        public void GetBattery()
        {
            objMobilePhone.Battery = 3500;
        }

        public void GetColor()
        {
            objMobilePhone.Color = "Black";
        }

        public void GetOperatingSystem()
        {
            objMobilePhone.OperatingSystem = "OS";
        }

        public void GetScreen()
        {
            objMobilePhone.Screen = "Android Screen";
        }
        public void GetModel()
        {
            objMobilePhone.Model = "Galaxy";
        }
        public MobilePhone GetMobilePhone()
        {
            return objMobilePhone;
        }

    }
}
