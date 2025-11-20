using UnityEngine;
using TMPro;

public class IncreaseButton : MonoBehaviour
{

    public GameManager gm;

    public MainButton mb;
    public TextMeshProUGUI muestraSuma;
    public TextMeshProUGUI muestraCoste;
    [Header("Valores")]
    // la cantidad en la que aumentará la suma
    public int aumento = 1;
    public int coste = 10;
    [Header("Aumento de Valores")]
    public int aumento_aumento = 1;
    public float multiplicador_coste = 1.5f;
    
    void Start()
    {
        gm = FindAnyObjectByType<GameManager>();
        if (gm == null)
        {
            Debug.LogError("No se encontró el GameManager, arrástrelo manualmente");
        }

        mb = FindAnyObjectByType<MainButton>();
        if (mb == null)
        {
            Debug.LogError("No se encontró el MainButton, arrástrelo manualmente");
        }

        muestraSuma = GameObject.Find("SumaTexto").GetComponent<TextMeshProUGUI>();
        muestraCoste = GameObject.Find("CosteSumaTexto").GetComponent<TextMeshProUGUI>();

        if (muestraSuma == null || muestraCoste == null)
        {
            Debug.LogError("No se encontró el TextMeshProUGUI de Suma o Coste, arrástrelo manualmente");
        }

        mostrarCoste(coste);
        mostrarSuma(aumento);
    }

    public void aumentarSuma()
    {
        int puntos = gm.getPuntos();
        float suma = gm.getSuma();

        if (puntos >= coste) {
            suma += aumento;
            gm.setSuma(suma);
            
            puntos -= coste;
            gm.setPuntos(puntos);
            
            aumento += aumento_aumento;
            // crecimiento exponencial
            coste = (int)(coste * multiplicador_coste);
            mostrarCoste(coste);
            mostrarSuma(suma);
            mb.actualizarPuntos(puntos);
        } else {
            Debug.Log("No tiene suficientes puntos");
        }

    }

    public void mostrarSuma(float suma)
    {
        muestraSuma.text = "Suma: " + suma;
    }

    public void mostrarCoste(int coste)
    {
        muestraCoste.text = "Coste: " + coste;
    }
}
