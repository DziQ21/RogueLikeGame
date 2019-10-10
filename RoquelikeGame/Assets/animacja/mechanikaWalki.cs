using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mechanikaWalki : MonoBehaviour
{

	private float wywolanie = 5.0f;
	private float licznikBartka = 0.0f;
 // Start is called before the first frame update
    void Start()
    {
	  
 }

    // Update is called once per frame
    void Update()
    {

    }

    internal void MakeAttack(float v)
   {
        throw new NotImplementedException();

	if (licznikBartka < wywolanie) {
       		transform.rotation = Quaternion.Euler(0,0,v);
		v+=5;
		licznikBartka += 0.1f;
	}

    }
}