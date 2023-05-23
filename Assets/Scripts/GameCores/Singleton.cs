using UnityEngine;

public class Singleton<T> : MonoBehaviour
                                            where T : MonoBehaviour
{
    static T instance = null;
    public static T Instance => instance;

    protected virtual void InitSingleton()
    {
        if (instance != null)
        {
            throw new System.Exception($"{this.GetType()} singleton has been created");
        }
        else instance = (T)(MonoBehaviour)this;
    }

    protected virtual void UninitSingleton()
    {
        if (instance == this)
        {
            instance = null;
        }
    }

    protected virtual void Awake()
    {
        InitSingleton();
    }

    protected virtual void OnDestroy()
    {
        UninitSingleton();
    }
}
