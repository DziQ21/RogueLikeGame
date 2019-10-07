using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public TypesOfQuests typeofquest;
    public GameObject target;
    
    
    public enum TypesOfQuests
    {
        Kill,
        Destroy
    }
}
