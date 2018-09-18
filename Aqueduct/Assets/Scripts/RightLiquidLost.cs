using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RightLiquidLost : MonoBehaviour
{

    public LeftWaterTracker rightLiquidLost;
    public LiquidGenarate liquidGenarate;
    public float StartWater;
    public float LeftTriggerWaterLoss;
    public float RightTriggerWaterLoss;
    public float TotalLiquidLost;


    // Use this for initialization
    void Start()
    {
        StartWater = liquidGenarate._numLiquid;
    }


    private void Update()
    {
        RightTriggerWaterLoss = rightLiquidLost.RightTriggerWaterLoss;
        TotalLiquidLost = LeftTriggerWaterLoss + RightTriggerWaterLoss;
        LoseCondition();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Water")
        {
            LeftTriggerWaterLoss++;
            //Removing comment from Destroy(col.gameObject) creates an error in TransformFollower.cs 
            //Destroy(col.gameObject);
        }
    }

    public void LoseCondition()
    {
        //Debug.Log("You lost " + LeftTriggerWaterLoss + " water from the right. And "
        //+ RightTriggerWaterLoss + " from the left. " + "You lose a total of " + TotalLiquidLost + "water");

        if (TotalLiquidLost >= (StartWater * .5) - .5)
        {
            SceneManager.LoadScene("Lose");
        }
    }

}
