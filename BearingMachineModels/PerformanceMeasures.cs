using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearingMachineModels
{
    public class PerformanceMeasures
    {
        public PerformanceMeasures()
        {

        }

        public decimal BearingCost { get; set; }
        public decimal DelayCost { get; set; }
        public decimal DowntimeCost { get; set; }
        public decimal RepairPersonCost { get; set; }
        public decimal TotalCost { get; set; }

        public int total_minutes { get; set; }

        public void Current_PerformanceMeasures(List<CurrentSimulationCase> simulation_table, int DowntimeCost_in, int RepairPersonCost_in, int BearingCost_in, int RepairTimeForOneBearing)
        {
            //Cost of bearings = # bearings × Cost/bearing 
            BearingCost = simulation_table.Count * BearingCost_in;

            //Cost of delay time = total minutes × cost/minute = $1650
            total_minutes = 0;
            for(int i=0;i<simulation_table.Count;i++)
            {
                total_minutes+=simulation_table[i].Delay;
            }
            DelayCost = total_minutes * DowntimeCost_in;

            //Cost of downtime during repair = # bearings × RepairTimeForOneBearing × cost/minute
            DowntimeCost = simulation_table.Count * RepairTimeForOneBearing * DowntimeCost_in;

            
            //Cost of repairpersons = # bearings × RepairTimeForOneBearing × RepairPersonCost_in/minute
            
            float z = 60;
            RepairPersonCost = (simulation_table.Count * RepairTimeForOneBearing * RepairPersonCost_in) / Convert.ToDecimal(z);

            TotalCost = BearingCost + DelayCost + DowntimeCost + RepairPersonCost;
        }

        public void Proposed_PerformanceMeasures(List<ProposedSimulationCase> simulation_table, int numOfBearing, int DowntimeCost_in, int RepairPersonCost_in, int BearingCost_in, int RepairTimeForAllBearing)
        {
            //Cost of bearings = # bearings × Cost/bearing 
            BearingCost = simulation_table.Count * numOfBearing * BearingCost_in;

            //Cost of delay time = total minutes × cost/minute = $1650
            total_minutes = 0;
            for (int i = 0; i < simulation_table.Count; i++)
            {
                total_minutes += simulation_table[i].Delay;
            }
            DelayCost = total_minutes * DowntimeCost_in;

            //Cost of downtime during repair = # bearings × RepairTimeForOneBearing × cost/minute
            DowntimeCost = simulation_table.Count * RepairTimeForAllBearing * DowntimeCost_in;

            //Cost of repairpersons = # bearings × RepairTimeForOneBearing × RepairPersonCost_in/minute
            RepairPersonCost = simulation_table.Count * RepairTimeForAllBearing * RepairPersonCost_in / 60;

            TotalCost = BearingCost + DelayCost + DowntimeCost + RepairPersonCost;
        }
    }
}
