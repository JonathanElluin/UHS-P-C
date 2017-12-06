using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.RightArrow)) //droite
        {
            transform.Translate(Vector2.right * 4f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) //gauche
        {
            transform.Translate(Vector2.left * 4f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))  //haut
        {
            transform.Translate(Vector2.up * 4f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))  //bas
        {
            transform.Translate(Vector2.down * 4f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))    //Espace
        {

        }

    }

}