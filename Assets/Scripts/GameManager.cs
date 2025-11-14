using UnityEngine;
using TMPro;
using System.Collections;


public class GameManager : MonoBehaviour
{

    private int puntos = 0;
    public TextMeshProUGUI muestraPuntos;

    private int sumaBase = 1;
    private int multiplicador = 1;

    private bool multiplicadorActivo = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sumarPuntos()
    {
        puntos = puntos + (sumaBase * multiplicador);
        muestraPuntos.text = "Puntos: " + puntos;
    }

    public void aumentarSuma()
    {
        if (puntos >= 30)
        {
            puntos = puntos - 30;
            sumaBase++;
        }
        else
        {
            Debug.Log("No tienes puntos suficientes");
        }
    }

    public void aplicarMultiplicador()
    {
        if (!multiplicadorActivo)
        {
            multiplicadorActivo = true;
            multiplicador = 2;
            StartCoroutine(timerMultiplicador());
        }
        else
        {
            Debug.Log("El multiplicador ya está activo");
        }
    }

    public IEnumerator timerMultiplicador()
    {
        yield return new WaitForSeconds(5);
        multiplicador = 1;
        multiplicadorActivo = false;
    }

    
}
