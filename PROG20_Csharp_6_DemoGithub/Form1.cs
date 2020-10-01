using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG20_Csharp_6_DemoGithub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 10;
            i = 12;
            
            //Detta är ändringar som en annan utvecklare gör och pushar upp (så vi kan testa pull)
            int newValue = 12345;
        }
    }
}
