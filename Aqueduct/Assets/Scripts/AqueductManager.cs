using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AqueductManager : MonoBehaviour
{

    int ductL = 1;
    int ductR = 0;
    int ductD = 3;
    int ductH = 0;

    Vector3 mousePosition, targetPosition;

    float distance = 10f;
    public float speed = 1.5f;
    public Transform leftPrefab;
    public Transform rightPrefab;
    public Transform downPrefab;
    public Transform horizontalPrefab;
    public Transform targetObject;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Debug.Log("Duct Left: " + ductL);
            targetObject = leftPrefab;
        }

        if (Input.GetKeyDown("2"))
        {
            Debug.Log("Duct Right: " + ductR);
            targetObject = rightPrefab;
        }

        if (Input.GetKeyDown("3"))
        {
            Debug.Log("Duct Down: " + ductD);
            targetObject = downPrefab;
        }

        if (Input.GetKeyDown("4"))
        {
            Debug.Log("Duct Horizontal: " + ductH);
            targetObject = horizontalPrefab;
        }

        mousePosition = Input.mousePosition;

        targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, distance));

        targetObject.position = targetPosition;

        if (Input.GetMouseButtonUp(0))
        {
            if (targetObject == leftPrefab && ductL > 0) {
                ductL--;
                Debug.Log(ductL);
                Instantiate(targetObject, targetObject.transform.position, targetObject.transform.rotation);

            }

            else if (targetObject == rightPrefab && ductR > 0)
            {
                ductR--;
                Debug.Log(ductR);
                Instantiate(targetObject, targetObject.transform.position, targetObject.transform.rotation);

            }

            else if (targetObject == horizontalPrefab && ductH > 0)
            {
                ductH--;
                Debug.Log(ductH);
                Instantiate(targetObject, targetObject.transform.position, targetObject.transform.rotation);

            }

            else if (targetObject == downPrefab && ductD > 0)
            {
                ductD--;
                Debug.Log(ductD);
                Instantiate(targetObject, targetObject.transform.position, targetObject.transform.rotation);

            }

        }
    }
}


   

     
