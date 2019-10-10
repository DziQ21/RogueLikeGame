using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestList : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Quest> list;
    public List<GameObject> KillableAndDestuctable;

    public void Start()
    {
        for(int i = 0; i < KillableAndDestuctable.Count; i++)
        {
            list.Add(new Quest(KillableAndDestuctable[i]));
        }
    }
    // Update is called once per frame

}
