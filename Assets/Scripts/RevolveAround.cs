using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolveAround : MonoBehaviour
{
    public Transform planet;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(planet.localPosition, Vector3.back, Time.deltaTime * speed);
    }
}
