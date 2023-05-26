using UnityEngine;

public class PetStates : MonoBehaviour
{
    [SerializeField]
    Sprite neutral, sad, happy;
    SpriteRenderer sr;
    public petStates currentPetState;

    public enum petStates
    {
        Happy,
        Neutral,
        Sad
    }

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        currentPetState = petStates.Happy;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentPetState)
        {
            default:
            case petStates.Happy:
                Happy();
                break;
            case petStates.Neutral:
                Neutral();
                break;
            case petStates.Sad:
                Sad();
                break;
        }
    }

    void Happy()
    {
        sr.sprite = happy;
        if (PetStats.Instance.getFinancialSecurity <= 0.5 || PetStats.Instance.getHappiness <= 50 || PetStats.Instance.getHealth <= 50)
        {
            currentPetState = petStates.Neutral;
        }
    }

    void Neutral()
    {
        sr.sprite = neutral;
        if (PetStats.Instance.getFinancialSecurity <= 0.2 || PetStats.Instance.getHappiness <= 20 || PetStats.Instance.getHealth <= 20)
        {
            currentPetState = petStates.Sad;
        }
        else if (PetStats.Instance.getFinancialSecurity > 0.5 && PetStats.Instance.getHappiness > 50 && PetStats.Instance.getHealth > 50)
        {
            currentPetState = petStates.Happy;
        }
    }

    void Sad()
    {
        sr.sprite = sad;
        if (PetStats.Instance.getFinancialSecurity > 0.2 && PetStats.Instance.getHappiness > 20 && PetStats.Instance.getHealth > 20)
        {
            currentPetState = petStates.Neutral;
        }
    }
}
