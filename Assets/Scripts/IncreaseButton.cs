using UnityEngine;

public class IncreaseButton : MonoBehaviour
{

    public GameManager gm;
    
    void Start()
    {
        gm = FindAnyObjectByType<GameManager>();
    }

}
