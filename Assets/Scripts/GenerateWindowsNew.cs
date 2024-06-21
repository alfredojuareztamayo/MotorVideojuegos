using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using static UnityEngine.GraphicsBuffer;
using Unity.VisualScripting;

public class GenerateWindowsNew : EditorWindow
{
    [MenuItem("Component/Set Components Horror")]

    public static void ShowWindow()
    {
       EditorWindow.GetWindow<GenerateWindowsNew>("modify model");
       
    }

    private void OnGUI()
     {
        SetAttributs();
    }

    void SetAttributs()
    {
        
        GameObject obj = Selection.activeGameObject;
        obj.AddComponent<Rigidbody>();
        obj.AddComponent<CapsuleCollider>();
    }
}
