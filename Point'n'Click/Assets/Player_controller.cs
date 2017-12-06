using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour {

    private Animator playerAnimator;
    private SpriteRenderer spriteRenderer;
    public GameObject Self;
    private int i = 0;
    public float Speed;
    public static bool startMoving;
	// Use this for initialization
	void Start () {
        playerAnimator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
	}

    private void Update()
    {
       if(startMoving)
        {
            playerAnimator.SetInteger("Speed", 1);
            spriteRenderer.flipX = true;
            transform.Translate(Vector2.left * Speed * Time.deltaTime);
        }
        else
        {
            playerAnimator.SetInteger("Speed", 0);
        }
        
    /*   if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)) //droite
        {
            playerAnimator.SetInteger("Speed", 1);

            if(Input.GetKey(KeyCode.RightArrow))
            {
                if (spriteRenderer.flipX)
                {
                    spriteRenderer.flipX = false;
                }
                transform.Translate(Vector2.right * Speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.LeftArrow)) //gauche
            {
                if (!spriteRenderer.flipX)
                {
                    spriteRenderer.flipX = true;
                }
                transform.Translate(Vector2.left * Speed * Time.deltaTime);
            }
        }
        else
        {
            playerAnimator.SetInteger("Speed", 0);
        }*/

       
    }
}
