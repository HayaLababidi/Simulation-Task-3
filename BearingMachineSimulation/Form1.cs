using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BearingMachineTesting;

namespace BearingMachineSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BearingMachineModels.SimulationSystem sys = new BearingMachineModels.SimulationSystem();
            sys.ReadInput(@"..\..\TestCases\"+Constants.FileNames.TestCase3);
            
            //sys.SimulateCurrent();
            //sys.SimulateProposed();
            MessageBox.Show(TestingManager.Test(sys,Constants.FileNames.TestCase3));
            
        }

        private void tabPageinput_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
