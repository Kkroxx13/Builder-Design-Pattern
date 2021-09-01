using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{

    //Builder


    public class WindowsMobilePhone : IBuilderMobilePhone
    {
        public void GetBattery()
        {
            throw new NotImplementedException();
        }

        public void GetColor()
        {
            throw new NotImplementedException();
        }


        public void GetModel()
        {
            throw new NotImplementedException();
        }

        public void GetOperatingSystem()
        {
            throw new NotImplementedException();
        }

        public void GetScreen()
        {
            throw new NotImplementedException();
        }
        public MobilePhone GetMobilePhone()
        {
            throw new NotImplementedException();
        }

    }
}
