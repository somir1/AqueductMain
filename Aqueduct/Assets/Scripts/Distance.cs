using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class Distance : MonoBehaviour
{

    public List<GameObject> waterList = new List<GameObject>();
    public GameObject Bottom;
    public float[] dist;

    public float timer = 1;

    bool stop = false;
    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        if (stop == false)
        {
            timer -= Time.deltaTime;
        }

        if (timer < 0 && stop == false)
        {
            makeList();
            stop = true;
        }



    }
    void sortList()
    {
        for (int i = 0; i < 10; i++)
        {
            dist[i] = Vector2.Distance(Bottom.transform.position, waterList[i].transform.position);
        }

        float minDistanceToFinish = dist.Min();
        int minDistanceToFinishIndex = dist.ToList().IndexOf(minDistanceToFinish);

        Debug.Log(minDistanceToFinish);
    }
    void makeList()
    {

        foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("Water"))
        {
            waterList.Add(fooObj);
        }
        sortList();
    }

}