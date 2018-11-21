using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeftWaterLoss : MonoBehaviour
{
    //variable that references the RightWaterLoss class. 
    public RightWaterLoss rightLiquidLost;
    //variable that references the liquidgenerateclass.
    public LiquidGenarate liquidGenarate;
    //variable used to store value from LiquidGenerate liquidGenerate (beginning amount of water). 
    public float StartWater;
    //variable that stores the amount of water that passes through the left trigger. 
    public float LeftTriggerWaterLoss;
    //variable used to store the value of the amount of water lost from the right trigger.
    public float AmountRightLost;
    //variable used to store the total amount of water that is lost from both the left and right trigger. 
    public float TotalLiquidLost;


    // Use this for initialization
    void Start()
    {
        StartWater = liquidGenarate._numLiquid;
    }

    private void Update()
    {
        //this updates the amount of water that is being lost from the right trigger and recalculates the total water lost
        //and checks the lose condition.
        AmountRightLost = rightLiquidLost.RightTriggerWaterLoss;
        TotalLiquidLost = LeftTriggerWaterLoss + AmountRightLost;
        LeftLoseCondition();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Water")
        {
            LeftTriggerWaterLoss++;
            //Removing comment from Destroy(col.gameObject) creates an error in TransformFollower.cs 
           Destroy(col.gameObject);
            StartWater -= 1;
        }
    }

    public void LeftLoseCondition()
    {
       // Debug.Log("You lost " + LeftTriggerWaterLoss + " water from the right. And " + AmountRightLost + " from the left. You lose a total of " + TotalLiquidLost + "water");

        if (TotalLiquidLost >= (StartWater * .5) + .5)
        {
            SceneManager.LoadScene("Lose");
        }
    }

}