using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SIScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float range = 6;
    public bool isTriggered=false;
    public float speed=0.2f;
    private float timeStampNPC;
    
    public GameObject weapon = null;
    void Start()
    {
        if (weapon == null)
            setSkryptBroni();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTriggered)
        {
            float y= movment.instance.gameObject.transform.position.y-this.gameObject.transform.position.y; 
            float x= movment.instance.gameObject.transform.position.x - this.gameObject.transform.position.x;

            if(Mathf.Sqrt(x * x + y * y) > 4) { 
            
                x =x*speed* Time.fixedDeltaTime *30/ Mathf.Sqrt(x * x + y * y);
                y =y*speed* Time.fixedDeltaTime*30 / Mathf.Sqrt(x * x + y * y);



                GetComponent<Rigidbody2D>().AddForce(new Vector2(x, y));
              
               

            }else
            {
                if ((weapon != null) && (timeStampNPC <= Time.time))
                {
                    timeStampNPC = Time.time + 1.6f;
                    weapon.GetComponent<WeaponI>().MakeAttack((-Mathf.Atan2(x, y) * Mathf.Rad2Deg + 180) % 360);
                }
            }
            
        }
                //script for atck
    }
    public void setTriggerded()
    {
        isTriggered = true;
    }
    void setSkryptBroni()
    {
       foreach(Transform child in transform)
       {
            if (child.gameObject.GetComponent<WeaponI>()!=null)
                weapon = child.gameObject;
       }
    }
}
