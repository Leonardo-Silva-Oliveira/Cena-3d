using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulomaior : MonoBehaviour
{
    public Vector3 scaleChange;
    public Vector3 positionChange;
    public Vector3 rotateChange;

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(0.0f, 1.0f) / 1000.0f;
        float y = Random.Range(0.0f, 1.0f) / 1000.0f;
        float z = Random.Range(0.0f, 1.0f) / 1000.0f;
        scaleChange.Set(x, x, x);
        positionChange.Set(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += scaleChange;
        transform.position += positionChange;
        transform.rotation = Random.rotation;
    }
}
