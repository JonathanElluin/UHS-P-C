using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Assets.Scripts;

public class SpriteClickScript : MonoBehaviour {

    public GameObject sprite;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        SharedObjects.SetInt("story", 1);
    }
}