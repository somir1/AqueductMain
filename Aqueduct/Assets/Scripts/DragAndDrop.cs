using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool following;
   
    void Start()
    {
        following = true;
    }

    void Update()
    {

        if (following)
        {
            transform.position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), 1.0f);
        }

        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null)
        {
            if (hit.collider.tag == "Placeable")
            {
                GetComponent<SpriteRenderer>().color = new Color(0.37f, 0.86f, 0.0f, 1.0f);
            }
            else {
                GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.35f, 0.25f, 1.0f);
            }
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
}