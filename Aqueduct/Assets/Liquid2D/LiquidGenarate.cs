using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidGenarate : MonoBehaviour {
	public int _numLiquid = 10;
	public float _width = 1;
	public float _height = 1;
	public GameObject _prefab;
	
	// Use this for initialization
	void Start () {
		for (int i = 0; i < _numLiquid; i++) {
			GameObject temp = (GameObject)Instantiate (_prefab);
			float x = Random.Range (-1.0f, 1.0f) * _width / 2;
			float y = Random.Range (-1.0f, 1.0f) * _height / 2;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
			temp.transform.localPosition = new Vector3 (x, y, 0);
=======
			temp.transform.localPosition = new Vector3 (x+3, y+3, 0);
>>>>>>> parent of ccb7ec3... Merge branch 'master' of https://github.com/somir1/AqueductMain
=======
			temp.transform.localPosition = new Vector3 (x+3, y+3, 0);
>>>>>>> parent of ccb7ec3... Merge branch 'master' of https://github.com/somir1/AqueductMain
=======
			temp.transform.localPosition = new Vector3 (x+3, y+3, 0);
>>>>>>> parent of ccb7ec3... Merge branch 'master' of https://github.com/somir1/AqueductMain
=======
			temp.transform.localPosition = new Vector3 (x+3, y+3, 0);
>>>>>>> parent of ccb7ec3... Merge branch 'master' of https://github.com/somir1/AqueductMain
=======
			temp.transform.localPosition = new Vector3 (x+3, y+3, 0);
>>>>>>> parent of ccb7ec3... Merge branch 'master' of https://github.com/somir1/AqueductMain
=======
			temp.transform.localPosition = new Vector3 (x+3, y+3, 0);
>>>>>>> parent of bfce78a... Distance Sript Added
=======
			temp.transform.localPosition = new Vector3 (x+3, y+3, 0);
>>>>>>> parent of bfce78a... Distance Sript Added
			temp.transform.parent = transform;
		}
	}

}
