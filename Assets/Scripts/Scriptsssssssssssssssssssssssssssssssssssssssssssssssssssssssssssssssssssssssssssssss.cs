using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss : MonoBehaviour
{
    Vector3 vitesse;
    void Start()
    {
        vitesse.z = Random.Range(1f, 3f);   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(vitesse * Time.deltaTime, Space.Self);
        if(transform.position.x > 5f)
        {
            Debug.Log(gameObject.name);
        }
    }
}
