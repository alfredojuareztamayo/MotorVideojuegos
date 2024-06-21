using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheres : MonoBehaviour
{
    public float baseSize = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void Update()
    {
        ChangeSize();   
    }
   public void ChangeSize()
    {
        float animation = baseSize *Mathf.Sin( Time.time *8f)*baseSize/7f;
        transform.localScale = Vector3.one * animation;
    }
}
