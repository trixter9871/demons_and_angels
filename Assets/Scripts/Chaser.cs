using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        Transform target = GameObject.FindGameObjectWithTag ("Player").transform;
        Vector3 position = transform.position;
        Vector3 direction = (target.position - transform.position).normalized;

        position = position + direction * speed * Time.deltaTime;

        transform.position = position;
    }
}
