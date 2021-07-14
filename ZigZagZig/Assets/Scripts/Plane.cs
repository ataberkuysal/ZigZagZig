
using UnityEngine;

public class Plane : MonoBehaviour
{
    [SerializeField]
    private Transform _playerTransform;
    
    private Collider _collider;

    private void Start()
    {
        _collider=GetComponent<Collider>();
    }
    
    private void Update()
    {
        if (_playerTransform.position.y < 2.4f)
        {
            _collider.isTrigger = true;
        }
    }
}