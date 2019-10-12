using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SIScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float range = 6;
    public bool isTriggered=false;
    public float speed=0.2f;
    
    public mechanikaWalki skryptBroni = null;
    void Start()
    {
        if (skryptBroni == null)
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
            
                x =x/ Mathf.Sqrt(x * x + y * y);
                y =y/ Mathf.Sqrt(x * x + y * y);
            



                this.gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(x*speed + this.gameObject.transform.position.x, y*speed + this.gameObject.transform.position.y));
                Debug.Log(x + " " + y);
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
        //throw new System.NotImplementedException();
    }
}
