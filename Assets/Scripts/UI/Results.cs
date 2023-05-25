using UnityEngine;
using UnityEngine.UI;

public class Results : Singleton<Results>
{
    [SerializeField]
    Button closeButton;
    public Text result;

    // Start is called before the first frame update
    void Start()
    {
        closeButton.onClick.AddListener(Close);
    }

    void Close()
    {
        Time.timeScale = 1f;
        UIManager.Instance.Close(this.gameObject);
    }
}
