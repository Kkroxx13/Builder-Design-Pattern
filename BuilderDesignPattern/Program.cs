using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuilderMobilePhone objBuilderMobilePhone = new AndroidMobilePhone();
            DirectorMobilePhone objdirectorMobilePhone = new DirectorMobilePhone(objBuilderMobilePhone);
            objdirectorMobilePhone.Construction();

            Console.WriteLine(objBuilderMobilePhone.GetMobilePhone().ToString());
        }
    }

    
    
}


   
   