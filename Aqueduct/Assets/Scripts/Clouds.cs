using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{

    void Update()
    {
       
        transform.position = new Vector2(Mathf.Lerp(transform.position.x, transform.position.x-10, Random.Range(0.04f, 0.08f) * Time.deltaTime), transform.position.y);

    }
}