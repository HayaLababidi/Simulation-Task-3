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

            lbl_downtime.Text = sys.DowntimeCost.ToString();
            lbl_repairperson.Text = sys.RepairPersonCost.ToString();
            lbl_bearing.Text = sys.BearingCost.ToString();
            lbl_single.Text = sys.RepairTimeForOneBearing.ToString();
            lbl_AllB.Text = sys.RepairTimeForOneBearing.ToString();

            GrdView_bearings.DataSource = sys.BearingLifeDistribution;
            GrdView_delay.DataSource = sys.DelayTimeDistribution;
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
