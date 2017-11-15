using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoutineScript : MonoBehaviour {

    public GameObject Vildrac;
    private SpriteRenderer VildracSpriteRenderer;
    public GameObject Couloir;
    private Animator CouloirAnimator;
    private float Alpha;

	// Use this for initialization
	void Start () {
        VildracSpriteRenderer = Vildrac.GetComponent<SpriteRenderer>();
        VildracSpriteRenderer.material.color = new Color(1.0f, 1.0f, 1.0f, Alpha);
        VildracSpriteRenderer.flipX = true;
        CouloirAnimator = Couloir.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        
        CouloirAnimator.SetBool("isOpen", true);
        if(CouloirAnimator.GetCurrentAnimatorStateInfo(0).IsName("PorteOuverte"))
        {
            Player_controller.startMoving = true;
            if (Alpha < 1)
            {
                Alpha += 0.05f;
            }
            Vildrac.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, Alpha);
        }
     }
}
