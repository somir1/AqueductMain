using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{

    public LiquidGenarate liquidGenarate;
    //amount of water needed to win the game
    public float AmountNeededToWin;
    // Use this for initialization

    public GameObject[] MainCam;
    public GameObject[] ExtendCam;

    int count=0;

    void Start()
    {
        MainCam = GameObject.FindGameObjectsWithTag("MainCamera");
        ExtendCam = GameObject.FindGameObjectsWithTag("ExtendCamera");
       
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(AmountNeededToWin);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Water")
        {
            count++;
            if (count == 1)
            {
                foreach (GameObject obj in MainCam)
                {
                    obj.GetComponent<TransformFollower>().setFinishCam();
                }
                foreach (GameObject obj in ExtendCam)
                {
                    obj.GetComponent<TransformFollower>().setFinishCam();
                }
            }

            AmountNeededToWin++;

            if (AmountNeededToWin >= Mathf.Round((liquidGenarate._numLiquid * .5f)))
            {
                SceneManager.LoadScene("Win");
            }
        }
    }
}