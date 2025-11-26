using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public GameDataClass gameData;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void guardarDatos()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string ruta = Application.persistentDataPath + "/Data/data.dat";
        FileStream file = File.Create(ruta);
        formatter.Serialize(file, gameData);
        file.Close();
    }

    public void cargarDatos()
    {
        if (gameData == null)
        {
            gameData = new GameDataClass(0, 1, 1);
        }
        string ruta = Application.persistentDataPath + "/Data/data.dat";
        if (File.Exists(ruta))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file = File.Open(ruta, FileMode.Open);
            gameData = (GameDataClass)formatter.Deserialize(file);
            file.Close();
        }
    }
}