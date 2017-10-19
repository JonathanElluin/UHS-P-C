using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    Vector2 pos;
    public float speed = 2.0f;

    // Use this for initialization
    void Start () {
        pos = new Vector2(transform.position.x, transform.position.x);
	}
	
	// Update is called once per frame
	void Update () {
        pos += Vector2.right;
        transform.localScale = new Vector2(2.5f, 2.5f);
        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);    // Move there
    }

    private void FixedUpdate()
    {
        pos += Vector2.right;
        transform.localScale = new Vector2(2.5f, 2.5f);
    }
}
