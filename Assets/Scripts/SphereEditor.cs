using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Spheres))]

public class SphereEditor : Editor
{
    public override void OnInspectorGUI()
    {
        
        //base.OnInspectorGUI();
        Spheres spheres = (Spheres)target;
        GUILayout.Label("Ocila en funcion al tamaño base");
        spheres.baseSize = EditorGUILayout.Slider("Tamaño", spheres.baseSize, 1f, 2f);
        spheres.transform.localScale = Vector3.one*spheres.baseSize;

        if (GUILayout.Button("ChangeSiza"))
        {
            spheres.Update() ;
        };
    }
}
