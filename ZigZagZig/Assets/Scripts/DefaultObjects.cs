
using UnityEngine;

public class DefaultObjects : MonoBehaviour
{
    private Collider _collider;
    private void Start()
    {
        _collider=gameObject.GetComponentInChildren<Collider>();
        
        Invoke("Fall",7f);
        Invoke("DestroyObj",8.6f);
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
