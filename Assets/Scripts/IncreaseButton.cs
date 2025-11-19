using UnityEngine;

public class IncreaseButton : MonoBehaviour
{

    public GameManager gm;
    [Header("Valores")]
    // la cantidad en la que aumentará la suma
    public int aumento = 1;
    public int coste = 10;
    [Header("Aumento de Valores")]
    public int aumento_aumento = 1;
    public int coste_aumento = 10;
    
    void Start()
    {
        gm = FindAnyObjectByType<GameManager>();
        
        if (gm == null)
        {
            Debug.LogError("No se encontró el object manager, arrástrelo manualmente");
        }
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
            coste += coste_aumento;
        } else {
            Debug.LogError("No tiene suficientes puntos");
        }

    }
}
