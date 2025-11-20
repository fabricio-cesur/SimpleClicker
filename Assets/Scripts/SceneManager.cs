using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
    using UnityEditor;
#endif

public class SceneManager : MonoBehaviour
{
    public void cambiarMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuEscena");
    }
    public void cambiarJuego()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("JuegoEscena");
    }

    public void salirDelJuego()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
