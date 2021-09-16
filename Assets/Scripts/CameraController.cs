using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //obtenemos la position de otro objeto
    public Transform playerTransform;

    void Start()
    {
        
    }
    void Update()
    {
        //desde la position del personaje + algo
        var x = playerTransform.position.x + 8;
        var y = playerTransform.position.y + 2;
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
