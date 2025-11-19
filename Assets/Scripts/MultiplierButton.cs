using UnityEngine;
using System.Collections;

public class MultiplierButton : MonoBehaviour
{
    public GameManager gm;
    private bool multiplicador_activo = false;
    public float aumento_multiplicador = 1f;

    public int segundos_multiplicador = 5;

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
        if (!multiplicador_activo)
        {
            multiplicador_activo = true;
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
        yield return new WaitForSeconds(segundos_multiplicador);
        gm.setMultiplicador(1);
        multiplicador_activo = false;
    }

}
