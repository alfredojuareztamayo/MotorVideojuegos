using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Windows : EditorWindow
{
    string miString = string.Empty;
    Color color = Color.white;
   //[MenuItem("GameObject/3D Object/Ejemplo")] para modificar que salga con el click derecho en el inspector 
   [MenuItem("Window/Ejemplo")]
   public static void ShowWindow()
    {
        EditorWindow.GetWindow<Windows>("First window");
    }

    private void OnGUI()
    {
        GUILayout.Label("Mensaje de muestra", EditorStyles.boldLabel);
        miString = EditorGUILayout.TextField("Name: " ,miString);
        if(GUILayout.Button("Press me"))
        {
            Debug.Log("Me presionaste");
        };

        GUILayout.Label("Color changer", EditorStyles.boldLabel);
        color = EditorGUILayout.ColorField("Color", color);

        if (GUILayout.Button("Color"))
        {
            Colorea();
        };
    }

    void Colorea()
    {
        foreach(GameObject obj in Selection.gameObjects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if(renderer != null)
            {
                renderer.sharedMaterial.color = color;
            }
        }
    }
}
