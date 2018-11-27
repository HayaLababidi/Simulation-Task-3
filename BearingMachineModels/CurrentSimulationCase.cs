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
            Bearing = new Bearing();
        }
        public Bearing Bearing { get; set; }
        public int AccumulatedHours { get; set; }
        public int RandomDelay { get; set; }
        public int Delay { get; set; }

        

        public List<CurrentSimulationCase> calc_bearing(int NumberOfBearings, int NumberOfHours, List<TimeDistribution> DelayTimeDistribution, List<TimeDistribution> BearingLifeDistribution)
        {
            List<CurrentSimulationCase> CurrentSimulationTable = new List<CurrentSimulationCase>();
            Random rand = new Random();
            int index = 0;
            int j;

            for (int i = 1; i <= NumberOfBearings; i++)
            {
                j = 0;
                while(true)
                {
                    CurrentSimulationCase Current_case = new CurrentSimulationCase();

                    Current_case.Bearing.Index = i;
                    int ran_hours = rand.Next(1, 101);
                    Current_case.Bearing.RandomHours = ran_hours;
                    for(int k=0;k<BearingLifeDistribution.Count;k++)
                    {
                        if(ran_hours<= BearingLifeDistribution[k].MaxRange && ran_hours>=BearingLifeDistribution[k].MinRange)
                        {
                            Current_case.Bearing.Hours = BearingLifeDistribution[k].Time;
                            break;
                        }
                    }
                    if (j == 0)
                        Current_case.AccumulatedHours = Current_case.Bearing.Hours;
                    else
                        Current_case.AccumulatedHours = Current_case.Bearing.Hours + CurrentSimulationTable[index - 1].AccumulatedHours;

                    int ran_delay = rand.Next(1, 101);
                    Current_case.RandomDelay = ran_delay;
                    for (int k = 0; k < DelayTimeDistribution.Count; k++)
                    {
                        if (ran_delay <= DelayTimeDistribution[k].MaxRange && ran_delay >= DelayTimeDistribution[k].MinRange)
                        {
                            Current_case.Delay = DelayTimeDistribution[k].Time;
                            break;
                        }
                    }

                    CurrentSimulationTable.Add(Current_case);
                    index++;
                    if (Current_case.AccumulatedHours >= NumberOfHours)
                        break;
                    else   
                       j++;
                    
                        
                }                    
            }

            return CurrentSimulationTable;
        }

    }
}
