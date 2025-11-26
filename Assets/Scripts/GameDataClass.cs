[System.Serializable]
public class GameDataClass
{
    public int puntos;
    public float suma;
    public float multiplicador;

    public GameDataClass(int puntos, float suma, float multiplicador)
    {
        this.puntos = puntos;
        this.suma = suma;
        this.multiplicador = multiplicador;
    }
}