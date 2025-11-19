using UnityEngine;
using TMPro;
using System.Collections;


public class GameManager : MonoBehaviour
{
    private int puntos = 0;
    private float suma = 1;
    private float multiplicador = 1;

    public int getPuntos() { return puntos; }
    public float getSuma() { return suma; }
    public float getMultiplicador() { return multiplicador; }
    public void setPuntos(int puntos) { this.puntos = puntos; }
    public void setSuma(float suma) { this.suma = suma; }
    public void setMultiplicador(float multiplicador) { this.multiplicador = multiplicador; }


    /*
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
    */

    /*
    public IEnumerator timerMultiplicador()
    {
        yield return new WaitForSeconds(5);
        multiplicador = 1;
        multiplicadorActivo = false;
    }
    */
    
}
