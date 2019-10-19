using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInteraction : InteractiveI
{
    public int RangeOfinteraction;
    public string InteractionDescription;

    public override bool CanInteract()
    {
        return !gameObject.GetComponent<mechanikaWalki>().HasOwner();
    }

    public override string GetInteractionDecription()
    {
        return InteractionDescription;
    }

    public override int GetRangeOfInteraction()
    {
        return RangeOfinteraction;
    }
    
    public override void Interact(GameObject caller)
    {
        if (!gameObject.GetComponent<mechanikaWalki>().HasOwner())
        {
            caller.GetComponent<movment>().weapon.GetComponent<WeaponI>().Drop();
            transform.SetParent(caller.transform);
            caller.GetComponent<movment>().setSkryptBroni();
        }
    }


    // Start is called before the first frame update
    
}
