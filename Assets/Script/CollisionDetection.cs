using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CollisionDetection : MonoBehaviour
{
    public GameObject obje;
    public List<GameObject> objects = new List<GameObject>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<TextUpdate>().sayac -= transform.parent.GetComponent<TextUpdate>().sayac;

        }
    }

}
