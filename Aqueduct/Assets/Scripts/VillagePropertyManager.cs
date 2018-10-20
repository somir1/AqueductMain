using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VillagePropertyManager : MonoBehaviour {

    public List<GameObject> VillageItems = new List<GameObject>();

    public float propertyDamage = 0;
    public float totalItems = 0;
    public float numItemsLost = 0;
    public float maxLoss = 0;

    public Slider progressBar;
        
    void Start () {

        foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("Village"))
        {
            VillageItems.Add(fooObj);
        }

        totalItems = VillageItems.Count;
        //Debug.Log(totalItems);

        maxLoss = 0.5f;
        //Debug.Log(maxLoss);

        

    }

    void Update () {
        
        //progress bar
        propertyDamage = (numItemsLost / totalItems);
        progressBar.value = propertyDamage;

        if (propertyDamage >= maxLoss) {
            SceneManager.LoadScene("Lose");
        }
	}

   
}
