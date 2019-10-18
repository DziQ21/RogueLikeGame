using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{
    float x;
    public float speed;
    float y;
    public GameObject weapon=null;
    public static movment instance = null;
    private float timeStamp = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        if (weapon == null)
        {
            Debug.Log("nie mam broni");
            setSkryptBroni();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
         y = Input.GetAxis("Vertical") * speed;
         x = Input.GetAxis("Horizontal") * speed;
        GetComponent<Rigidbody2D>().AddForce(new Vector2(x , y ));
        if((Input.GetMouseButtonDown(1)) && (timeStamp <= Time.time))
        {
            timeStamp = Time.time + 0.7f;
            Vector2 playerPosition = new Vector2(Screen.width/2, Screen.height/2);
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            weapon.GetComponent<WeaponI>().MakeAttack((-Mathf.Atan2(playerPosition.x - mousePosition.x, playerPosition.y - mousePosition.y) * Mathf.Rad2Deg  + 270) % 360);
        }
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            throw new NotImplementedException();
        }
    }
    

    public void setSkryptBroni()
    {
        foreach (Transform child in transform)
        {
            if (child.gameObject.GetComponent<WeaponI>() != null)
                weapon = child.gameObject;
        }
    }

}