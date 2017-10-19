using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{

    public Vector2 forceSaut = new Vector2(0, 500);

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * 4f * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.right * 4f * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.right * 4f * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0, 90);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.right * 4f * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0, -90);
        }

        /* if (Input.GetKeyDown (KeyCode.Space)) {
			rigidbody2D.AddForce (forceSaut);
											  } */
    }

}