using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractiveI:MonoBehaviour
{
    abstract public string GetInteractionDecription();
    abstract public int GetRangeOfInteraction();
    abstract public bool CanInteract();
    abstract public void Interact(GameObject caller);

    public float GetDistance(GameObject gameObject)
    {
        return Mathf.Sqrt((gameObject.transform.position.x-this.transform.position.x)* (gameObject.transform.position.x - this.transform.position.x)+ (gameObject.transform.position.y - this.transform.position.y)* (gameObject.transform.position.y - this.transform.position.y));
    }
    void Start()
    {
        InteractionMenager.AddInteraction(this);
    }

    private void OnDestroy()
    {
        InteractionMenager.RemoveInteraction(this);
    }
}
