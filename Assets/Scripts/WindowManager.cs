using System;
using System.Security;
using UnityEngine;

public class WindowManager : MonoBehaviour
{

    public float aspect_ratio = 9f / 16f;

    public int window_width = 608;
    public int window_height = 1080;

    private bool is_fullscreen = false;

    void Start()
    {
        Screen.SetResolution(window_width, window_height, false);
    }

    void Update()
    {
        toggleFullscreen();
        enforceAspectRatio();
    }

    void toggleFullscreen()
    {
        if (Input.GetKeyDown(KeyCode.F11))
        {
            is_fullscreen = !is_fullscreen;
            if (is_fullscreen)
            {
                Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
            }
            else
            {
                Screen.fullScreenMode = FullScreenMode.Windowed;
                Screen.SetResolution(window_width, window_height, false);
            }
        }
    }

    void enforceAspectRatio()
    {
        float current_aspect = (float)Screen.width / (float)Screen.height;
        if (Math.Abs(current_aspect - aspect_ratio) > 0.01f)
        {
            int newWidth = (int)Math.Round(Screen.height * aspect_ratio);
            Screen.SetResolution(newWidth, Screen.height, false);
        }
    }

}
