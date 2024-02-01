using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        // 플레이어의 순위 Dictionary로 관리
        Dictionary<string, int> playerRanks = new Dictionary<string, int>();
        for (int i = 0; i < players.Length; i++)
        {
            playerRanks.Add(players[i], i);
        }
        
        int rank;
        string aheadPlayer;
        foreach (string player in callings)
        {
            rank = playerRanks[player];
            aheadPlayer = players[rank - 1];
            players[rank - 1] = players[rank];
            players[rank] = aheadPlayer;
            playerRanks[player] = rank - 1;
            playerRanks[aheadPlayer] = rank;
        }
        
        return players;
    }
    
}