using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{
    float x;
    public float speed;
    float y;
    public mechanikaWalki skryptBroni=null;
    public static movment instance = null;
    private float timeStamp = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        if (skryptBroni ==null )
            setSkryptBroni();
    }

    // Update is called once per frame
    void Update()
    {
        
         y = Input.GetAxis("Vertical") * speed;
         x = Input.GetAxis("Horizontal") * speed;
        GetComponent<Rigidbody2D>().AddForce(new Vector2(x , y ));
        //GetComponent<Rigidbody2D>().MovePosition(new Vector2(x+ transform.position.x, y+ transform.position.y));
        if((Input.GetMouseButtonDown(1)) && (timeStamp <= Time.time))
        {
            timeStamp = Time.time + 1.0f;
            Vector2 playerPosition = new Vector2(Screen.width/2, Screen.height/2);
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
           // Debug.Log(((-Mathf.Atan2(playerPosition.x - mousePosition.x, playerPosition.y - mousePosition.y) * Mathf.Rad2Deg-90)+360)%360 + " "+playerPosition+" "+ mousePosition);
            //Debug.Log(Vector2.SignedAngle(Vector2.zero, Vector2.one));
            skryptBroni.MakeAttack((-Mathf.Atan2(playerPosition.x - mousePosition.x, playerPosition.y - mousePosition.y) * Mathf.Rad2Deg  + 270) % 360);
        }
    }

    void setSkryptBroni()
    {

    }

}