using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceController : MonoBehaviour
{
    [SerializeField] private float speed = 0.8f;


    void Update()
    {
        float cameraLeftEdge = Camera.main.ViewportToWorldPoint(new Vector3(0 ,0.5f, Camera.main.nearClipPlane)).x;
        transform.Translate(speed * Time.deltaTime * Vector2.left);
        if(transform.position.x + transform.localScale.x < cameraLeftEdge ){
            Destroy(gameObject);
        }

    }
}
