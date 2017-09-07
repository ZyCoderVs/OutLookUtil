using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Outlook;
using System.Diagnostics;
using System.Windows.Forms;

namespace OutlookAddIn1
{
    public partial class EmailRibbon
    {
        private OutLookHelper helper { get; set; }
        private void EmailRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            helper = OutLookHelper.GetInstance();
            helper.CreateOutLookApp();
        }

        private void btnEmail_Click(object sender, RibbonControlEventArgs e)
        {
            MailItem mail = helper.CreateMailItem();
            mail.Display();
            mail.Subject = "这是一封普通邮件";
            mail.Body = @"您好：";
        }

        private void btnMetting_Click(object sender, RibbonControlEventArgs e)
        {
            AppointmentItem item = helper.CreateMetting();
            item.Display();
            
        }

        private void btnBrowser_Click(object sender, RibbonControlEventArgs e)
        {
            MessageBox.Show("sb");
        }
    }
}
