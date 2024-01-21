using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyerScript : MonoBehaviour
{
    public bool destroyORnot = false;
    private void Start()
    {
        Destroy(gameObject, 1.5f);
    }
    void Update()
    {
        if (transform.position.y <= -15.0f && destroyORnot == true)
        {
            Destroy(gameObject);
        }
    }
}
