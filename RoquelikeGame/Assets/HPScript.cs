using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HPScript : MonoBehaviour
{
    public int hP;
    public UnityEvent deathevent;
    // Start is called before the first frame update
    public void ReciveDamage(int damage)
    {
        hP -= damage;
        if (hP <= 0)
            Die();

    }
    void Die()
    {
        deathevent.Invoke();
        Destroy(this.gameObject);
    }
}
