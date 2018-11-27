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

            lbl_NoBearings.Visible = true;
            lbl_NoHours.Visible = true;
            lbl_downtime.Visible = true;
            lbl_repairperson.Visible = true;
            lbl_bearing.Visible = true;
            lbl_single.Visible = true;
            lbl_AllB.Visible = true;

            lbl_NoBearings.Text = sys.NumberOfBearings.ToString();
            lbl_NoHours.Text = sys.NumberOfHours.ToString();
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
            sys = new BearingMachineModels.SimulationSystem();

            if (comboBox1.SelectedIndex == 0)
                file_path = @"..\..\TestCases\" + Constants.FileNames.TestCase1;
            else if (comboBox1.SelectedIndex == 0)
                file_path = @"..\..\TestCases\" + Constants.FileNames.TestCase2;
            else
                file_path = @"..\..\TestCases\" + Constants.FileNames.TestCase3;

            sys.ReadInput(file_path);

            lbl_NoBearings.Text = sys.NumberOfBearings.ToString();
            lbl_NoHours.Text = sys.NumberOfHours.ToString();
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

        private void tabPage_Current_Click(object sender, EventArgs e)
        {
            List<BearingMachineModels.PerformanceMeasures> PerformanceMeasuresList = new List<BearingMachineModels.PerformanceMeasures>();
            PerformanceMeasuresList.Add(sys.CurrentPerformanceMeasures);
            GrdView_CPerformanceMeasures.DataSource = PerformanceMeasuresList;
            GrdView_currenttable.DataSource = sys.CurrentSimulationTable;
        }

        private void tabPage_Proposed_Click(object sender, EventArgs e)
        {

            List<BearingMachineModels.PerformanceMeasures> PerformanceMeasuresList = new List<BearingMachineModels.PerformanceMeasures>();
            PerformanceMeasuresList.Add(sys.ProposedPerformanceMeasures);
            GrdView_PPerformancemeasures.DataSource = PerformanceMeasuresList;
            GrdView_Prposedtable.DataSource = sys.ProposedSimulationTable;
            //lbl_Pdelay.Text = ;
        }
    }
}
