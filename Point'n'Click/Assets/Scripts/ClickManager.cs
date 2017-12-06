using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{

    float smooth = 2.0f;
    public Sprite sprite0; // sprite de base 
    private SpriteRenderer spriteRenderer0;
    public Sprite sprite1; //sprite qui change en fonction du choix 
    private SpriteRenderer spriteRenderer1;

    void OnTriggerEnter2D(Collider2D In)
    {

        if (In.gameObject.tag == "Cursor")
        {
            spriteRenderer1 = In.gameObject.GetComponent<SpriteRenderer>(); // recup le sprite
            spriteRenderer1.sprite = sprite1; //Change le sprite du curseur 

        }

    }

    void OnTriggerExit2D(Collider2D Out)
    {

        if (Out.gameObject.tag == "Cursor")
        {
            spriteRenderer0 = Out.gameObject.GetComponent<SpriteRenderer>(); // recup le sprite
            spriteRenderer0.sprite = sprite0; //Change le sprite du curseur 


        }

    }

}



