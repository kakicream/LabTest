using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;

    private InventoryScript inventory;

    void Awake()
    {
        inventory = GetComponent<InventoryScript>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && inventory.myStuff.bullets > 0)
        {
            Rigidbody bulletsInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletsInstance.AddForce(firePosition.forward * bulletSpeed);
            inventory.myStuff.bullets--;
        }
    }
}
