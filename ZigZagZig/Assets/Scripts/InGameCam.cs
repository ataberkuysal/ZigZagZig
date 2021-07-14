using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameCam : MonoBehaviour
{
    [SerializeField]
    private Transform _playerTransform;

    private Vector3 distance;
    private Vector3 pos;
    void Start()
    {
        distance = _playerTransform.position-transform.position;
        pos = transform.position;
    }
    void Update()
    {
        pos.z = _playerTransform.position.z - distance.z;
        transform.position = pos;
        // transform.position = new Vector3(
        //     Mathf.Clamp(transform.position.x, transform.position.x, transform.position.x),
        //     _playerTransform.position.y - distance.y, _playerTransform.position.z - distance.z);
    }
}
