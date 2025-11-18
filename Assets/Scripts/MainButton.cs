using UnityEngine;
using TMPro;
using System;

public class MainButton : MonoBehaviour
{
    public GameManager gm;
    public TextMeshProUGUI muestraPuntos;

    void Start()
    {
        gm = FindAnyObjectByType<GameManager>();
    }

    public void sumarPuntos()
    {
        int puntos = gm.getPuntos();
        float suma = gm.getSuma();
        float multiplicador = gm.getMultiplicador();

        suma = suma * multiplicador;
        puntos = (int) Math.Ceiling(puntos + suma);

        muestraPuntos.text = "Puntos: " + puntos;
        gm.setPuntos(puntos);
    }
}
