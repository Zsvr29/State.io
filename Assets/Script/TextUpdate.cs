using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUpdate : MonoBehaviour
{
    public TextMeshPro text;
    public float sayac;
    public float katsay�;
    
    void Update()
    {

        sayac += Time.deltaTime*katsay�;
        
        text.text = sayac.ToString("0");

    }
}
