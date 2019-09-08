using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUITest : MonoBehaviour
{
    private int[,] chessBoard = new int[3, 3];
    private int turn = 1;
    int count = 0;
    private void Reset()
    {
        count = 0;
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                chessBoard[i, j] = 0;
            }
        }
    }
    private void Start()
    {
        Reset();
    }
    private void OnGUI()
    {
        
        GUIStyle Style = new GUIStyle();
        Style.normal.background = null;
        Style.normal.textColor = new Color(1, 0, 0);
        Style.fontSize = 15;

        GUI.Label(new Rect(195, 10, 200, 100), "Welcome to Tic Tac Toe!", Style);
        GUI.Label(new Rect(20, 100, 200, 100), "Turn: ", Style);
        GUI.Label(new Rect(70, 120, 200, 100), "Player X", Style);
        GUI.Label(new Rect(70, 160, 200, 100), "Player O", Style);
        if (GUI.Button(new Rect(220, 300, 100, 50), "RESET"))
            Reset();
        int winner = check();
        if (winner == 1)
        {
            GUI.Label(new Rect(250, 260, 200, 100), "X wins!", Style);
        }
        if (winner == 2)
        {
            GUI.Label(new Rect(250, 260, 200, 100), "O wins!", Style);
        }
        else if(count==9) GUI.Label(new Rect(250, 260, 200, 100), "A draw!", Style);//不仅要没有人赢而且要下了九颗子才可以说平局
        if(turn ==0) GUI.Label(new Rect(160, 120, 200, 100), "*", Style);
        else GUI.Label(new Rect(160, 160, 200, 100), "*", Style);
        for (int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                if (chessBoard[i, j] == 1)
                {
                    
                    GUI.Button(new Rect(195 + 50 * i, 100 + 50 * j, 50, 50), "X");
                }
                if (chessBoard[i, j] == 2)
                {
                   
                    GUI.Button(new Rect(195 + 50 * i, 100 + 50 * j, 50, 50), "O");
                }
                if (GUI.Button(new Rect(195 + 50 * i, 100 + 50 * j, 50, 50), ""))
                {
                    count++;
                    if (turn == 0) chessBoard[i, j] = 1;
                    if (turn == 1) chessBoard[i, j] = 2;
                    turn = 1 - turn;//是放在这里不是放在循环那里
                }
               
            }
        }
    }
    int check()
    {
       Debug.Log(count);
        for(int i = 0; i < 3; i++)
        {
            if (chessBoard[i, 0] != 0 && chessBoard[i, 1] == chessBoard[i, 0] && chessBoard[i, 2] == chessBoard[i, 0])
            {
                return chessBoard[i, 0];
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (chessBoard[0, i] != 0 && chessBoard[1,i] == chessBoard[0,i] && chessBoard[2,i] == chessBoard[0,i])
            {
                return chessBoard[0,i];
            }
        }
        if ((chessBoard[1, 1] != 0 && chessBoard[0, 0] == chessBoard[1, 1] && chessBoard[2, 2] == chessBoard[1, 1]) || (chessBoard[1, 1] != 0 && chessBoard[2, 0] == chessBoard[1, 1] && chessBoard[0, 2] == chessBoard[1, 1]))
            return chessBoard[1, 1];
        return 0;
    }
    private void Update()
    {
        
    }
}