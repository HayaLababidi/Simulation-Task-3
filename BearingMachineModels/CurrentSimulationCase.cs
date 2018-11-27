using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearingMachineModels
{
    public class CurrentSimulationCase
    {
        public CurrentSimulationCase()
        {

        }
        public Bearing Bearing { get; set; }
        public int AccumulatedHours { get; set; }
        public int RandomDelay { get; set; }
        public int Delay { get; set; }

        Random rand = new Random();

        public List<CurrentSimulationCase> calc_bearing(int NumberOfBearings, int NumberOfHours, List<TimeDistribution> DelayTimeDistribution, List<TimeDistribution> BearingLifeDistribution)
        {
            List<CurrentSimulationCase> CurrentSimulationTable = new List<CurrentSimulationCase>();

            for (int i = 0; i < NumberOfBearings; i++)
            {
                int j = 0;
                while(true)
                {
                    CurrentSimulationTable[j].Bearing.Index = i;
                    int ran_hours = rand.Next(1, 101);
                    CurrentSimulationTable[j].Bearing.RandomHours = ran_hours;
                    for(int k=0;k<BearingLifeDistribution.Count;k++)
                    {
                        if(ran_hours<= BearingLifeDistribution[k].MaxRange && ran_hours>=BearingLifeDistribution[k].MinRange)
                        {
                            CurrentSimulationTable[j].Bearing.Hours = BearingLifeDistribution[k].Time;
                            break;
                        }
                    }
                    if (j == 0)
                        CurrentSimulationTable[j].AccumulatedHours = CurrentSimulationTable[j].Bearing.Hours;
                    else
                        CurrentSimulationTable[j].AccumulatedHours = CurrentSimulationTable[j].Bearing.Hours + CurrentSimulationTable[j - 1].Bearing.Hours;
                    int ran_delay = rand.Next(0, 10);
                    CurrentSimulationTable[j].RandomDelay = ran_delay;
                    for (int k = 0; k < DelayTimeDistribution.Count; k++)
                    {
                        if (ran_hours <= DelayTimeDistribution[k].MaxRange && ran_hours >= DelayTimeDistribution[k].MinRange)
                        {
                            CurrentSimulationTable[j].Delay = DelayTimeDistribution[k].Time;
                            break;
                        }
                    }
                    if (CurrentSimulationTable[j].AccumulatedHours >= NumberOfHours)
                        break;
                    else
                        j++;
                }                    
            }

            return CurrentSimulationTable;
        }

    }
}
