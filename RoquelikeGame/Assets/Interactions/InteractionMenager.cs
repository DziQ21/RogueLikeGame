using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionMenager : MonoBehaviour
{
    public static InteractionMenager instance;
    private List<InteractiveI> listOfInteractive;
    // Start is called before the first frame update
    void Start()
    {
        listOfInteractive = new List<InteractiveI>();
        instance= this;
    }
    public static void AddInteraction(InteractiveI a)
    {
        instance.listOfInteractive.Add(a);
    }
    public static void RemoveInteraction(InteractiveI a)
    {
        instance.listOfInteractive.Remove(a);
    }

    

    // Update is called once per frame
    void Update()
    {
        InteractiveI buff = GetClosestThatCanInteract(movment.instance.gameObject);
        if (buff != null)
        {
            Debug.Log(buff.GetInteractionDecription(),buff.gameObject);
        }
    }
    void TrytoInteract(GameObject g)
    {
        InteractiveI buff= GetClosestThatCanInteract(g);
        if (buff != null)
        {
            buff.Interact(g);
        }

    }

    InteractiveI GetClosestThatCanInteract(GameObject gameObject)
    {
        InteractiveI interactiveI=null;
        float distance=999999f;
        foreach (InteractiveI item in listOfInteractive)
        {
            if (item.CanInteract()&&distance > item.GetDistance(gameObject))
            {
                if (item.GetDistance(gameObject) < item.GetRangeOfInteraction())
                {
                    interactiveI = item;
                    distance = item.GetDistance(gameObject);
                }
            }
        }
        return interactiveI;
    }
}
