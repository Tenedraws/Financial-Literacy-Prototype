using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoicesElements : Singleton<ChoicesElements>
{
    [SerializeField]
    List<ButtonSetter> buttonSetter;
    public Text scenario;

    public void initializeButtons(List<ButtonBehavior> buttonBehaviors)
    {
        for (int i = 0; i < buttonBehaviors.Count; i++)
        {
            buttonSetter[i].gameObject.SetActive(true);
            buttonSetter[i].Clean();
            buttonSetter[i].buttonBehavior = buttonBehaviors[i];
            buttonSetter[i].Set(buttonBehaviors[i]);
            buttonSetter[i].GetComponent<Button>().onClick.AddListener(Close);
        }
    }

    public void Close()
    {
        UIManager.Instance.Close(this.gameObject);
    }
}
