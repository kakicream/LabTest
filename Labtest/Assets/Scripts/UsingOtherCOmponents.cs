using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherCOmponents : MonoBehaviour
{
    public GameObject otherGameObject;

    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private CapsuleCollider capColl;

    void Awake()
    {
        anotherScript = otherGameObject.GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        capColl = otherGameObject.GetComponent<CapsuleCollider>();
    }

    void Start()
    {
        capColl.radius = 4f;
        capColl.height = 2.5f;
        Debug.Log("The Player's score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
    }
}
