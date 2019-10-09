using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class Questnemager : MonoBehaviour
{
    public static List<Quest> questList;
    public static void AddQuests(List<Quest> quests)
    {
        questList.AddRange(quests);
    }

    
    void Update()
    {
        
    }
}