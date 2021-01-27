using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureBeam : MonoBehaviour
{
    [SerializeField] private float distanceRay = 100;
    public Transform laserFirePoint;
    public LineRenderer lineRenderer;
    private Transform myTransform;

    private void Awake()
    {
        myTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        ShootLaser();
    }
   

    private void ShootLaser()
    {
        if(Physics2D.Raycast(myTransform.position, myTransform.right))
        {
            RaycastHit2D hit2D = Physics2D.Raycast(myTransform.position, transform.right);
            DrawRay(laserFirePoint.position, hit2D.point);
        }
        else
        {
            DrawRay(laserFirePoint.position, laserFirePoint.transform.right * distanceRay);
        }
    }

    //Sets 2 points of the line renderer
    private void DrawRay(Vector2 startPos, Vector2 endLaser)
    {
        lineRenderer.SetPosition(0, startPos);
        lineRenderer.SetPosition(1, endLaser);
    }
}
