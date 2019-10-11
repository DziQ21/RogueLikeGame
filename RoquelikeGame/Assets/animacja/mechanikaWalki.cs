using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mechanikaWalki : MonoBehaviour
{

	public float wywolanie = 2.5f;
	public float licznikBartka = 0.0f;
	private bool t = false;			 //ono chyba jest niepotrzebne
	private float kat;
	public GameObject gameWeapon;
 // Start is called before the first frame update
    void Start()
    {
	  
 }

    // Update is called once per frame
    void Update()
    {
	if (licznikBartka >= wywolanie) {
		gameWeapon.SetActive (true);
	}

	if ((licznikBartka < wywolanie) && t) {
       		transform.rotation = Quaternion.Euler(0,0,kat);
		kat+=5;
		licznikBartka += 0.1f;
		gameWeapon.SetActive (true);
	}

	//if ((licznikBartka < wywolanie) && t && kat < 180) {
       	//	transform.rotation = Quaternion.Euler(0,0,kat);
	//	kat-=5;
	//	licznikBartka += 0.1f;
	//	gameWeapon.SetActive (true);
	//}


    }

    internal void MakeAttack(float v)
   {
       	kat = v + 160;
	t = true;
	wywolanie = 2.5f;
	licznikBartka = 0.0f;
	gameWeapon.SetActive (true);
  }
}