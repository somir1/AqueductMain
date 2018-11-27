using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TransformFollower : MonoBehaviour
{

    [SerializeField]
    public Transform target;

    [SerializeField]
    private Vector3 offsetPosition;

    [SerializeField]
    private Space offsetPositionSpace = Space.Self;

    [SerializeField]
    private bool lookAt = true;

    public List<GameObject> waterList = new List<GameObject>();

    float waitTime = .5f;
    bool wait = false;

    public GameObject Bottom;
    public float[] dist;

    float minDistanceToFinish;
    int minDistanceToFinishIndex;

    int waterListNullCount;

    bool finished = false;


    private void Start()
    {
        Wait();


    }
    private void Update()
    {

        

        if (waitTime > 0 && wait == true)
        {
            waitTime -= Time.deltaTime;
        }
        if (waitTime < 0)
        {
            wait = false;
            makeList();
            waitTime = 1f;
        }

        if (wait == false)
        {

            for (var i = waterList.Count -1; i > -1; i--)
            {
                if (waterList[i] == null)
                {

                    waterList.RemoveAt(i);
                    // GroupResize(waterList.Count, dist);
                    dist[i] = 9999.9f;
                }
            }

            for (int i = 0; i < waterList.Count ; i++)
            {
                if (waterList[i] != null && dist[i] != 9999.9f)
                {
                    dist[i] = Vector2.Distance(Bottom.transform.position, waterList[i].transform.position);
                }
                else
                {
                    waterListNullCount++;
                }
               // if (waterListNullCount >= 8)
                   // Wait();
            }

            minDistanceToFinish = dist.Min();
            minDistanceToFinishIndex = dist.ToList().IndexOf(minDistanceToFinish);

           

            if (waterList[minDistanceToFinishIndex] != null && dist[minDistanceToFinishIndex] != 999.9f && finished == false)
            {
                target = waterList[minDistanceToFinishIndex].GetComponent<Transform>();
               
            }

            
            Refresh();

        }




    }

  

    public void setFinishCam() {
        finished = true;
        target = GetComponent<Transform>();
        
    }

    void Wait()
    {
        wait = true;

    }

    void makeList()
    {
        foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("Water"))
        {

            waterList.Add(fooObj);
        }
        

    }

   public void Refresh()
    {

        

        if (target == null)
        {
            Debug.LogWarning("Missing target ref !", this);
           
            return;
        }

       

        // compute position
        if (offsetPositionSpace == Space.Self && finished == false)
        {
            // transform.position = target.TransformPoint(offsetPosition);
            transform.position = Vector3.Lerp(new Vector3(0, transform.position.y, transform.position.z), target.TransformPoint(offsetPosition), 1.0f * Time.deltaTime);
            Vector3 pos = transform.position;
            pos.y = Mathf.Clamp(transform.position.y, -10000.0f, 0.0f);
            pos.x = Mathf.Clamp(transform.position.x, 0.0f, 0.0f);
            transform.position = pos;
        }
        else if(finished == false)
        {
            //transform.position = target.position + offsetPosition;
            transform.position = Vector3.Lerp(new Vector3(0, transform.position.y, transform.position.z), target.position + offsetPosition, 1.0f * Time.deltaTime);
            Vector3 pos = transform.position;
            pos.y = Mathf.Clamp(transform.position.y, -10000.0f, 0.0f);
            pos.x = Mathf.Clamp(transform.position.x, 0.0f, 0.0f);
            transform.position = pos;
        }

        // compute rotation
        if (lookAt)
        {
            transform.LookAt(target);
        }
        else
        {
            //transform.rotation = target.rotation;
        }
    }
}