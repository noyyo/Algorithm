using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] friends, string[] gifts) {
        // 이름에 인덱스를 부여해서 Dictionary로 관리
        Dictionary<string, int> nameToIndex = new Dictionary<string, int>();
        for (int i = 0; i < friends.Length; i++)
        {
            nameToIndex.Add(friends[i], i);
        }
        // 2차원 int 배열로 선물을 누가 주고 받았는지 관리
        int[,] giftTable = new int[friends.Length, friends.Length];
        // 1차원 int 배열로 선물 지수 관리
        int[] giftScore = new int[friends.Length];
        // 1차원 int 배열로 다음 달 받을 선물의 개수를 관리
        int[] nextGift = new int[friends.Length];
        
        
        string giver;
        string receiver;
        string[] giftInfo;
        int giverIndex;
        int receiverIndex;
        // 선물을 누가 누구에게 줬는지 기록
        foreach (string gift in gifts)
        {
            giftInfo = gift.Split(' ');
            giver = giftInfo[0];
            receiver = giftInfo[1];
            giverIndex = nameToIndex[giver];
            receiverIndex = nameToIndex[receiver];
            giftTable[giverIndex, receiverIndex]++;
            giftScore[giverIndex]++;
            giftScore[receiverIndex]--;
        }
        
        for (int i = 0; i < friends.Length; i++)
        {
            for (int j = 0; j < friends.Length; j++)
            {
                if (j == i)
                    continue;
                if (giftTable[i, j] > giftTable[j, i])
                {
                    nextGift[i]++;
                }
                else if (giftTable[i, j] == giftTable[j, i])
                {
                    if (giftScore[i] > giftScore[j])
                    {
                        nextGift[i]++;
                    }
                }
            }
        }
        
        int maxGiftNumber = 0;
        for (int i = 0; i < nextGift.Length; i++)
        {
            if (maxGiftNumber < nextGift[i])
                maxGiftNumber = nextGift[i];
        }
        
        return maxGiftNumber;
    }
}