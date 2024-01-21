using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rocket;
        public float fuel;

        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rocket = roc;
        }

        public Stuff(int bul, float fu)
        {
            bullets = bul;
            fuel = fu;
        }
        public Stuff()
        {
            bullets = 1;
            grenades = 1;
            rocket = 1;
        }
    }

    public Stuff myStuff = new Stuff(50, 5, 5);

    public Stuff myOtherStuff = new Stuff(50, 1.5f);

    void Start()
    {
        Debug.Log("myStuff properties");
        Debug.Log(myStuff.bullets);
        Debug.Log(myStuff.grenades);
        Debug.Log(myStuff.rocket);
        Debug.Log(myStuff.fuel);

        Debug.Log("myOtherStuff properties");
        Debug.Log(myOtherStuff.bullets);
        Debug.Log(myOtherStuff.grenades);
        Debug.Log(myOtherStuff.rocket);
        Debug.Log(myOtherStuff.fuel);
    }
}

