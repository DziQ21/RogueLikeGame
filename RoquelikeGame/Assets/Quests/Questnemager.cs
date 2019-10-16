﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class Questnemager : MonoBehaviour
{
    public UnityEvent questCompleteEvent;
    public static List<Quest> questList = new List<Quest>();
    [SerializeField]
    private List<Quest> chosenQuests;
    public int numberOfQuests = 3;
    public static Questnemager instance=null;
    public GameObject questMark;
    public static void AddQuests(List<Quest> quests)
    {
        Debug.Log(quests.Count);
        questList.AddRange(quests);
    }
    
    private void Start()
    {
        instance = this;
        chosenQuests= new List<Quest>();
        for(int i = 0; i < 3; i++)
        {
            
            int a = Random.Range(0, questList.Count);
            chosenQuests.Add(questList[a]);

           
            var buff = Instantiate(questMark);
            buff.GetComponent<QuestMarkScript>().setTarget(questList[a].target);
            questList.RemoveAt(a); 
        }
    }

    public void GameObjectDied(GameObject g)
    {
        for (int i = 0; i < chosenQuests.Count; i++)
        {

            if (chosenQuests[i].target.Equals(g))
            {
                chosenQuests.RemoveAt(i);
                questCompleteEvent.Invoke();
            }
        }
    }
}