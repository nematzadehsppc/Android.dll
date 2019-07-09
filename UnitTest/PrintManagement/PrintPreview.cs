using System;
using System.Windows.Forms;
using System.Activities;
using Tadbir;

namespace Print
{
    public partial class PrintPreview : Form
    {
        public PrintPreview()
        {
            InitializeComponent();
        }

        private void btn_download_pdf_Click(object sender, EventArgs e)
        {
            TadbirPrint tadbirPrint = new TadbirPrint();

            //tadbirPrint.UserId = new InArgument<int>(9);
            //tadbirPrint.WorkspaceId = new InArgument<int>(4);
            //tadbirPrint.FPId = new InArgument<int>(1);
            //tadbirPrint.SubsystemId = new InArgument<int>(5);
            //tadbirPrint.ReportName = new InArgument<string>("ثبت سفارش فروش");
            //tadbirPrint.ParamTypes = new InArgument<string[]> ();
            //tadbirPrint.ParamValues = new InArgument<string[]>();

            MessageBox.Show(WorkflowInvoker.Invoke<String>(tadbirPrint));
        }
    }
}
