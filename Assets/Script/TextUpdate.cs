using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUpdate : MonoBehaviour
{
    public TextMeshPro text;
    public float sayac;
    public float katsayý;
    
    void Update()
    {

        sayac += Time.deltaTime*katsayý;
        
        text.text = sayac.ToString("0");

    }
}
