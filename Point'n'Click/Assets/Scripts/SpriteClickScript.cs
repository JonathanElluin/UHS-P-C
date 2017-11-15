using UnityEngine;
using Assets.Scripts;

public class SpriteClickScript : MonoBehaviour {

    public GameObject sprite;

    public void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        SharedObjects.SetInt(gameObject.name, 1);
    }
}