using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RightWaterLoss : MonoBehaviour
{
    //variable that references the LeftWaterLoss class. 
    public LeftWaterLoss leftWaterLoss;
    //variable that references the LiquidGenerate class.
    public LiquidGenarate liquidGenarate;
    //variable used to store value from LiquidGenerate liquidGenerate (beginning amount of water). 
    public float StartWater;
    //variable that stores the amount of water that passes through the right trigger.
    public float RightTriggerWaterLoss;
    //variable used to store the value of the amount of water lost from the left trigger.
    public float AmountLeftLost;
    //variable used to store the total amount of water that is lost from both the left and right trigger. 
    public float TotalLiquidLost;

    // Use this for initialization
    void Start()
    {
        StartWater = liquidGenarate._numLiquid;
    }

    // Update is called once per frame
    void Update()
    {
        //this updates the amount of water that is being lost from the left trigger and recalculates the total water lost
        //and checks the lose condition.
        AmountLeftLost = leftWaterLoss.LeftTriggerWaterLoss;
        TotalLiquidLost = RightTriggerWaterLoss + AmountLeftLost;
        RightLoseCondition();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Water")
        {
            RightTriggerWaterLoss++;
            //Removing comment from Destroy(col.gameObject) creates an error in TransformFollower.cs 
            Destroy(col.gameObject);
            StartWater -= 1;
        }
    }

    public void RightLoseCondition()
    {
        // Debug.Log("You lost " + RightTriggerWaterLoss + " water from the right. And " +AmountLeftLost+" from the left. You lose a total of " +TotalLiquidLost + "water");
        if (TotalLiquidLost >= (StartWater * .5) + .5)
        {
            SceneManager.LoadScene("Lose");
        }
    }

}