using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class AqueductManager : MonoBehaviour
{
    int ductL = 3;
    int ductR = 3;
    int ductD = 3;
    int ductH = 3;

    int Count = -1;
    bool picked = false;

    Vector3 mousePosition, targetPosition;

    float distance = 10f;
    public float speed = 1.5f;
    public Transform leftPrefab;
    public Transform rightPrefab;
    public Transform downPrefab;
    public Transform horizontalPrefab;
    private Transform targetObject;

    public List<GameObject> floorList = new List<GameObject>();

    // Use this for initialization
    void Start()
    {
        foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("Ground"))
        {
            floorList.Add(fooObj);
        }

        floorList = floorList.OrderBy(t => t.name).ToList();

        foreach (GameObject floor in floorList)
        {
            // Debug.Log(floor.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Debug.Log("Duct Left: " + ductL);
            targetObject = leftPrefab;
            picked = true;
        }

        if (Input.GetKeyDown("2"))
        {
            Debug.Log("Duct Right: " + ductR);
            targetObject = rightPrefab;
            picked = true;
        }

        if (Input.GetKeyDown("3"))
        {
            Debug.Log("Duct Down: " + ductD);
            targetObject = downPrefab;
            picked = true;
        }

        if (Input.GetKeyDown("4"))
        {
            Debug.Log("Duct Horizontal: " + ductH);
            targetObject = horizontalPrefab;
            picked = true;
        }

        mousePosition = Input.mousePosition;

        targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, distance));

        if (picked == true)
            targetObject.position = targetPosition;

        if (Input.GetMouseButtonUp(0))
        {
            if (targetObject == leftPrefab && ductL > 0)
            {
                ductL--;
                Debug.Log(ductL);
                Instantiate(targetObject, targetObject.transform.position, targetObject.transform.rotation);
                Count++;
            }

            else if (targetObject == rightPrefab && ductR > 0)
            {
                ductR--;
                Debug.Log(ductR);
                Instantiate(targetObject, targetObject.transform.position, targetObject.transform.rotation);
                Count++;
            }

            else if (targetObject == horizontalPrefab && ductH > 0)
            {
                ductH--;
                Debug.Log(ductH);
                Instantiate(targetObject, targetObject.transform.position, targetObject.transform.rotation);
                Count++;
            }

            else if (targetObject == downPrefab && ductD > 0)
            {
                ductD--;
                Debug.Log(ductD);
                Instantiate(targetObject, targetObject.transform.position, targetObject.transform.rotation);
                Count++;
            }

            /*if (Count == 2 || Count == 6)
             {
                 floorList[Count].GetComponent<PolygonCollider2D>().isTrigger = true;
                 floorList[Count + 1].GetComponent<PolygonCollider2D>().isTrigger = true;
                 Count++;
             }
             else
             {
                 floorList[Count].GetComponent<PolygonCollider2D>().isTrigger = true;
             }*/
        }
    }

    public void OnHorizontal() {
        targetObject = horizontalPrefab;
        picked = true;
    }
    public void OnVertical()
    {
        targetObject = downPrefab;
        picked = true;
    }
    public void OnLeft()
    {
        targetObject = leftPrefab;
        picked = true;
    }
    public void OnRight()
    {
        targetObject = rightPrefab;
        picked = true;
    }
}



