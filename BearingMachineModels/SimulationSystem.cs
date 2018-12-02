using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BearingMachineModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DelayTimeDistribution = new List<TimeDistribution>();
            BearingLifeDistribution = new List<TimeDistribution>();

            CurrentSimulationTable = new List<CurrentSimulationCase>();
            CurrentPerformanceMeasures = new PerformanceMeasures();

            ProposedSimulationTable = new List<ProposedSimulationCase>();
            ProposedPerformanceMeasures = new PerformanceMeasures();
        }
        
        ///////////// INPUTS /////////////
        public int DowntimeCost { get; set; }
        public int RepairPersonCost { get; set; }
        public int BearingCost { get; set; }
        public int NumberOfHours { get; set; }
        public int NumberOfBearings { get; set; }
        public int RepairTimeForOneBearing { get; set; }
        public int RepairTimeForAllBearings { get; set; }
        public List<TimeDistribution> DelayTimeDistribution { get; set; }
        public List<TimeDistribution> BearingLifeDistribution { get; set; }
        public ProposedSimulationCase Proposed_SimulationCase { get; set; }

        ///////////// OUTPUTS /////////////
        public List<CurrentSimulationCase> CurrentSimulationTable { get; set; }
        public PerformanceMeasures CurrentPerformanceMeasures { get; set; }
        public List<ProposedSimulationCase> ProposedSimulationTable { get; set; }
        public PerformanceMeasures ProposedPerformanceMeasures { get; set; }

        public void start_simulation()
        {
            calc_bearing();
            CurrentPerformanceMeasures = new PerformanceMeasures();
            CurrentPerformanceMeasures.Current_PerformanceMeasures(CurrentSimulationTable, DowntimeCost, RepairPersonCost, BearingCost, RepairTimeForOneBearing);
            fill_ProposedSimulationTable();
            ProposedPerformanceMeasures = new PerformanceMeasures();
            ProposedPerformanceMeasures.Proposed_PerformanceMeasures(ProposedSimulationTable, NumberOfBearings, DowntimeCost, RepairPersonCost, BearingCost, RepairTimeForAllBearings);
        }

        void generate_cumulative_range(List<TimeDistribution> dist)
        {
            int size = dist.Count;

            //fill Cumulative column
            dist[0].CummProbability = dist[0].Probability;
            
            for (int i = 1; i < size; i++)
            {
                dist[i].CummProbability = dist[i - 1].CummProbability + dist[i].Probability;
            }
            
            //fill MinRange , MaxRange
            dist[0].MinRange = 1;
            dist[size - 1].MaxRange = 0;

            if (dist[0].CummProbability == 1)
            {
                dist[0].MaxRange = Convert.ToInt32(dist[0].CummProbability * 100);
                for (int i = 1; i < size; i++)
                {
                    dist[i].MaxRange = 0;
                    dist[i].MinRange = 0;
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    dist[i].MaxRange = Convert.ToInt32(dist[i].CummProbability * 100);
                }
                //dist[0].range = Convert.ToString(dist[0].MinRange) + " - " + Convert.ToString(dist[0].MaxRange);
                for (int i = 1; i < size; i++)
                {
                    dist[i].MinRange = dist[i - 1].MaxRange + 1;
                    //dist[i].range = Convert.ToString(dist[i].MinRange) + " - " + Convert.ToString(dist[i].MaxRange);

                }
            }
            
        }

        public void ReadInput(string filepath)
        {
            string str;
            FileStream fs = new FileStream(filepath, FileMode.Open);
            StreamReader SR = new StreamReader(fs);

            while (SR.Peek() != -1)
            {
                str = SR.ReadLine();
                if (str == "DowntimeCost")
                {
                    DowntimeCost = int.Parse(SR.ReadLine());
                    SR.ReadLine();
                    continue;
                }
                else if (str == "RepairPersonCost")
                {
                    RepairPersonCost = int.Parse(SR.ReadLine());
                    SR.ReadLine();
                    continue;
                }
                else if (str == "BearingCost")
                {
                    BearingCost = int.Parse(SR.ReadLine());
                    SR.ReadLine();
                    continue;
                }
                else if (str == "NumberOfHours")
                {
                    NumberOfHours = int.Parse(SR.ReadLine());
                    SR.ReadLine();
                    continue;
                }
                else if (str == "NumberOfBearings")
                {
                    NumberOfBearings = int.Parse(SR.ReadLine());
                    SR.ReadLine();
                    continue;
                }
                else if (str == "RepairTimeForOneBearing")
                {
                    RepairTimeForOneBearing = int.Parse(SR.ReadLine());
                    SR.ReadLine();
                    continue;
                }
                else if (str == "RepairTimeForAllBearings")
                {
                    RepairTimeForAllBearings = int.Parse(SR.ReadLine());
                    SR.ReadLine();
                    continue;
                }
                else if (str == "DelayTimeDistribution")
                {
                    str = SR.ReadLine();
                    while (str != "")
                    {
                        TimeDistribution TD = new TimeDistribution();
                        string[] substrings = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        TD.Time = int.Parse(substrings[0]);
                        TD.Probability = decimal.Parse(substrings[1]);
                        str = SR.ReadLine();
                        DelayTimeDistribution.Add(TD);
                    }
                    generate_cumulative_range(DelayTimeDistribution);
                    continue;
                }
                else if (str == "BearingLifeDistribution")
                {
                    str = SR.ReadLine();
                    while (str != "" && str != null)
                    {
                        TimeDistribution TD = new TimeDistribution();
                        string[] substrings = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        TD.Time = int.Parse(substrings[0]);
                        TD.Probability = decimal.Parse(substrings[1]);
                        str = SR.ReadLine();
                        BearingLifeDistribution.Add(TD);
                    }
                    generate_cumulative_range(BearingLifeDistribution);
                    continue;
                    
                }
            }
            SR.Close();

        }

        public void calc_bearing()
        {
            Random rand = new Random();
            int index = 0;
            int j;

            for (int i = 1; i <= NumberOfBearings; i++)
            {
                j = 0;
                while (true)
                {
                    CurrentSimulationCase Current_case = new CurrentSimulationCase();

                    Current_case.Bearing.Index = i;
                    int ran_hours = rand.Next(1, 101);
                    Current_case.Bearing.RandomHours = ran_hours;
                    for (int k = 0; k < BearingLifeDistribution.Count; k++)
                    {
                        if (ran_hours <= BearingLifeDistribution[k].MaxRange && ran_hours >= BearingLifeDistribution[k].MinRange)
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

            
        }

        public void fill_ProposedSimulationTable()
        {
            List<List<Bearing>> listOflifetimeBearings = new List<List<Bearing>>();
            Dictionary<int, int> dic_bearings = new Dictionary<int, int>();
            List<Bearing> currentBearings;
            Random rand = new Random();
            int index_currentStable;
            int index_bearings;
            index_currentStable = 0;
            //to fill listOflifetimeBearings list
            for (int i = 1; i <= this.NumberOfBearings; i++)
            {
                //num of changes in one bearing
                index_bearings = 0;
                listOflifetimeBearings.Add(new List<Bearing>());
                while (this.CurrentSimulationTable[index_currentStable].Bearing.Index == i)
                {
                    listOflifetimeBearings[i - 1].Add(new Bearing());
                    listOflifetimeBearings[i - 1][index_bearings] = CurrentSimulationTable[index_currentStable].Bearing;
                    index_bearings++;
                    if (index_currentStable != CurrentSimulationTable.Count - 1)
                        index_currentStable++;
                    else
                        break;
                }
            }
            // fill dictionary with index of the bearing as key & min value of changes in bearing as value  
            for (int i = 1; i <= listOflifetimeBearings.Count; i++)
            {
                dic_bearings.Add(i, listOflifetimeBearings[i - 1].Count);
            }
            int count = dic_bearings.Values.Max();
            int acc_hours = 0;

            for (int i = 0; acc_hours < NumberOfHours; i++)
            {
                currentBearings = new List<Bearing>();
                for (int j = 0; j < this.NumberOfBearings; j++)
                {
                    if (dic_bearings[j + 1] == 0)
                    {
                        int ran_hours = rand.Next(1, 101);
                        System.Threading.Thread.Sleep(10);
                        for (int k = 0; k < BearingLifeDistribution.Count; k++)
                        {
                            if (ran_hours <= BearingLifeDistribution[k].MaxRange && ran_hours >= BearingLifeDistribution[k].MinRange)
                            {
                                currentBearings.Add(new Bearing());
                                currentBearings[j].Hours = BearingLifeDistribution[k].Time;
                                currentBearings[j].RandomHours = ran_hours;
                                currentBearings[j].Index = j + 1;
                                break;
                            }
                        }

                    }
                    else
                    {
                        currentBearings.Add(new Bearing());
                        currentBearings[j] = listOflifetimeBearings[j][i];
                        dic_bearings[j + 1]--;
                        //listOflifetimeBearings[j].RemoveAt(i);
                    }

                }
                if (i != 0)
                {
                    ProposedSimulationTable.Add(new ProposedSimulationCase());
                    ProposedSimulationTable[i].fill_ProposedSimulationRow(currentBearings, ProposedSimulationTable[i - 1].AccumulatedHours, this.DelayTimeDistribution);
                    acc_hours = ProposedSimulationTable[i].AccumulatedHours;
                }
                else
                {
                    ProposedSimulationTable.Add(new ProposedSimulationCase());
                    ProposedSimulationTable[i].fill_ProposedSimulationRow(currentBearings, 0, this.DelayTimeDistribution);

                }
            }
        }
        
    }
}
