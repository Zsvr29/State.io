using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour

{
    public Vector3 firstpos, lastpos, screenpoint;
    public LineRenderer lineRenderer;
    private void Start()
    {
        lineRenderer.SetPosition(1, transform.position);
    }
    private void Update()
    {
        screenpoint = Input.mousePosition;
        screenpoint.z = 10;


    }

    public void OnMouseDown()
    {
        firstpos = Camera.main.ScreenToWorldPoint(screenpoint);
        Debug.Log(firstpos);



    }
    public void OnMouseDrag()
    {
        lastpos = Camera.main.ScreenToWorldPoint(screenpoint);

        SetPos(lastpos);

    }
    public void OnMouseUp()
    {
        lastpos = firstpos;

        SetPos(lastpos);
    }

    public void SetPos(Vector2 pos)
    {

        lineRenderer.SetPosition(1, pos);
        lineRenderer.transform.GetChild(0).transform.position = pos;

    }


}


