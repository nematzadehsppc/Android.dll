using System;
using System.Activities;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CustomerManagement
{
    public partial class CustomeInfo : Form
    {
        public CustomeInfo()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            CustomerInfo customerInfo = new CustomerInfo();
            customerInfo.IP = new InArgument<string>(txt_box_ip.Text);
            customerInfo.Port = new InArgument<int>(Int32.Parse(txt_box_port.Text));                            
            customerInfo.Database = new InArgument<string>(txt_box_database.Text);
            customerInfo.Version = new InArgument<string>("V" + txt_box_version.Text);
            customerInfo.UserId = new InArgument<int>(Int32.Parse(txt_box_userId.Text));
            customerInfo.FPId = new InArgument<int>(Int32.Parse(txt_box_fpId.Text));
            customerInfo.ServiceKey = new InArgument<string>(txt_box_service_key.Text);
            string jsonOutput = WorkflowInvoker.Invoke<string>(customerInfo);

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(docPath, "jsonOutput.txt");
            File.WriteAllText(filePath, jsonOutput);

            
            if (Process.GetProcessesByName("Notepad").Length != 0)
            {
                for (int i = 0; i < Process.GetProcessesByName("Notepad").Length; i++)
                {
                    if (Process.GetProcessesByName("Notepad")[i].MainWindowTitle.Equals("jsonOutput.txt - Notepad"))
                    {
                        Process.GetProcessesByName("Notepad")[i].Kill();
                        break;
                    }
                }
                Process.Start("Notepad.exe", filePath);
            }
            else
            {
                Process.Start("Notepad.exe", filePath);
            }


        }
    }
}
