using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSetter : MonoBehaviour
{
    [SerializeField]
    Text description;
    [SerializeField]
    Text result; 
    Button button;
    public int buttonID;

    public ButtonBehavior buttonBehavior;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ApplyBehavior);
    }

    public void Set(ButtonBehavior buttonBehavior)
    {
        description.text = buttonBehavior.Description;
    }

    void ApplyBehavior()
    {
        buttonBehavior.ApplyEffect();
        //result.text = buttonBehavior.result;
    }

    internal void Clean()
    {
        description.text = "";
    }
}
