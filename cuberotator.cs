using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuberotator : MonoBehaviour {
     public GameObject pickup;
    void Update()
    {
        transform.Rotate (new Vector4 (0, 0, 0, 100) * Time.deltaTime);
    }
}
