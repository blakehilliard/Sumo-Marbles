using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Exiter
{
    static public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}