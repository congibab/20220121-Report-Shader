using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaerControll : MonoBehaviour
{
    [SerializeField]
    Renderer material;

    Vector4 PlanePosition;
    float index = 0;

    // Start is called before the first frame update
    void Start()
    {
        PlanePosition = new Vector4(0.0f, 0.0f, 0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        index += Time.deltaTime;
        var result = Mathf.Sin(index);
        PlanePosition.y = Mathf.Lerp(-2.5f, 2.5f, Mathf.Abs(result));
        material.sharedMaterial.SetVector("_PlanePosition", PlanePosition);
    }
}
