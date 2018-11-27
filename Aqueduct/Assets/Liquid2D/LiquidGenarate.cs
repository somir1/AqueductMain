using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LiquidGenarate : MonoBehaviour {
	public int _numLiquid = 10;
	public float _width = 1;
	public float _height = 1;
	public GameObject _prefab;
	
	// Use this for initialization
	void Start () {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            for (int i = 0; i < _numLiquid; i++)
            {
                GameObject temp = (GameObject)Instantiate(_prefab);
                float x = Random.Range(-1.0f, 1.0f) * _width / 2;
                float y = Random.Range(-1.0f, 1.0f) * _height / 2;
                temp.transform.localPosition = new Vector3(x + 4.5f, y + 10.7f, 0);
                temp.transform.parent = transform;
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level2")
        {
            for (int i = 0; i < _numLiquid; i++)
            {
                GameObject temp = (GameObject)Instantiate(_prefab);
                float x = Random.Range(-1.0f, 1.0f) * _width / 2;
                float y = Random.Range(-1.0f, 1.0f) * _height / 2;
                temp.transform.localPosition = new Vector3(x + 6.0f, y + 6.0f, 0);
                temp.transform.parent = transform;
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level3")
        {
            for (int i = 0; i < _numLiquid; i++)
            {
                GameObject temp = (GameObject)Instantiate(_prefab);
                float x = Random.Range(-1.0f, 1.0f) * _width / 2;
                float y = Random.Range(-1.0f, 1.0f) * _height / 2;
                temp.transform.localPosition = new Vector3(x + 6.0f, y + 6.0f, 0);
                temp.transform.parent = transform;
            }
        }

        }

}
