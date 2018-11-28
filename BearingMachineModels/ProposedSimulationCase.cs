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
        int index_bearings;
        int index_currentStable;
        List<List<Bearing>> listOflifetimeBearings = new List<List<Bearing>>();
        Dictionary<int, int> dic_bearings;
        List<KeyValuePair<int, int>> list_bearings;
        public List<ProposedSimulationCase> fill_ProposedSimulationTable(int NumberOfBearings, int NumberOfHours, List<CurrentSimulationCase> CurrentSimulationTable, List<TimeDistribution> DelayTimeDistribution, List<TimeDistribution> BearingLifeDistribution)
        {
            List<ProposedSimulationCase> proposedSimulationTable = new List<ProposedSimulationCase>();
            ProposedSimulationCase proposedScase = new ProposedSimulationCase();
            index_currentStable = 0;
            //to fill listOflifetimeBearings list
            for (int i = 1; i <= NumberOfBearings; i++)
            {
                //num of changes in one bearing
                index_bearings = 0;
                while (CurrentSimulationTable[index_currentStable].Bearing.Index == i)
                {
                    listOflifetimeBearings[i][index_bearings].Hours = CurrentSimulationTable[index_currentStable].Bearing.Hours;
                    index_bearings++;
                    index_currentStable++;
                }
            }
            proposedScase.AccumulatedHours = 0;
            while (proposedScase.AccumulatedHours < NumberOfHours)
            {
                // fill dictionary with index of the bearing as key & min value of changes in bearing as value  
                for (int i = 1; i <= listOflifetimeBearings.Count; i++)
                {
                    dic_bearings.Add(i, listOflifetimeBearings[i - 1].Count);
                }

                // fill bearings that have the same changes
                for (int i = 0; i <= dic_bearings.Values.Min(); i++)
                {
                    proposedScase = new ProposedSimulationCase();
                    for (int j = 0; j < listOflifetimeBearings.Count; j++)
                    {
                        proposedScase.Bearings[j] = listOflifetimeBearings[j][i];
                        listOflifetimeBearings[j].RemoveAt(i);
                    }
                    int num = 1000000;
                    for (int j = 0; j < proposedScase.Bearings.Count; j++)
                    {
                        if (proposedScase.Bearings[j].Hours < num)
                            num = proposedScase.Bearings[j].Hours;
                    }
                    proposedScase.FirstFailure = num;
                    proposedScase.AccumulatedHours += proposedScase.FirstFailure;
                    int ran_hours = rand.Next(1, 101);
                    System.Threading.Thread.Sleep(10);
                    proposedScase.RandomDelay = ran_hours;
                    for (int j = 0; j < DelayTimeDistribution.Count; j++)
                    {
                        if (ran_hours <= DelayTimeDistribution[j].MaxRange && ran_hours >= DelayTimeDistribution[j].MinRange)
                        {
                            proposedScase.Delay = DelayTimeDistribution[j].Time;
                            break;
                        }
                    }
                    proposedSimulationTable.Add(proposedScase);
                }
                //fill bearings that haven't the num of changes
                list_bearings = dic_bearings.ToList();
                list_bearings.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

                for (int i = dic_bearings.Values.Min() + 1; i <= dic_bearings.Values.Max(); i++)
                {
                    proposedScase = new ProposedSimulationCase();
                    for (int j = 0; j < listOflifetimeBearings.Count; j++)
                    {
                        if (listOflifetimeBearings[j].Count == 0)
                        {

                            for (int k = 0; k < BearingLifeDistribution.Count; k++)
                            {
                                int ran_hours = rand.Next(1, 101);
                                if (ran_hours <= BearingLifeDistribution[k].MaxRange && ran_hours >= BearingLifeDistribution[k].MinRange)
                                {
                                    proposedScase.Bearings[j].Hours = BearingLifeDistribution[k].Time;
                                    break;
                                }
                            }

                        }
                        else
                        {
                            proposedScase.Bearings[j] = listOflifetimeBearings[j][i];
                            listOflifetimeBearings[j].RemoveAt(i);
                        }

                    }
                    int num = 1000000;
                    for (int k = 0; k < proposedScase.Bearings.Count; k++)
                    {
                        if (proposedScase.Bearings[k].Hours < num)
                            num = proposedScase.Bearings[k].Hours;
                    }
                    proposedScase.FirstFailure = num;
                    proposedScase.AccumulatedHours += proposedScase.FirstFailure;
                    int rnd_hours = rand.Next(1, 101);
                    System.Threading.Thread.Sleep(10);
                    proposedScase.RandomDelay = rnd_hours;
                    for (int k = 0; k < DelayTimeDistribution.Count; k++)
                    {
                        if (rnd_hours <= DelayTimeDistribution[k].MaxRange && rnd_hours >= DelayTimeDistribution[k].MinRange)
                        {
                            proposedScase.Delay = DelayTimeDistribution[k].Time;
                            break;
                        }
                    }
                    proposedSimulationTable.Add(proposedScase);
                }

            }


            return proposedSimulationTable;

        }


    }
}
