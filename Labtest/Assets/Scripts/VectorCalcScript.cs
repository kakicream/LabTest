using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorCalcScript : MonoBehaviour
{
    public Vector3 vectorA = new Vector3(2.0f, 3.0f, 7.0f);
    Vector3 vectorB = new Vector3(6.0f, 4.0f, 1.0f);

    float dotVec;
    Vector3 crossVec = new Vector3();

    float VectorDotProduct()
    {
        dotVec = Vector3.Dot(vectorA, vectorB);
        Debug.Log(dotVec);
        return dotVec;
    }

    Vector3 VectorCrossProduct()
    {
        crossVec = Vector3.Cross(vectorA, vectorB);
        Debug.Log(crossVec);
        return crossVec;
    }

    void Start()
    {
        VectorDotProduct();
        VectorCrossProduct();
        Debug.Log($"Dot product is : {dotVec}");
        Debug.Log($"Cross product is : {crossVec}");
    }
}
