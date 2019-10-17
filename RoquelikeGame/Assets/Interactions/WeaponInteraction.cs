using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInteraction : MonoBehaviour,InteractiveI
{
    public int RangeOfinteraction;
    public string InteractionDescription;
    public string GetInyeractionDecription()
    {
        return InteractionDescription;
    }

    public int GetRangeOfInteraction()
    {
        return RangeOfinteraction;
    }

    public void Interact(GameObject caller)
    {
        if (!gameObject.GetComponent<mechanikaWalki>().HasOwner())
        {
            caller.GetComponent<movment>().weapon.GetComponent<WeaponI>().Drop();
            transform.SetParent(caller.transform);
            caller.GetComponent<movment>().setSkryptBroni();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
