using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{
    float x;
    public float speed;
    float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
         y = Input.GetAxis("Vertical") * speed;
         x = Input.GetAxis("Horizontal") * speed;

        GetComponent<Rigidbody2D>().MovePosition(new Vector2(x+ transform.position.x, y+ transform.position.y));//= new Vector3(x + transform.position.x, y + transform.position.y, 0);
    }

}
