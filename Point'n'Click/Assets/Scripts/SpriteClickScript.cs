using UnityEngine;
using Assets.Scripts;

public class SpriteClickScript : MonoBehaviour {
    
    public GameObject sprite;
    public Collider2D collision;
    
    private void Update()
    {
        OnTriggerStay2D(collision);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cursor")
        {
            collision.gameObject.GetComponent(sprite.name);
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
                        SharedObjects.SetInt(gameObject.name, 1);
                        break;
                    }
            }
            Debug.Log(gameObject.name);
        }
    }

    

}