using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTimeScript : MonoBehaviour
{
    public float speed = 8f;
    public float countDown = 3.0f;
    private Light lightTest;
    private void Start()
    {
        lightTest = GetComponent<Light>();
    }

    void Update()
    {
        Debug.Log($"Time : {countDown}");
        countDown -= Time.deltaTime;
        if (countDown <= 0.0f)
        {
            lightTest.enabled = true;
            Debug.Log("Light ON");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
        }
    }
}
