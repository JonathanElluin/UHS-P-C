using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoutineScript : MonoBehaviour {

    public GameObject Vildrac;

	// Use this for initialization
	void Start () {
        Vildrac.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.realtimeSinceStartup >= 3)
        {
            Vildrac.SetActive(true);
        }
    }
}
