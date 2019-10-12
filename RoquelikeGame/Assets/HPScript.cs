using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HPScript : MonoBehaviour
{

    

    public int hP=100;
    public UnityEvent deathevent;
    // Start is called before the first frame update
    public void ReciveDamage(int damage)
    {
        if (this.gameObject.GetComponent<SIScript>() != null)
            this.gameObject.GetComponent<SIScript>().setTriggerded();


        hP -= damage;
        if (hP <= 0)
            Die();

    }
    void Die()
    {
        

        deathevent.Invoke();
        Questnemager.instance.GameObjectDied(this.gameObject);
        Destroy(this.gameObject);
    }
}
