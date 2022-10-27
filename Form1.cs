using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Devila_
{
    public partial class FrmBasicThread : Form
    {
        
        public FrmBasicThread()
        {
            InitializeComponent();
        }   
      
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before Starting Thread-");
            MyThreadClass ThreadClass = new MyThreadClass();

            ThreadStart delThread = new ThreadStart(ThreadClass.Thread1);
            
            Thread threadA = new Thread(delThread);
            threadA.Name = "Thread A Process ";

            Thread threadB = new Thread(delThread);
            threadB.Name = "Thread B Process ";

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            Console.WriteLine("-End of Thread-");
            label1.Text = "-End of Thread-";
        }
    }
}
