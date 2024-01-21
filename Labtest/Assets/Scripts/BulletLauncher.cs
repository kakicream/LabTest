using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    public Rigidbody bullet;
    public Transform firePos;



    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(bullet, firePos.position, firePos.rotation) as Rigidbody;
            projectileInstance.AddForce(firePos.forward * 250f);
        }
    }
}
