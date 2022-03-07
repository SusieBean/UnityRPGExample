using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllGameData
{
    public static PROGRESS progress;
    public static MAP_ID mapID;
    public static List<ITEMS> items = new List<ITEMS>();
    public static List<PARTY_MEMBERS> party = new List<PARTY_MEMBERS>();


    public static void LoadNewData()
    {
        progress = PROGRESS.START;
        mapID = MAP_ID.STARTING_MAP;
        items.Clear();
        party.Clear();
    
    
    }

    public static void ClearData()
    {
        progress = PROGRESS.NONE;
        mapID = MAP_ID.NONE;
        items.Clear();
        party.Clear();
    }
}
