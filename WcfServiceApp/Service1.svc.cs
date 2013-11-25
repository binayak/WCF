using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData()
        {
            return "Data from Service";
        }

        public string GetStudent(string id)
        {
            string[] student = new string[4] {"Adam","Eve","Romeo","Juliet"};
            int val = Convert.ToInt32(id);
            return student[val-1];
        }

        public string SaveStudent(string name)
        { return "test"; }

    }
}
