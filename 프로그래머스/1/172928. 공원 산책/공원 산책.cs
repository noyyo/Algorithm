using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int currentX = 0;
        int currentY = 0;
        for (int i = 0; i < park.Length; i++)
        {
            string AxisX = park[i];
            for (int j = 0; j < AxisX.Length; j++)
            {
                if (AxisX[j] == 'S')
                {
                    currentX = j;
                    currentY = i;
                }
            }
        }
        string route;
        string[] splitedRoute;
        string op;
        int amount;
        for (int i = 0; i < routes.Length; i++)
        {
            route = routes[i];
            splitedRoute = route.Split(' ');
            op = splitedRoute[0];
            amount = int.Parse(splitedRoute[1]);
            Move(ref currentX, ref currentY, op, amount, park);
        }
        int[] answer = new int[] {currentY, currentX};
        return answer;
    }
    private void Move(ref int currentX, ref int currentY, string direction, int amount, string[] park)
    {
        int nextX = currentX;
        int nextY = currentY;
        string AxisX;
        switch (direction)
        {
            case "E" :
                AxisX = park[currentY];
                for (int i = 0; i < amount; i++)
                {
                    nextX++;
                    if (nextX >= AxisX.Length)
                        return;
                    if (AxisX[nextX] == 'X')
                        return;
                }
                currentX = nextX;
                break;
            case "W" :
                AxisX = park[currentY];
                for (int i = 0; i < amount; i++)
                {
                    nextX--;
                    if (nextX < 0)
                        return;
                    if (AxisX[nextX] == 'X')
                        return;
                }
                currentX = nextX;
                break;
            case "N" :
                for (int i = 0; i < amount; i++)
                {
                    nextY--;
                    if (nextY < 0)
                        return;
                    AxisX = park[nextY];
                    if (AxisX[currentX] == 'X')
                        return;
                }
                currentY = nextY;
                break;
            case "S" :
                for (int i = 0; i < amount; i++)
                {
                    nextY++;
                    if (nextY >= park.Length)
                        return;
                    AxisX = park[nextY];
                    if (AxisX[currentX] == 'X')
                        return;
                }
                currentY = nextY;
                break;
            default:
                return;
        }
        return;
    }
}