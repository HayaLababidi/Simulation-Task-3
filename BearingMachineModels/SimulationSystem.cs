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

        ///////////// OUTPUTS /////////////
        public List<CurrentSimulationCase> CurrentSimulationTable { get; set; }
        public PerformanceMeasures CurrentPerformanceMeasures { get; set; }
        public List<ProposedSimulationCase> ProposedSimulationTable { get; set; }
        public PerformanceMeasures ProposedPerformanceMeasures { get; set; }

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
                else
                {
                    str = SR.ReadLine();
                    while (str != "")
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
        
    }
}
