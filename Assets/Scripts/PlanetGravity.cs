using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public float gravityDistance = 150.0f;
    public float gravityForce = 50.0f;

    private GameObject[] planets;
    private Rigidbody2D rb;
    private float lookAngle;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        planets = GameObject.FindGameObjectsWithTag("Planet");
    }

    void Update()
    {   
        // Distance to the planet
        Vector3 v = new Vector3(0, 0, 0);
        
        float mass = 0;
        float dist = 0;

        for(int i=0;i<planets.Length;i++){
            Vector3 temp = (planets[i].transform.position - transform.position);
            temp = temp.normalized;

            mass = planets[i].GetComponent<Rigidbody2D>().mass;
            dist = Vector3.Distance(planets[i].transform.position, transform.position);

            if(dist > 15.0f) continue;
            if(dist <= 5.0f) dist = 0.5f;

            v += temp * mass / dist;
        }

        // Gravity
        dist = Vector3.Distance(v, transform.position);

        rb.AddForce(v.normalized * (1.0f - dist / gravityDistance) * gravityForce);

        lookAngle = 90 + Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle);
    }
}
