using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface InteractiveI
{
    string GetInyeractionDecription();
    int GetRangeOfInteraction();
    void Interact(GameObject caller);
}
