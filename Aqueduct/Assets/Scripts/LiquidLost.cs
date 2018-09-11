using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidLost : MonoBehaviour {
    //variable to track water drops
    int LostLiquid = 0;

    private void Update()
    {
        YouLose();
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
        if (LostLiquid >= 5)
        {
            Debug.Log("You lose");
            //TODO switch with script to load losing screen. 
        }
    }

}