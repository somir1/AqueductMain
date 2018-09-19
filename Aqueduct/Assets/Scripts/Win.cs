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
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(AmountNeededToWin);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Water")
        {
            AmountNeededToWin++;
            if (AmountNeededToWin >= Mathf.Round((liquidGenarate._numLiquid * .5f)))
            {
                SceneManager.LoadScene("Win");
            }
        }
    }
}