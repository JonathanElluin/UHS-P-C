using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Vector2 pos;
    public float speed;
    private float time = 0;
    public Animator Anim;
    private SpriteRenderer SRenderer;

    // Use this for initialization
    void Start () {
        pos = new Vector2(transform.position.x, transform.position.x);
        Anim = GetComponent<Animator>();
        SRenderer = GetComponent<SpriteRenderer>();

    }
	
	// Update is called once per frame
	void Update () {
       // pos += Vector2.right;
    //    transform.localScale = new Vector2(2.5f, 2.5f);
     //   transform.position = Vector2.MoveTowards(transform.position, pos, Time.deltaTime * speed);    // Move there
    }

    private void FixedUpdate()
    {        
        Anim.SetFloat("Speed", 0.2f);
        time++;
        if (time < 75f)
        {
            SRenderer.flipX = false;
            pos += Vector2.right;
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        
        if (time >= 75f )
        {
            SRenderer.flipX = true;
            pos += Vector2.left;
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (time == 150f) time = 0;
        }
        //transform.localScale = new Vector2(2.5f, 2.5f);
    }
    private void OnMouseDown()
    {
        if (time >= 75) time = 0;
        else
        {
            time = 75;
        }
    }
}
