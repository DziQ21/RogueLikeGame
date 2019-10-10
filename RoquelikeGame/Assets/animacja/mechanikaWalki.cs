using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mechanikaWalki : MonoBehaviour
{
	float stopnieRadzika = 50;
	float degrees = -10;
	//float pom;
	//float pom2;
	float predkosc = 2;
	bool t = true;
	int counter = 0;

public float wywolanie = 5.0f;
public float licznikBartka = 0.0f;
 // Start is called before the first frame update
    void Start()
    {
	   //  pom = degrees + 130;
	//pom2 = degrees;
  //Quaternion target = Quaternion.Euler(0, 0, -30);
 //transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime  );

 }

    // Update is called once per frame
    void Update()
    {



//10 += Time.deltaTime * 10;

	// to ma byc raz uzyte wiec ten patent jest na chwile tylko, jutro pomysle
	//if (t) {


		//t=false;
	//}



	
	//if (pom2 < pom) {

	//if (counter <20) {
        	//Vector3 to = new Vector3(0, 0, degrees* predkosc);
	//counter = counter + counter;

	//transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, 0.01f);
	//transform.eulerAnges = Vector3(transform.rotation.eulerAngles, new Vector3(0, 0, degrees* predkosc),0.01f);
//}
	//pom2 = pom2 + pom2;
	//}
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