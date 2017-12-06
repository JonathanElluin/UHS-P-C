using UnityEngine;
using Assets.Scripts;

public class SpriteClickScript : MonoBehaviour {

    public GameObject sprite;

    public void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        switch (sprite.name)
        {
            case "Choix 1":
                {
                    SharedObjects.SetInt(gameObject.name, 1);
                    break;
                }
            case "Choix 2":
                {
                    SharedObjects.SetInt(gameObject.name, 2);
                    break;
                }
            case "Choix 3":
                {
                    SharedObjects.SetInt(gameObject.name, 3);
                    break;
                }
            default:
                {
                    SharedObjects.SetInt(gameObject.name, 0);
                    break;
                }
        }
        Debug.Log(SharedObjects.GetInt(gameObject.name));
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log(gameObject.name);
    }
}