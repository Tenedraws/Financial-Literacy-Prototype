using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Endscreen : Singleton<Endscreen>
{
    [SerializeField]
    Button restartButton;
    public Text endText; 

    // Start is called before the first frame update
    void Start()
    {
        restartButton.onClick.AddListener(Restart);
    }

    void Restart()
    {
        SceneManager.LoadScene("Main");
    }
}
