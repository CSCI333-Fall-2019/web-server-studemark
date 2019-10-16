using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebServer {
   public partial class Form1 : Form {
      public Form1() {
         InitializeComponent();

      }

      private void Button1_Click(object sender, EventArgs e) {
         button1.Enabled = false;
         button2.Enabled = true;
         System.Threading.ThreadPool.QueueUserWorkItem(StartWebListener, this);
      }
      private void Button2_Click(object sender, EventArgs e) {
         button2.Enabled = false;
         button1.Enabled = true;
      }

      public void StartWebListener(Object obj) {
         Form1 lForm = (Form1)obj;
      }
     
   }
}
