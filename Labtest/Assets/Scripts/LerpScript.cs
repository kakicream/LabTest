using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float result = Mathf.Lerp(3f, 5f, 0.4f);
        Debug.Log($"Math Lerp Result : {result}");

        Vector3 from = new Vector3(1f, 2f, 3f);
        Vector3 to = new Vector3(5f, 6f, 7f);

        Vector3 vecRes = Vector3.Lerp(from, to, 0.75f);
        Debug.Log($"Vector Lerp Result : {vecRes}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
