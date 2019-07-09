using System;
using System.Activities;
using System.Drawing;
using System.Windows.Forms;

namespace ImageManagement
{
    public partial class ImageForm : Form
    {
        public ImageForm()
        {
            InitializeComponent();
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            Tadbir.Image Image = new Tadbir.Image();

            Image.IP = new InArgument<string>("79.127.99.82");
            Image.Port = new InArgument<string>("9020");
            Image.dbName = new InArgument<string>("SARDOMID");
            Image.Version = new InArgument<string>("V3.0");
            Image.Group = new InArgument<string>("Inventory");
            Image.Entity = new InArgument<string>("Image");
            Image.Function = new InArgument<string>("getImageByImageId");
            Image.MerchId = new InArgument<int>(216);
            Image.FPId = new InArgument<int>(3);
            Image.SysId = new InArgument<int>(4);
            Image.FormId = new InArgument<int>(2);
            Image.ServiceKey = new InArgument<string>("1234");
            Image.ImageId = new InArgument<int>(365);
            pictureBoxRequest.Image = WorkflowInvoker.Invoke<Image>(Image);
        }
    }
}
