using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mechanikaWalki : MonoBehaviour,WeaponI
{

	public float wywolanie; // = 2.5f;
	public float licznikBartka; // = 0.0f;
	private bool t = false;			 //ono chyba jest niepotrzebne
	private float kat;
	public GameObject gameWeapon;
	public int DMG;
    

    // Start is called before the first frame update
    void Start()
    {
	  gameWeapon.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {

        if ((licznikBartka < wywolanie) && t)
        {
                transform.rotation = Quaternion.Euler(0, 0, kat);
                kat += 5;
                licznikBartka += 0.3f;
                gameWeapon.SetActive(true);
          //  Debug.Log(transform.parent == null);


        }

        if (transform.parent == null)
        {
            gameWeapon.SetActive(true);
           Debug.Log("dupa");
        }
	    if (licznikBartka >= wywolanie&& transform.parent != null) 
        {
            Debug.Log("dupa2");
		gameWeapon.SetActive (false);
        }
        //Bartek napraw ten syf po to mamy gita by nie robić takiego gówna pozdro z fartem od pawełka

        //if ((licznikBartka < wywolanie) && t && kat < 180) {
        //	transform.rotation = Quaternion.Euler(0,0,kat);
        //	kat-=5;
        //	licznikBartka += 0.1f;
        //	gameWeapon.SetActive (true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transform.parent != null)
        {
            HPScript a = collision.gameObject.GetComponent<HPScript>();
            if (a != null)
            {
                a.ReciveDamage(DMG);
            }

        }
    }

    public void MakeAttack(float v)
   {
       	kat = v + 195;
	t = true;
	wywolanie = 6.4f;
	licznikBartka = 0.0f;
	gameWeapon.SetActive (true);
       
    }

    public bool HasOwner()
    {
        return transform.parent != null;
    }

    public void Drop()
    {
        transform.parent = null;
    }
}