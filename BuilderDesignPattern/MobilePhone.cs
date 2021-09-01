using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    //This is the PRODUCT that we have created.
    public class MobilePhone
    {
        public string Screen { get; set; }
        public int Battery { get; set; }
        public string OperatingSystem { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }

        public MobilePhone()
        {

        }

        public override string ToString()
        {
            return string.Format("Screen:{0} - Battery:{1} - Operating System:{2} - Color:{3} - Model:{4}", Screen, Battery, OperatingSystem, Color, Model);
        }
    }
}
