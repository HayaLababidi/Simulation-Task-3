using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        Random r = new Random();

        public void ReadInputFromTestFile(string testPath)
        {
            string [] lines = System.IO.File.ReadAllLines(testPath);
            for(int i = 0; i<lines.Length; i++)
            {
                if(lines[i]== "DowntimeCost")
                {
                    DowntimeCost = int.Parse(lines[++i]);
                   /// i++;
                }
                if (lines[i] == "RepairPersonCost")
                {
                    RepairPersonCost = int.Parse(lines[++i]);
                  //  i++;
                }
                if (lines[i] == "BearingCost")
                {
                    BearingCost = int.Parse(lines[++i]);
                  //  i++;
                }
                if (lines[i] == "NumberOfHours")
                {
                    NumberOfHours = int.Parse(lines[++i]);
                   // i++;
                }
                if (lines[i] == "NumberOfBearings")
                {
                    NumberOfBearings = int.Parse(lines[++i]);
                    //i++;
                }
                if (lines[i] == "RepairTimeForOneBearing")
                {
                    RepairTimeForOneBearing = int.Parse(lines[++i]);
                    //i++;
                }
                if (lines[i] == "RepairTimeForAllBearings")
                {
                    RepairTimeForAllBearings = int.Parse(lines[++i]);
                    //i++;
                }
                if (lines[i] == "DelayTimeDistribution")
                {
                   while(lines[i+1] != "")
                    {
                        TimeDistribution t = new TimeDistribution();
                        t.Time = int.Parse(lines[i + 1].Split(',')[0]);
                        t.Probability = decimal.Parse(lines[i + 1].Split(',')[1].Trim());
                        DelayTimeDistribution.Add(t);
                        i++;
                    }
                    i++;
                }
                if (lines[i] == "BearingLifeDistribution")
                {
                    while (i<lines.Length-1 && lines[i + 1] != "")
                    {
                        TimeDistribution t = new TimeDistribution();
                        t.Time = int.Parse(lines[i + 1].Split(',')[0]);
                        t.Probability = decimal.Parse(lines[i + 1].Split(',')[1].Trim());
                        BearingLifeDistribution.Add(t);
                        i++;
                    }
                    i++;
                }
            }
            CalCumAndRang(BearingLifeDistribution);
            CalCumAndRang(DelayTimeDistribution);
        } 
        void CalCumAndRang(List<TimeDistribution> t )
        {
            int min = 1;
            for (int i = 0; i < t.Count; i++)
            {
                if (i == 0)
                    t[i].CummProbability = t[i].Probability;
                else
                    t[i].CummProbability = t[i].Probability + t[i - 1].CummProbability;
                if (i == 0)
                    t[i].MinRange = 1;
                else
                    t[i].MinRange = int.Parse((Convert.ToDouble(t[i - 1].CummProbability) * 100.0).ToString())+1;

                if (i == t.Count - 1)
                    t[i].MaxRange = 100;
                else
                    t[i].MaxRange = int.Parse((Convert.ToDouble(t[i].CummProbability) * 100.0).ToString());

            }
        }
        int mappedNumber(int rand, List <TimeDistribution>t)
        {
            for (int i = 0; i < t.Count; i++)
            {
                if(rand>=t[i].MinRange && rand <= t[i].MaxRange)
                {
                    return t[i].Time;
                }
            }
            return 0;
        }

        public void SimulateCurrent()
        {
            
            int delay = 0;
            int index;
            for (int i = 0; i < NumberOfBearings; i++)
            {
                index = 0;
                int lifeTime = 0;
                while(lifeTime<NumberOfHours)
                {
                    Bearing b = new Bearing();
                    CurrentSimulationCase c = new CurrentSimulationCase();
                    b.Index = i;
                    b.RandomHours = r.Next(1, 100);
                    b.Hours = mappedNumber(b.RandomHours, BearingLifeDistribution);
                    c.AccumulatedHours = lifeTime + b.Hours;
                    c.RandomDelay = r.Next(1, 100);
                    c.Delay = mappedNumber(c.RandomDelay, DelayTimeDistribution);
                    c.Bearing = b;
                    CurrentSimulationTable.Add(c);
                    delay += c.Delay;
                    lifeTime = c.AccumulatedHours;
                    if(ProposedSimulationTable.Count<=index )
                    {
                        ProposedSimulationCase p = new ProposedSimulationCase();
                        p.Bearings = new List<Bearing>();
                        for(int j = 0; j< NumberOfBearings; j++)
                        {
                            p.Bearings.Add(new Bearing());
                        }
                        p.Bearings[i].Hours = b.Hours;
                        p.Bearings[i].RandomHours = b.RandomHours;
                        p.Bearings[i].Index = b.Index;
                        ProposedSimulationTable.Add(p);
                    }
                    else
                    {
                        ProposedSimulationTable[index].Bearings[i].Hours = b.Hours;
                        ProposedSimulationTable[index].Bearings[i].RandomHours = b.RandomHours;
                        ProposedSimulationTable[index].Bearings[i].Index = b.Index;
                    }
                    index++;
                }
            }
            CurrentPerformanceMeasures.BearingCost = BearingCost * CurrentSimulationTable.Count;
            CurrentPerformanceMeasures.DelayCost = delay * DowntimeCost;
            CurrentPerformanceMeasures.DowntimeCost = CurrentSimulationTable.Count * DowntimeCost * RepairTimeForOneBearing;
            CurrentPerformanceMeasures.RepairPersonCost =CurrentSimulationTable.Count * (Convert.ToDecimal(RepairPersonCost)/60) * RepairTimeForOneBearing;
            CurrentPerformanceMeasures.TotalCost = CurrentPerformanceMeasures.BearingCost + CurrentPerformanceMeasures.DelayCost + CurrentPerformanceMeasures.DowntimeCost + CurrentPerformanceMeasures.RepairPersonCost;

        }
        public void SimulateProposed()
        {
            //  Random rand = new Random();
            int lifeTime = 0;
            int delay = 0;
            for (int i = 0; i < ProposedSimulationTable.Count; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < NumberOfBearings; j++)
                {
                    if (ProposedSimulationTable[i].Bearings[j].Hours == 0)
                    {
                        ProposedSimulationTable[i].Bearings[j].RandomHours = r.Next(1, 100);
                        ProposedSimulationTable[i].Bearings[j].Hours = mappedNumber(ProposedSimulationTable[i].Bearings[j].RandomHours, BearingLifeDistribution);
                        ProposedSimulationTable[i].Bearings[j].Index = j;
                    }
                    if (ProposedSimulationTable[i].Bearings[j].Hours<min)
                    {
                        min = ProposedSimulationTable[i].Bearings[j].Hours;
                    }
                }
                ProposedSimulationTable[i].FirstFailure = min;
                ProposedSimulationTable[i].AccumulatedHours = lifeTime + ProposedSimulationTable[i].FirstFailure;
                ProposedSimulationTable[i].RandomDelay = r.Next(1, 100);
                ProposedSimulationTable[i].Delay = mappedNumber(ProposedSimulationTable[i].RandomDelay, DelayTimeDistribution);
                lifeTime += ProposedSimulationTable[i].FirstFailure;
                delay += ProposedSimulationTable[i].Delay;
               
            }
            while(lifeTime < NumberOfHours)
            {
                int min = int.MaxValue;
                ProposedSimulationCase p = new ProposedSimulationCase();
                p.Bearings = new List<Bearing>();
                for (int j = 0; j < NumberOfBearings; j++)
                {
                    p.Bearings.Add(new Bearing());
                }
                for (int j = 0; j < NumberOfBearings; j++)
                {
                    p.Bearings[j].RandomHours = r.Next(1, 100);
                    p.Bearings[j].Index = j;
                    p.Bearings[j].Hours = mappedNumber(p.Bearings[j].RandomHours, BearingLifeDistribution);
                    if (p.Bearings[j].Hours < min)
                    {
                        min = p.Bearings[j].Hours;
                    }
                }
                p.FirstFailure = min;
                p.AccumulatedHours = lifeTime + p.FirstFailure;
                p.RandomDelay = r.Next(1, 100);
                p.Delay = mappedNumber(p.RandomDelay, DelayTimeDistribution);
                delay += p.Delay;
                ProposedSimulationTable.Add(p);
                lifeTime += min;
            }
            ProposedPerformanceMeasures.BearingCost = BearingCost * NumberOfBearings * ProposedSimulationTable.Count;
            ProposedPerformanceMeasures.DelayCost = delay * DowntimeCost;
            ProposedPerformanceMeasures.DowntimeCost = ProposedSimulationTable.Count * DowntimeCost * RepairTimeForAllBearings;
            ProposedPerformanceMeasures.RepairPersonCost = ProposedSimulationTable.Count * ((decimal)RepairPersonCost/60) * RepairTimeForAllBearings;
            ProposedPerformanceMeasures.TotalCost = ProposedPerformanceMeasures.BearingCost + ProposedPerformanceMeasures.DelayCost + ProposedPerformanceMeasures.DowntimeCost + ProposedPerformanceMeasures.RepairPersonCost;

        }
    }
}
