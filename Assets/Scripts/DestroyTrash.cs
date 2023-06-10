using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrash : MonoBehaviour
{
    private int angle;
  
    private void Start()
    {
        Destroy(gameObject, 3);
    }
    
    private void Update()
    {
        angle++;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
