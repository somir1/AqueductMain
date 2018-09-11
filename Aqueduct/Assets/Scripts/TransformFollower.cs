using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TransformFollower : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    [SerializeField]
    private Vector3 offsetPosition;

    [SerializeField]
    private Space offsetPositionSpace = Space.Self;

    [SerializeField]
    private bool lookAt = true;

    public List<GameObject> waterList= new List<GameObject>();

    float waitTime = .5f;
    bool wait = false;

    public GameObject Bottom;
    public float[] dist;

    float minDistanceToFinish;
    int minDistanceToFinishIndex;


    private void Start()
    {
        Wait();
        

    }
    private void Update()
    {
        if (waitTime > 0 && wait == true) {
            waitTime -= Time.deltaTime;
        }
        if (waitTime < 0 ) {
            wait = false;
            makeList();
            waitTime = 1f;
        }

        if (wait == false)
        {
            for (int i = 0; i < 10; i++)
            {
                dist[i] = Vector2.Distance(Bottom.transform.position, waterList[i].transform.position);
            }

            minDistanceToFinish = dist.Min();
            minDistanceToFinishIndex = dist.ToList().IndexOf(minDistanceToFinish);

            target = waterList[minDistanceToFinishIndex].GetComponent<Transform>();
        }

       


    }

    void Wait()
    {
        wait = true;

    }

    void makeList() {
        foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("Water"))
        {
           
            waterList.Add(fooObj);
        }
        sortList();

    }

    void sortList()
    {
        
    }

    private void FixedUpdate()
    {
        if (target == null)
        {
            //Debug.LogWarning("Missing target ref !", this);

            return;
        }

        // compute position
        if (offsetPositionSpace == Space.Self)
        {
            // transform.position = target.TransformPoint(offsetPosition);
            transform.position = Vector3.Lerp(new Vector3(0,transform.position.y,transform.position.z), target.TransformPoint(offsetPosition), 2f * Time.deltaTime);
        }
        else
        {
            //transform.position = target.position + offsetPosition;
            transform.position = Vector3.Lerp(new Vector3 (0, transform.position.y, transform.position.z), target.position + offsetPosition, 2f * Time.deltaTime);
        }

        // compute rotation
        if (lookAt)
        {
            transform.LookAt(target);
        }
        else
        {
            transform.rotation = target.rotation;
        }
    }
}