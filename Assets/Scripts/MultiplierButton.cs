using UnityEngine;
using System.Collections;

public class MultiplierButton : MonoBehaviour
{
    public GameManager gm;
    private bool multiplicadorActivado = false;
    public float aumento_multiplicador = 0.5f;

    

    public float aumento_aumento = 0.5f;

    void Start()
    {
        gm = FindAnyObjectByType<GameManager>();

        if (gm == null)
        {
            Debug.LogError("No se encontró el game manager, arrastrarlo manualmente.");
        }
    }

    public void aplicarMultiplicador()
    {
        float multiplicador;
        if (!multiplicadorActivado)
        {
            multiplicadorActivado = true;
            multiplicador = gm.getMultiplicador();
            gm.setMultiplicador(multiplicador + aumento_multiplicador);
            StartCoroutine(timerMultiplicador());
        }
        else
        {
            Debug.Log("El multiplicador ya está activado.");
        }
    }

    public IEnumerator timerMultiplicador()
    {
        yield return new WaitForSeconds(5);
        gm.setMultiplicador(1);
        multiplicadorActivado = false;
    }

}
