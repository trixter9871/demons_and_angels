using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public void SetTarget(Transform _target)
    {

        target = _target;
    }


    void Start()
    {
        
    }

    void Update()
    {
        if(target != null)
        {
            Vector3 position = transform.position;
            position.x = target.position.x;
            position.z = target.position.z;
            transform.position = position;        
        }
    }
}
