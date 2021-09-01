using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public interface IBuilderMobilePhone
    {

        void GetScreen();
        void GetBattery();
        void GetOperatingSystem();
        void GetColor();
        void GetModel();

        //Create product object here
        MobilePhone GetMobilePhone();
    }
}
