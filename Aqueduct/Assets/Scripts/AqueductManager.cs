using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;


public class AqueductManager : MonoBehaviour
{
    int ductL = 3;
    int ductR = 3;
    int ductD = 3;
    int ductH = 3;

    int Count = -1;
    bool picked = false;

    Vector3 mousePosition, targetPosition;

    public Transform GhostDuctL;
    public Transform GhostDuctV;
    public Transform GhostDuctR;

    public Button leftButton;
    public Button rightButton;
    public Button vertButton;

    public Image redR;
    public Image redV;
    public Image redL;

    public Image Number;
    public Image NumberV;
    public Image NumberR;
    public Sprite[] Numbers;

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
        redV.enabled = false;
        redL.enabled = false;
        redR.enabled = false;

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
        Number.GetComponent<Image>().sprite = Numbers[ductL];
        NumberV.GetComponent<Image>().sprite = Numbers[ductD];
        NumberR.GetComponent<Image>().sprite = Numbers[ductR];

        if (ductD == 0) {
            redV.enabled = true;
        }
        else if (ductR == 0)
        {
            redR.enabled = true;
        }
        else if (ductL == 0)
        {
            redL.enabled = true;
        }


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

    }

    public void Drop()
    {
        foreach (GameObject Obj in GameObject.FindGameObjectsWithTag("Ghost"))
        {

            Destroy(Obj);
        }

        ColorBlock colors = leftButton.colors;

        colors.normalColor = Color.white;

        leftButton.colors = colors;

        rightButton.colors = colors;

        vertButton.colors = colors;

        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null)
        {
            if (hit.collider.tag == "Placeable")
            {
                if (targetObject == leftPrefab && ductL > 0)
                {
                    ductL--;
                    // Debug.Log(ductL);

                    Instantiate(targetObject, targetObject.transform.position, targetObject.transform.rotation);
                    Count++;
                }

                else if (targetObject == rightPrefab && ductR > 0)
                {
                    ductR--;
                    //Debug.Log(ductR);
                  
                    Instantiate(targetObject, targetObject.transform.position, targetObject.transform.rotation);
                    Count++;
                }

                else if (targetObject == downPrefab && ductD > 0)
                {
                    ductD--;
                    //Debug.Log(ductD);

                    Instantiate(targetObject, targetObject.transform.position, targetObject.transform.rotation);
                    Count++;
                }
            }
        }


    }

 

    public void OnVertical()
    {
        targetObject = downPrefab;
        picked = true;

        ColorBlock colors = vertButton.colors;
        colors.normalColor = Color.green;

        vertButton.colors = colors;

        Instantiate(GhostDuctV, new Vector3(0.0f, -10.0f, 0.0f), targetObject.transform.rotation);

    }

    public void OnLeft()
    {
        targetObject = leftPrefab;
        picked = true;

        ColorBlock colors = leftButton.colors;
        colors.normalColor = Color.green;
        
        leftButton.colors = colors;

        Instantiate(GhostDuctL, new Vector3(0.0f, -10.0f, 0.0f), targetObject.transform.rotation);
    }

    public void OnRight()
    {
        targetObject = rightPrefab;
        picked = true;

        ColorBlock colors = rightButton.colors;
        colors.normalColor = Color.green;
        
        rightButton.colors = colors;

        Instantiate(GhostDuctR, new Vector3(0.0f, -10.0f, 0.0f), targetObject.transform.rotation);
    }

}

