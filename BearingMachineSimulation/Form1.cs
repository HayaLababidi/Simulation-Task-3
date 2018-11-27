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
        BearingMachineModels.SimulationSystem sys;
        string file_path;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sys = new BearingMachineModels.SimulationSystem();
            file_path = @"..\..\TestCases\" + Constants.FileNames.TestCase3;
            sys.ReadInput(file_path);

            lbl_downtime.Text = sys.DowntimeCost.ToString();
            lbl_repairperson.Text = sys.RepairPersonCost.ToString();
            lbl_bearing.Text = sys.BearingCost.ToString();
            lbl_single.Text = sys.RepairTimeForOneBearing.ToString();
            lbl_AllB.Text = sys.RepairTimeForOneBearing.ToString();

            GrdView_bearings.DataSource = sys.BearingLifeDistribution;
            GrdView_delay.DataSource = sys.DelayTimeDistribution;
            
            MessageBox.Show(TestingManager.Test(sys,Constants.FileNames.TestCase3));
            
        }

        private void tabPageinput_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
                file_path = @"..\..\TestCases\" + Constants.FileNames.TestCase1;
            else if (comboBox1.SelectedIndex == 0)
                file_path = @"..\..\TestCases\" + Constants.FileNames.TestCase2;
            else
                file_path = @"..\..\TestCases\" + Constants.FileNames.TestCase3;

            sys.ReadInput(file_path);
            lbl_downtime.Text = sys.DowntimeCost.ToString();
            lbl_repairperson.Text = sys.RepairPersonCost.ToString();
            lbl_bearing.Text = sys.BearingCost.ToString();
            lbl_single.Text = sys.RepairTimeForOneBearing.ToString();
            lbl_AllB.Text = sys.RepairTimeForOneBearing.ToString();

            GrdView_bearings.DataSource = sys.BearingLifeDistribution;
            GrdView_delay.DataSource = sys.DelayTimeDistribution;

        }

        private void bttn_startsim_Click(object sender, EventArgs e)
        {
            sys.start_simulation(file_path);
        }
    }
}
