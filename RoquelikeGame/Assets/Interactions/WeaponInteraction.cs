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
           // Vector3 buf = transform.localScale;
            transform.SetParent(caller.transform);
            transform.localPosition = new Vector3(0, 0, 0);
            transform.localScale = new Vector3(0.35f, 0.35f, 1);
            //  Debug.Break();
            caller.GetComponent<movment>().setSkryptBroni();
          //  Debug.Break();
        }
    }


    // Start is called before the first frame update
    
}
