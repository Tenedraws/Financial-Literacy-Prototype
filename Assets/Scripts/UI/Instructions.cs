using UnityEngine;
using UnityEngine.UI;

public class Instructions : MonoBehaviour
{
    [SerializeField]
    Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        UIManager.Instance.Close(this.gameObject);
        Time.timeScale = 1f;
    }
}
