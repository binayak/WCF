using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebInvoke(Method="GET", UriTemplate="/GetData", RequestFormat=WebMessageFormat.Json, ResponseFormat=WebMessageFormat.Json)]
        string GetData();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetStudent/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string GetStudent(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/SaveStudent", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        string SaveStudent(string name);
                
     }

    [DataContract]
    public class Student
    {
        int studentIndex;

        [DataMember]
        public string[] student
        {
            get
            {
                return student;
            }
            set
            {
                student = value;
            }
        }
        
    }
          
}
