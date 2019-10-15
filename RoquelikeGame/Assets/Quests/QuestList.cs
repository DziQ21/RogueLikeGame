using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestList : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Quest> list;
    public List<GameObject> KillableAndDestuctable;

    public void Initialize()
    {
            Debug.Log("kurwaaaa");
        for(int i = 0; i < KillableAndDestuctable.Count; i++)
        {
            Quest buff = (Quest)ScriptableObject.CreateInstance("Quest");
            buff.target = KillableAndDestuctable[i];
            list.Add(buff);
        }
    }
    // Update is called once per frame

}
