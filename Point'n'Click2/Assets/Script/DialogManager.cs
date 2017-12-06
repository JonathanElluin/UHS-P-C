using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {

    public GameObject dBox;
    public Text dText;

    public bool isDialogActive;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isDialogActive && Input.GetKeyDown(KeyCode.Space))
        {
            dBox.SetActive(false);
        }
	}
}
