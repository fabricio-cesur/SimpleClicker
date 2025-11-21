using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
    using UnityEditor;
#endif

public class SceneManager : MonoBehaviour
{
    public string escenaJuego;
    public string escenaMenu;

    public void cambiarMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(escenaMenu);
    }
    public void cambiarJuego()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(escenaJuego);
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
