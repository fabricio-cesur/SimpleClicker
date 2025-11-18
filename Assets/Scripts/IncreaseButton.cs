using UnityEngine;

public class IncreaseButton : MonoBehaviour
{

    public GameManager gm;
    
    void Start()
    {
        gm = FindAnyObjectByType<GameManager>();
        
        if (gm == null)
        {
            Debug.Log("No se encontró el object manager");
        }
    }

}
