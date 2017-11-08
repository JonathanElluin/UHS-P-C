using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteClickScript : MonoBehaviour {

    public Sprite sprite1; // Drag your first sprite here
    public Sprite sprite2; // Drag your second sprite here

    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = sprite1; // set the sprite to sprite1
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicked");
            Vector2 pos = Input.mousePosition;
            RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(pos), Vector2.zero);
            // RaycastHit2D can be either true or null,     but has an implicit conversion to bool, so we can use it like     this
            if (hitInfo)
            {
                Debug.Log(hitInfo.transform.gameObject.name);
                // Here you can check hitInfo to see     which collider has been hit, and act appropriately.
                ChangeSprite(sprite1);
            }
        }
    }

    private void ChangeSprite(Sprite Sprite)
    {
        if (spriteRenderer.sprite == sprite1) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            spriteRenderer.sprite = sprite2;
        }
        else if (spriteRenderer.sprite == sprite2)
        {
            spriteRenderer.sprite = sprite1; // otherwise change it back to sprite1
        }
    }
}
