using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chartUnit
{
    public partial class pump : UserControl
    {
        public pump()
        {
            InitializeComponent();
        }
        public string status;



        [Description("运行状态"), Category("自定义")]

        public string Status
        {
            get { return status; }
            set
            {
                status = value;

                OnStatusChanged();
            }
        }

        private void OnStatusChanged()
        {
            if (status == "run")
            {
                pictureBox1.Image = Properties.Resources.pumpRun;
            }
            if (status == "manual")
            {
                pictureBox1.Image = Properties.Resources.pumpManul;
            }
            if (status == "fault")
            {
                pictureBox1.Image = Properties.Resources.pumpFault;
            }
            if (status == "stop")
            {
                pictureBox1.Image = Properties.Resources.pumpStop;
            }

        }
    }
}
