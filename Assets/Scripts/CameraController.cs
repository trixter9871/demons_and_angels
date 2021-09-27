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
    
    Vector3 offset = new Vector3(11.67f, 0, -11.67f);
    
    float cameraSpeed = 99999;
    
    // Vector3 MoveTowards(Vector3 a, Vector3 b, float delta)
    // {
    //     return a + (b - a).normalized * delta;
    // }
    
    public MeshRenderer playerOccluder_renderer;
    public LayerMask occlusionLayer;
    
    // void Update()
    // {
    //     CheckPlayerOcclusion();
    // }
    
    // void CheckPlayerOcclusion()
    // {
    //     Vector3 playerPos = Player.GetPlayer().transform.localPosition;
    //     float distToPlayer = Vector3.Distance(transform.localPosition, playerPos);
        
    //     Ray ray = new Ray(transform.localPosition, transform.forward);
    //     RaycastHit hit;
    //     if(Physics.Raycast(ray, out hit, distToPlayer, occlusionLayer))
    //     {
    //         MeshRenderer meshRenderer = hit.collider.GetComponent<MeshRenderer>();
    //         if(meshRenderer && playerOccluder_renderer != )
    //         {
                
    //         }
    //     }
    // }

    void LateUpdate()
    {
        if(target != null)
        {
            Vector3 cameraDesiredPosition = transform.position;
            
            cameraDesiredPosition.y = transform.localPosition.y;
            cameraDesiredPosition.x = target.position.x;
            cameraDesiredPosition.z = target.position.z;
            
            cameraDesiredPosition.x += offset.x;
            cameraDesiredPosition.z += offset.z;
            
            transform.position = Vector3.MoveTowards(transform.position, cameraDesiredPosition, Time.deltaTime * cameraSpeed);
        }
    }
}
