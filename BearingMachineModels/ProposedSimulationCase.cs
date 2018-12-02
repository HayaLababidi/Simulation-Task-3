using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BearingMachineModels
{
    public class ProposedSimulationCase
    {
        public ProposedSimulationCase()
        {
            Bearings = new List<Bearing>();
        }

        public List<Bearing> Bearings { get; set; }
        public int FirstFailure { get; set; }
        public int AccumulatedHours { get; set; }
        public int RandomDelay { get; set; }
        public int Delay { get; set; }
        Random rand = new Random();
        
        public void fill_ProposedSimulationRow(List<Bearing> currentBearings, int AccumuHours, List<TimeDistribution> DelayTimeDistribution)
        {
            
            this.Bearings = currentBearings;
            int num = 1000000;
            for (int i = 0; i < currentBearings.Count; i++)
            {
                if (currentBearings[i].Hours < num)
                    num = currentBearings[i].Hours;
            }
            this.FirstFailure = num;
            this.AccumulatedHours = num + AccumuHours;

            int ran_hours = rand.Next(1, 101);
            System.Threading.Thread.Sleep(10);
            this.RandomDelay = ran_hours;
            for (int j = 0; j < DelayTimeDistribution.Count; j++)
            {
                if (ran_hours <= DelayTimeDistribution[j].MaxRange && ran_hours >= DelayTimeDistribution[j].MinRange)
                {
                    this.Delay = DelayTimeDistribution[j].Time;
                    break;
                }
            }

        }


    }
}
