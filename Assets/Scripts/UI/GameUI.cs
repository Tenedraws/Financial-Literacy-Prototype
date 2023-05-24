using UnityEngine;

public class GameUI : MonoBehaviour
{
    public GameUIID ID;

    public bool ShowCursor;
    public CursorLockMode cursorLockedMode = CursorLockMode.None;

    private void Start()
    {
        Cursor.visible = ShowCursor;
        Cursor.lockState = cursorLockedMode;
    }
}