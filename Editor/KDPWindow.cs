using UnityEditor;
using UnityEngine;

public class KDPWindow : EditorWindow
{
    private Texture2D icon1;
    private Texture2D icon2;
    private Texture2D icon3;

    [MenuItem("Tools/KDP")]
    public static void ShowWindow() 
    { 
        KDPWindow window = GetWindow<KDPWindow>("KDP");
    }

    private void OnEnable()
    {
        icon1 = (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/Icons/cube-icon.png", typeof(Texture2D));
        icon2 = (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/Icons/vfx-icon.png", typeof(Texture2D));
    }

    private void OnGUI()
    {
        if(GUILayout.Button(new GUIContent(icon1, "Add cube"), GUILayout.Width(80), GUILayout.Height(80))) {
            
        }
    }
}
