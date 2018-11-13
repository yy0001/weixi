using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeiXin_Services;

namespace WeiXin_MainForm
{
    public partial class WeiXin_HostForm : Form
    {
        ServiceHost host = null;
        public WeiXin_HostForm()
        {
            InitializeComponent();
            Start();
        }
        void Start()
        {
            try
            {
                host = new ServiceHost(typeof(Service));
                host.Opened += delegate
                {
                    //Console.WriteLine("服务0已经启动，按任意键终止服务！");
                };
                host.Open();
            }
            catch (Exception ex)
            {
                if (host != null)
                {
                    host.Close(); 
                }
            }
        }
        void Close()
        {
            if (host != null)
            {
                host.Close();
            }
        }
    }
}
