using System;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        int[] minHeap = new int[k];
        int parentIndex = 0;
        int currentIndex = 0;
        int childIndex = 0;
        int temp;
        for (int i = 0; i < answer.Length; i++)
        {
            if (i < k)
            {
                currentIndex = i;
            }
            else
            {
                if (score[i] > minHeap[0])
                {
                    minHeap[0] = minHeap[k - 1];
                    currentIndex = 0;
                    childIndex = currentIndex * 2 + 1;
                    while(childIndex < minHeap.Length -1)
                    {
                        if (childIndex + 1 >= minHeap.Length - 1)
                        {
                            if (minHeap[currentIndex] > minHeap[childIndex])
                            {
                                temp = minHeap[childIndex];
                                minHeap[childIndex] = minHeap[currentIndex];
                                minHeap[currentIndex] = temp;
                            }
                            break;
                        }
                        else if(minHeap[childIndex] < minHeap[childIndex + 1])
                        {
                            if (minHeap[currentIndex] > minHeap[childIndex])
                            {
                                temp = minHeap[childIndex];
                                minHeap[childIndex] = minHeap[currentIndex];
                                minHeap[currentIndex] = temp;
                                currentIndex = childIndex;
                                childIndex = currentIndex * 2 + 1;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            if (minHeap[currentIndex] > minHeap[childIndex + 1])
                            {
                                temp = minHeap[childIndex + 1];
                                minHeap[childIndex + 1] = minHeap[currentIndex];
                                minHeap[currentIndex] = temp;
                                currentIndex = childIndex + 1;
                                childIndex = currentIndex * 2 + 1;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    answer[i] = minHeap[0];
                    continue;
                }
                currentIndex = k - 1;
            }
            minHeap[currentIndex] = score[i];              
            parentIndex = (currentIndex / 2) - 1 + (currentIndex % 2);
            
            while (parentIndex >= 0)
            {
                if (minHeap[currentIndex] < minHeap[parentIndex])
                {
                    temp = minHeap[parentIndex];
                    minHeap[parentIndex] = minHeap[currentIndex];
                    minHeap[currentIndex] = temp;
                    currentIndex = parentIndex;
                    parentIndex = (currentIndex / 2) - 1 + (currentIndex % 2);
                }
                else
                {
                    break;                        
                }
            }
            
            answer[i] = minHeap[0];
        }
        
        return answer;
    }
}