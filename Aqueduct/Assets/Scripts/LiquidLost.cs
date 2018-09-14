using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LiquidLost :  LiquidGenarate {
    //variable to track water drops
    float LostLiquid = 0f;

    private void Update()
    {
        YouLose();
    }

    private void Start()
    {
        
    }
    //calculates the amount of water that passes through the off screen trigger. 


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Water")
        {
            LostLiquid++;
            Debug.Log(" You lost " + LostLiquid + " water");
        }
    }

    //tests for losing condition (half of the starting water you began with goes off screen.)
    void YouLose()
    {
        //need to reference the numliquid variable from the LiquidGenerate Script and replace 5 in the if statement with (that value * .5)
        if (LostLiquid >= ((_numLiquid) * .5f)-.5)
        {
            Debug.Log("You lose");
            SceneManager.LoadScene("Lose");
            //TODO switch with script to load losing screen. 
        }
    }



}