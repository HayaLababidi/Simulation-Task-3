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
        string test_message;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                        
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
            {
                file_path = @"..\..\TestCases\" + Constants.FileNames.TestCase1;
                test_message = Constants.FileNames.TestCase1;
            }
                
            else if (comboBox1.SelectedIndex == 1)
            {
                file_path = @"..\..\TestCases\" + Constants.FileNames.TestCase2;
                test_message = Constants.FileNames.TestCase2;
            }
                
            else
            {
                file_path = @"..\..\TestCases\" + Constants.FileNames.TestCase3;
                test_message = Constants.FileNames.TestCase3;
            }
                

            sys.ReadInput(file_path);

            lbl_NoBearings.Text = sys.NumberOfBearings.ToString();
            lbl_NoHours.Text = sys.NumberOfHours.ToString();
            lbl_downtime.Text = sys.DowntimeCost.ToString();
            lbl_repairperson.Text = sys.RepairPersonCost.ToString();
            lbl_bearing.Text = sys.BearingCost.ToString();
            lbl_single.Text = sys.RepairTimeForOneBearing.ToString();
            lbl_AllB.Text = sys.RepairTimeForAllBearings.ToString();

            lbl_NoBearings.Visible = true;
            lbl_NoHours.Visible = true;
            lbl_downtime.Visible = true;
            lbl_repairperson.Visible = true;
            lbl_bearing.Visible = true;
            lbl_single.Visible = true;
            lbl_AllB.Visible = true;
            lbl_Cdelay.Visible = true;

            GrdView_bearings.DataSource = sys.BearingLifeDistribution;
            GrdView_delay.DataSource = sys.DelayTimeDistribution;

            
        }

        private void bttn_startsim_Click(object sender, EventArgs e)
        {
            sys.start_simulation();

            List<BearingMachineModels.PerformanceMeasures> PerformanceMeasuresList = new List<BearingMachineModels.PerformanceMeasures>();
            PerformanceMeasuresList.Add(sys.CurrentPerformanceMeasures);
            GrdView_CPerformanceMeasures.DataSource = PerformanceMeasuresList;

            DataTable Bearing_replace = new DataTable();
            DataColumn col;

            col = new DataColumn("Index");
            Bearing_replace.Columns.Add(col);

            col = new DataColumn("RandomHours");
            Bearing_replace.Columns.Add(col);

            col = new DataColumn("Hours");
            Bearing_replace.Columns.Add(col);

            col = new DataColumn("AccumulatedHours");
            Bearing_replace.Columns.Add(col);

            col = new DataColumn("RandomDelay");
            Bearing_replace.Columns.Add(col);

            col = new DataColumn("Delay");
            Bearing_replace.Columns.Add(col);

            for (int i = 0; i < sys.CurrentSimulationTable.Count; i++)
                Bearing_replace.Rows.Add(sys.CurrentSimulationTable[i].Bearing.Index, sys.CurrentSimulationTable[i].Bearing.RandomHours, sys.CurrentSimulationTable[i].Bearing.Hours, sys.CurrentSimulationTable[i].AccumulatedHours, sys.CurrentSimulationTable[i].RandomDelay, sys.CurrentSimulationTable[i].Delay);

            GrdView_currenttable.DataSource = Bearing_replace;
            lbl_Cdelay.Text = sys.CurrentPerformanceMeasures.total_minutes.ToString();

            List<BearingMachineModels.PerformanceMeasures> PerformanceMeasuresList2 = new List<BearingMachineModels.PerformanceMeasures>();
            PerformanceMeasuresList2.Add(sys.ProposedPerformanceMeasures);
            GrdView_PPerformancemeasures.DataSource = PerformanceMeasuresList2;
            
            DataTable Bearing_porp = new DataTable();
            DataColumn Pcol;

            int num_bearing = sys.NumberOfBearings;
            for(int i=1; i<=num_bearing; i++)
            {
                Pcol = new DataColumn("Bearing" + i);
                Bearing_porp.Columns.Add(Pcol);
            }

            Pcol = new DataColumn("FirstFailure");
            Bearing_porp.Columns.Add(Pcol);

            Pcol = new DataColumn("AccumulatedHours");
            Bearing_porp.Columns.Add(Pcol);

            Pcol = new DataColumn("RandomDelay");
            Bearing_porp.Columns.Add(Pcol);

            Pcol = new DataColumn("Delay");
            Bearing_porp.Columns.Add(Pcol);

            for (int i = 0; i < sys.ProposedSimulationTable.Count; i++)
            {
                Bearing_porp.Rows.Add();
                for (int j = 0; j < num_bearing; j++)
                    Bearing_porp.Rows[i][j] = sys.ProposedSimulationTable[i].Bearings[j].Hours;
            }        

            for (int i = 0; i < sys.ProposedSimulationTable.Count; i++)
            {
                Bearing_porp.Rows[i][num_bearing] = sys.ProposedSimulationTable[i].FirstFailure;
                Bearing_porp.Rows[i][num_bearing+1] = sys.ProposedSimulationTable[i].AccumulatedHours;
                Bearing_porp.Rows[i][num_bearing+2] = sys.ProposedSimulationTable[i].RandomDelay;
                Bearing_porp.Rows[i][num_bearing+3] = sys.ProposedSimulationTable[i].Delay;
            }

            GrdView_Prposedtable.DataSource = Bearing_porp;

            lbl_Pdelay.Text = sys.ProposedPerformanceMeasures.total_minutes.ToString();

            MessageBox.Show(TestingManager.Test(sys, test_message));
        }

        private void tabPage_Current_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage_Proposed_Click(object sender, EventArgs e)
        {

            
            
        }
    }
}
