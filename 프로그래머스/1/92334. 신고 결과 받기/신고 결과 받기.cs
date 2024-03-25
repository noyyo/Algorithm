using System;
using System.Collections.Generic;

    public class Solution
    {
        public int[] solution(string[] id_list, string[] report, int k)
        {
            Dictionary<string, HashSet<string>> reportedUser = new Dictionary<string, HashSet<string>>();
            Dictionary<string, int> reportedCount = new Dictionary<string, int>();

            for (int i = 0; i < report.Length; i++)
            {
                string[] split = report[i].Split(" ");
                string reporter = split[0];
                string reported = split[1];
                if (!reportedUser.ContainsKey(reported))
                {
                    reportedUser.Add(reported, new HashSet<string>() { reporter });
                    reportedCount.Add(reported, 1);
                }
                else
                {
                    if (!reportedUser[reported].Contains(reporter))
                    {
                        reportedUser[reported].Add(reporter);
                        reportedCount[reported]++;
                    }
                }
            }
            foreach (KeyValuePair<string, int> reported in reportedCount)
            {
                if (reported.Value < k)
                {
                    reportedUser.Remove(reported.Key);
                }
            }

            Dictionary<string, int> mailToReceive = new Dictionary<string, int>();
            foreach (HashSet<string> reporters in reportedUser.Values)
            {
                foreach (string reporter in reporters)
                {
                    if (!mailToReceive.ContainsKey(reporter))
                        mailToReceive.Add(reporter, 1);
                    else
                        mailToReceive[reporter]++;
                }
            }
            int[] mailReceived = new int[id_list.Length];
            for (int i = 0; i < id_list.Length; i++)
            {
                string id = id_list[i];
                if (mailToReceive.ContainsKey(id))
                    mailReceived[i] = mailToReceive[id];
                else
                    mailReceived[i] = 0;
            }
            return mailReceived;
        }
    }