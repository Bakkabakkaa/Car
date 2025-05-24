using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private GameObject _car;

    public void SetTarget(GameObject car)
    {
        _car = car;
    }

    [SerializeField] 
    private Vector3 _offset;

    private void LateUpdate()
    {
        transform.position = _car.transform.position + _offset;
    }
}
