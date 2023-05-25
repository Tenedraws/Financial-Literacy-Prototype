using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    public GameObject CanvasPrefab;
    public string UITemplatePath = "UI";

    Dictionary<GameUIID, GameObject> uiTemplates = new Dictionary<GameUIID, GameObject>();
    RectTransform mainCanvas = null;

    List<GameObject> openedUI = new List<GameObject>();
    public bool HasOpenedUI => openedUI.Count > 0;

    protected override void Awake()
    {
        base.Awake();
        Initialize();
    }

    public void Initialize()
    {
        mainCanvas = (RectTransform)Instantiate(CanvasPrefab).transform;

        GameObject[] templates = Resources.LoadAll<GameObject>(UITemplatePath);

        foreach (GameObject template in templates)
        {
            if (template.TryGetComponent(out GameUI uiTemplate))
            {
                uiTemplates[uiTemplate.ID] = template;
            }
        }
    }

    public GameObject Open(GameUIID id)
    {
        GameObject newUIObj = null;

        if (uiTemplates.TryGetValue(id, out var template))
        {
            newUIObj = Instantiate(template, mainCanvas);
            openedUI.Add(newUIObj);

        }
        return newUIObj;
    }

    public GameObject OpenReplace(GameUIID id)
    {
        CloseAll();
        return Open(id);
    }

    public void Close(GameObject obj)
    {
        openedUI.Remove(obj);
        Destroy(obj);
    }

    public void CloseAll()
    {
        GameObject[] copies = openedUI.ToArray();
        foreach (GameObject obj in copies)
        {
            Close(obj);
        }
        openedUI.Clear();
    }
}

public enum GameUIID
{
    GameHud,
    Choices,
    Result,
    EndScreen,
    Aspiration,
    OpeningScene,
    Expenses
}
