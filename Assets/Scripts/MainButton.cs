using UnityEngine;
using TMPro;

public class MainButton : MonoBehaviour
{
    private int puntos;
    public TextMeshProUGUI txt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SumarPuntos()
    {
        puntos++;
        txt.text = "Puntos: " + puntos;
    }
}
