using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AdministratorApp
{
    public static class CustomMessageBox
    {
        public static DialogResult ShowMessage(string message, string caption, MessageBoxButtons button, int iconNumber)
        {
            DialogResult dResult = DialogResult.None;
            switch(button)
            {
                case MessageBoxButtons.OK:
                    using (ShowRowData msgOK = new ShowRowData())
                    {
                        msgOK.Text = caption;
                        msgOK.Message = message;
                        switch(iconNumber)
                        {
                            case 1:
                                msgOK.MessageIcon = AdministratorApp.Properties.Resources.iconClient;
                                break;
                            case 2:
                                msgOK.MessageIcon = AdministratorApp.Properties.Resources.orderIcon;
                                break;
                        }
                        dResult = msgOK.ShowDialog();
                    }
                    break;
            }
            return dResult;
        }
    }
}
