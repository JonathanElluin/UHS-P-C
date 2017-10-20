using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class ScriptButtons : MonoBehaviour
{
    public string button;
    public Button leButton;
    public Text text;

    void Start()
    {
        leButton.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {

        switch (button)
        {

            case "ButtonStoryEnerve":
                text.text = "Énervé";
                Debug.Log("Énervé");
                break;
            case "ButtonStoryAlcoolique":
                text.text = "Alcoolique";
                Debug.Log("Alcoolique");
                break;
            default:
                break;
        }
    }
}