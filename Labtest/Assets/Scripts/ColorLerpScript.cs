using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorLerpScript : MonoBehaviour
{
    public float mixRatio;
    Color mix1 = new Color (1f, 0.8f, 0.9f, 0.2f);
    Color mix2 = new Color(0.2f, 0.4f, 0.6f, 0.17f);
    Color lerpColor;
    void Start()
    {
    }

    void Update()
    {
        mix2 = new Color(0.2f, 0.4f, 0.6f, mixRatio);

        lerpColor = Color.Lerp(mix1, mix2, Time.deltaTime);
        GetComponent<Renderer>().material.color = lerpColor;
    }
}
