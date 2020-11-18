using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inwardrotation : MonoBehaviour
{
    private float Rot = 0.0f;


    void Start()
    {
        InvokeRepeating("Scale",0.0f,0.025f);
    }

    void Scale()
    {
      if (Rot >= 100.0f)
      {
        Rot = 0.025f;
      }
      GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(0,Rot++);
    }
}
