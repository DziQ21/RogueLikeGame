using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mechanikaWalki : MonoBehaviour
{

	public float wywolanie = 5.0f;
	public float licznikBartka = 0.0f;
	private bool t = false;
	private float kat;
 // Start is called before the first frame update
    void Start()
    {
	  
 }

    // Update is called once per frame
    void Update()
    {
	//if ((licznikBartka >= wywolanie) || !t) {
	//	wywolanie = 5.0f;
	//	licznikBartka = 0.0f;
	//	
	//}


	if ((licznikBartka < wywolanie) && t) {
       		transform.rotation = Quaternion.Euler(0,0,kat);
		kat+=5;
		licznikBartka += 0.1f;
	}

    }

    internal void MakeAttack(float v)
   {
       	kat = v;
	t = true;
	wywolanie = 5.0f;
	licznikBartka = 0.0f;
    }
}