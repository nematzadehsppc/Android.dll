using System;
using System.Activities;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using TadbirModels;

namespace CustomerManagement
{
    public class CustomerInfo : CodeActivity<string>
    {
        // =====================================================
        List<int[]> customerIdList = new List<int[]>();
        List<Customer> customerList = new List<Customer>();
        List<Account> accountList = new List<Account>();
        List<DetailAcc> detailAccList = new List<DetailAcc>();
        List<CostCenter> costCenterList = new List<CostCenter>();
        List<Project> projectList = new List<Project>();
        List<AccVsDetail> accVsDetailList = new List<AccVsDetail>();
        List<AccVsCC> accVsCCList = new List<AccVsCC>();
        List<AccVsPrj> accVsPrjList = new List<AccVsPrj>();

        // =====================================================
        public string ip { get; set; }

        public int port { get; set; }

        public string database { get; set; }

        public string version { get; set; }

        public int userId { get; set; }

        public int fpId { get; set; }

        public string serviceKey { get; set; }

        // =====================================================

        public InArgument<string> IP { get; set; }

        public InArgument<int> Port { get; set; }

        public InArgument<string> Database { get; set; }

        public InArgument<string> Version { get; set; }

        public InArgument<int> UserId { get; set; }

        public InArgument<int> FPId { get; set; }

        public InArgument<string> ServiceKey { get; set; }

        // =====================================================

        protected override string Execute(CodeActivityContext context)
        {
            ip = IP.Get(context);
            port = Port.Get(context);
            database = Database.Get(context);
            version = Version.Get(context);
            userId = UserId.Get(context);
            fpId = FPId.Get(context);
            serviceKey = ServiceKey.Get(context);

            customerIdList = getCustomerId();
            if (customerIdList != null && customerIdList.Count != 0)
            {
                for (int i = 0; i < customerIdList.Count; i++)
                {
                    var customer = getCustomerById(customerIdList[i][0]);
                    customerList.Add(customer);

                    if (customer.AccId != "0")
                    {
                        var account = getAccountById(customer.AccId);
                        accountList.Add(account);
                    }

                    if (customer.FAccId != 0)
                    {
                        var detailAcc = getDetailAccById(customer.FAccId);
                        detailAccList.Add(detailAcc);
                    }

                    if (customer.CCId != 0)
                    {
                        var costCenter = getCostCenterById(customer.CCId);
                        costCenterList.Add(costCenter);
                    }

                    if (customer.PrjId != 0)
                    {
                        var project = getProjectById(customer.PrjId);
                        projectList.Add(project);
                    }

                    if (customer.AccId != "0" && customer.FAccId != 0)
                    {
                        var detailAcc = detailAccList[detailAccList.Count - 1];
                        var accVsDetail = getAccVsDetailByFullId(customer.AccId, customer.FAccId, getDetFullId(detailAcc));
                        accVsDetailList.Add(accVsDetail);
                    }

                    if (customer.AccId != "0" && customer.CCId != 0)
                    {
                        var accVsCC = getAccVsCCByFullId(customer.AccId, customer.CCId);
                        accVsCCList.Add(accVsCC);
                    }

                    if (customer.AccId != "0" && customer.PrjId != 0)
                    {
                        var accVsPrj = getAccVsPrjByFullId(customer.AccId, customer.PrjId);
                        accVsPrjList.Add(accVsPrj);
                    }
                }
            }
            string resutl = SerializeResult();
            return resutl;
        }

        private List<int[]> getCustomerId()
        {
            string url = string.Format("Inventory/Customer/RowsIdThatNeedSync?UserId={0}&FPId={1}&key={2}", userId, fpId, serviceKey);
            return GetListAsyncTask<int[]>(url);
        }

        private Customer getCustomerById(int id)
        {
            string url = string.Format("Inventory/Customer/GetCustomerById?Id={0}&FPId={1}&key={2}", id, fpId, serviceKey);
            return GetAsync<Customer>(url);
        }

        private Account getAccountById(string accId)
        {
            string url = string.Format("Account/Account/GetAccountByFullId?FullId={0}&FPId={1}&key={2}", accId, fpId, serviceKey);
            return GetAsync<Account>(url);
        }

        private DetailAcc getDetailAccById(int faccId)
        {
            string url = string.Format("Account/DetailAcc/GetDetailAccById?Id={0}&FPId={1}&key={2}", faccId, fpId, serviceKey);
            return GetAsync<DetailAcc>(url);
        }

        private CostCenter getCostCenterById(int ccId)
        {
            string url = string.Format("Account/CostCenter/GetCostCenterById?Id={0}&FPId={1}&key={2}", ccId, fpId, serviceKey);
            return GetAsync<CostCenter>(url);
        }

        private Project getProjectById(int prjId)
        {
            string url = string.Format("Account/Project/GetProjectById?Id={0}&FPId={1}&key={2}", prjId, fpId, serviceKey);
            return GetAsync<Project>(url);
        }

        private AccVsDetail getAccVsDetailByFullId(string fullId, int faccId, string detFullId)
        {
            string url = string.Format("Account/AccountVector/GetAccVsDetailsByFullId?FullId={0}&DetId={1}&DetFullId={2}&FPId={3}&key={4}", fullId, faccId, detFullId, fpId, serviceKey);
            return GetAsync<AccVsDetail>(url);
        }

        private AccVsCC getAccVsCCByFullId(string fullId, int ccId)
        {
            string url = string.Format("Account/AccountVector/GetAccVsCCByFullId?FullId={0}&CCId={1}&FPId={2}&key={3}", fullId, ccId, fpId, serviceKey);
            return GetAsync<AccVsCC>(url);
        }

        private AccVsPrj getAccVsPrjByFullId(string fullId, int prjId)
        {
            string url = string.Format("Account/AccountVector/GetAccVsPrjByFullId?FullId={0}&PrjId={1}&FPId={2}&key={3}", fullId, prjId, fpId, serviceKey);
            return GetAsync<AccVsPrj>(url);
        }

        private T GetAsync<T>(string uri)
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
            return obj[0];
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

        private string getDetFullId(DetailAcc detailAcc)
        {
            string detFullId = null;

            switch (detailAcc.AccLevel)
            {
                case 4:
                    detFullId = detailAcc.T1;
                    break;
                case 5:
                    detFullId = detailAcc.T1 + detailAcc.T2;
                    break;
                case 6:
                    detFullId = detailAcc.T1 + detailAcc.T2 + detailAcc.T3;
                    break;
                case 7:
                    detFullId = detailAcc.T1 + detailAcc.T2 + detailAcc.T3 + detailAcc.T4;
                    break;
            }

            return detFullId;
        }
        private string SerializeResult()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(new
            {
                Customer = customerList,
                Account = accountList,
                DetailAcc = detailAccList,
                CostCenter = costCenterList,
                Project = projectList,
                AccVsDetail = accVsDetailList,
                AccVsCC = accVsCCList,
                AccVsPrj = accVsPrjList
            });
        }
    }
}
