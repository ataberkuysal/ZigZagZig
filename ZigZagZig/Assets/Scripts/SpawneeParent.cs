
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawneeParent : MonoBehaviour
{
    private Collider _collider;
    private void Start()
    {
        _collider=gameObject.GetComponentInChildren<Collider>();
        
        Invoke("Fall",7.3f);
        Invoke("DestroyObj",8.4f);
    }
    
    void DestroyObj()
    {
        Destroy(gameObject);
    }
    
    void Fall()
    {
        _collider.isTrigger = true;
    }
}
