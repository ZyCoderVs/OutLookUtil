using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using OutLook = Microsoft.Office.Interop.Outlook;
namespace OutlookAddIn1
{
    public class OutLookHelper
    {
        private Application outlookApp { get; set; }
        private static Object objLock = new object();
        private static OutLookHelper olh { get; set; }
        private OutLookHelper()
        { }
        public static OutLookHelper GetInstance()
        {
            if (olh==null)
            {
                lock (objLock)
                {
                    if (olh==null)
                    {
                        olh = new OutLookHelper();
                    }
                }
            }
            return olh;
        }
        public void CreateOutLookApp()
        {
            outlookApp = new Application();
        }
        public MailItem CreateMailItem()
        {
            MailItem mailItem = outlookApp.CreateItem(OlItemType.olMailItem);
            //mailItem.Display();
            return mailItem;
        }
        public AppointmentItem CreateMetting()
        {
            AppointmentItem mailIten = outlookApp.CreateItem(OlItemType.olAppointmentItem);
            return mailIten;
        }
    }
}
