using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseResponses : MonoBehaviour, IPointerClickHandler{

    
    #region IpointerClickHandler implementtion 

    public void OnPointerClick(PointerEventData eventData)
    {
        isRed = !isRed;
        if (isRed)
        {
          // GetComponent<Renderer>().material.color = Color.red;

        }
        else {
           //// GetComponent<Renderer>().material.color = Color.white;
        }
    }

    #endregion
    bool isRed;
    
}
