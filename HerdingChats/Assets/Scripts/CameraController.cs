using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{

    private Vector3 player;
    private Vector3 topRight;
    private Vector3 topLeft;
    private Vector3 bottomRight;
    private Vector3 bottomLeft;
    private BoxCollider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        player = Vector3.zero;
        topRight = Camera.main.ViewportToWorldPoint(new Vector3(1.0f, 1.0f, -10.0f));
        topLeft = Camera.main.ViewportToWorldPoint(new Vector3(0.0f, 1.0f, -10.0f));
        bottomRight = Camera.main.ViewportToWorldPoint(new Vector3(1.0f, 0.0f, -10.0f));
        bottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0.0f, 0.0f, -10.0f));
        //collider = GetComponentInChildren<BoxCollider2D>();
        //collider.OnRect

    }
    
    /*void LateUpdate()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform.position;
        topRight = Camera.main.ViewportToWorldPoint(new Vector3(1.0f, 1.0f, -10.0f));
        topLeft = Camera.main.ViewportToWorldPoint(new Vector3(0.0f, 1.0f, -10.0f));
        bottomRight = Camera.main.ViewportToWorldPoint(new Vector3(1.0f, 0.0f, -10.0f));
        bottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0.0f, 0.0f, -10.0f));
        if (topRight.x < 50.96 && topRight.y < 46.27)
        {
            if(bottomRight.x < 50.96 && bottomRight.y > -6.54)
            {
                if (topLeft.x > -13.64 && topLeft.y < 46.27)
                {
                    if (bottomLeft.x > -13.64 && bottomLeft.y > -6.54)
                    {
                        gameObject.transform.SetPositionAndRotation(player, Quaternion.identity);
                    }
                }
            }
        }
    }*/
}
