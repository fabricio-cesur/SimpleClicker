using UnityEngine;
using System.Collections;
using TMPro;
using System;

public class MultiplierButton : MonoBehaviour
{
    public GameManager gm;
    public MainButton mb;

    public TextMeshProUGUI muestraMultiplicador;
    public TextMeshProUGUI muestraCosteMultiplicador;

    private bool multiplicador_activo = false;
    public float aumento_multiplicador = 1f;
    public int coste_multiplicador = 100;

    public float multiplicador_coste_multiplicador = 5f;

    public int segundos_multiplicador = 5;

    void Start()
    {
        gm = FindAnyObjectByType<GameManager>();
        if (gm == null)
        {
            Debug.LogError("No se encontró el game manager, arrastrarlo manualmente.");
        }
        mb = FindAnyObjectByType<MainButton>();
        if (mb == null)
        {
            Debug.LogError("No se encontró el MainButton, arrastrarlo manualmente.");
        }

        muestraMultiplicador = GameObject.Find("MultiplicadorTexto").GetComponent<TextMeshProUGUI>();
        if (muestraMultiplicador == null)
        {
            Debug.LogError("No se encontró el TextMeshProUGUI de Multiplicador, arrastrarlo manualmente.");
        }

        muestraCosteMultiplicador = GameObject.Find("CosteMultiplicadorTexto").GetComponent<TextMeshProUGUI>();
        if (muestraCosteMultiplicador == null)
        {
            Debug.LogError("No se encontró el TextMeshProUGUI de Coste Multiplicador, arrastrarlo manualmente.");
        }

        mostrarMultiplicador(gm.getMultiplicador());
    }

    public void aplicarMultiplicador()
    {
        int puntos = gm.getPuntos();
        float multiplicador;
        if (!multiplicador_activo)
        {
            if (puntos >= coste_multiplicador)
            {
                puntos -= coste_multiplicador;
                gm.setPuntos(puntos);
                mb.actualizarPuntos(puntos);

                multiplicador_activo = true;
                multiplicador = gm.getMultiplicador();
                gm.setMultiplicador(multiplicador + aumento_multiplicador);
                StartCoroutine(timerMultiplicador());

                coste_multiplicador = (int)Math.Ceiling(coste_multiplicador * multiplicador_coste_multiplicador);
                mostrarCosteMultiplicador(coste_multiplicador);

                mostrarMultiplicador(gm.getMultiplicador());
            }
            else
            {
                Debug.Log("No tienes suficientes puntos.");
            }
        }
        else
        {
            Debug.Log("El multiplicador ya está activado.");
        }
    }

    public IEnumerator timerMultiplicador()
    {
        yield return new WaitForSeconds(segundos_multiplicador);
        gm.setMultiplicador(1);
        multiplicador_activo = false;

        mostrarMultiplicador(gm.getMultiplicador());
    }

    public void mostrarMultiplicador(float multiplicador)
    {
        muestraMultiplicador.text = "x" + multiplicador;
    }

    public void mostrarCosteMultiplicador(int coste)
    {
        muestraCosteMultiplicador.text = "Coste: " + coste;
    }
}
