using System;
using System.Activities;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using TadbirModels;

namespace Tadbir
{
    public class Sync : CodeActivity<FileStream>
    {
        // =====================================================
        List<int[]> customerIdList = new List<int[]>();
        List<Customer> customerList = new List<Customer>();

        // =====================================================
        public string ip { get; set; }

        public int port { get; set; }

        public string database { get; set; }

        public string version { get; set; }

        public int userId { get; set; }

        public int fpId { get; set; }

        public string serviceKey { get; set; }

        // =====================================================

        //public InArgument<string> IP { get; set; }

        //public InArgument<int> Port { get; set; }

        //public InArgument<string> Database { get; set; }

        //public InArgument<string> Version { get; set; }

        //public InArgument<int> UserId { get; set; }

        //public InArgument<int> FPId { get; set; }

        //public InArgument<string> ServiceKey { get; set; }

        // =====================================================

        protected override FileStream Execute(CodeActivityContext context)
        {
            ip = "130.185.76.7";
            port = 9010;
            database = "SARDOMID";
            version = "V3.1";
            userId = 9;
            fpId = 3;
            serviceKey = "1234";

            var customer = getAllCustomer(fpId, userId);
            customerList.AddRange(customer);

            string jsondata = new JavaScriptSerializer().Serialize(customerList);
            File.WriteAllText(System.Web.HttpContext.Current.Server.MapPath("~/JsonData/jsondata.txt"), jsondata);
            return new FileStream(System.Web.HttpContext.Current.Server.MapPath("~/JsonData/jsondata.txt"), FileMode.Create);
        }

        private List<Customer> getAllCustomer(int fpid, int userId)
        {
            string url = string.Format("Inventory/Customer/GetAllCustomer?fpid={0}&userId={1}&key={2}", userId, fpId, serviceKey);
            return GetListAsyncTask<Customer>(url);
        }

        private List<T> GetListAsyncTask<T>(string uri)
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            string baseAddress = string.Format("http://{0}:{1}/{2}/{3}/", ip, port, database, version);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);

            Task<HttpResponseMessage> responseMessage = client.GetAsync(uri);
            responseMessage.Wait();

            Task<string> task = responseMessage.Result.Content.ReadAsStringAsync();
            task.Wait();

            var content = task.Result;
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var obj = serializer.Deserialize<List<T>>(content);
            return obj;
        }
    }
}
