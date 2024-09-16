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

    private Texture2D LoadIcon(string name) 
    {
        string path = "Packages/com.k2spam/kdp/Editor/Icons/";
        return (Texture2D)AssetDatabase.LoadAssetAtPath(path+name, typeof(Texture2D));
    }

    private void OnEnable()
    {
        icon1 = LoadIcon("cube-icon.png");
        icon2 = LoadIcon("vfx-icon.png");
    }

    private void OnGUI()
    {
        if(GUILayout.Button(new GUIContent(icon1, "Add cube"), GUILayout.Width(80), GUILayout.Height(80))) {
            
        }
    }
}
