using System.Collections.Generic;
using System.Collections;
using System;
using UnityEngine;

public class MeaningfulName
{
    public void BeClearAboutYourIntentions()
    {
        //Bad
        int d;

        //Clean
        int elapsedTimeInDays;
        int daysSinceCreation;
        int daysSinceModification;
        int fileAgeInDays;

        //Bad
        GetThem();
        //Clean
        GetFlaggedCells();
    }

    #region Example1
    //Bad
    public List<int[]> GetThem()
    {
        List<int[]> list1 = new List<int[]>();
        List<int[]> list2 = new List<int[]>();

        foreach(int[] x in list1)
        {
            if(x[0] == 4)
            {
                list2.Add(x);
            }
        }
        return list2;
    }

    //Clean - 1
    enum Cell_Status
    {
        Empty = 0,
        Flagged,
        QuestionMark
    }
    public List<int[]> GetFlaggedCells()
    {
        int STATUS_VALUE = 0;

        List<int[]> GameBoardCells = new List<int[]>();
        List<int[]> flaggedCells = new List<int[]>();

        foreach (int[] cell in GameBoardCells)
        {
            if (cell[STATUS_VALUE] == (int)Cell_Status.Flagged)
            {
                flaggedCells.Add(cell);
            }
        }

        return flaggedCells;
    }

    //Clean - 2
    public class Cell
    {

    }
    #endregion Example2
}
