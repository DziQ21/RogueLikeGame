using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruchyGdyWalka : MonoBehaviour
{
	//public bool t = false;
	Animator NewAnimation;

    // Start is called before the first frame update
    void Start()
    {
        NewAnimation = GetComponent <Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space") && !NewAnimation.GetCurrentAnimatorStateInfo(0).IsName("kick")) {
	NewAnimation.SetTrigger ("hit");
	//t=true;
         }
	
	
    }
}