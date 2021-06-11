using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour {

    public GameObject[] prefabs;

    // Use this for initialization
    void Start () {
        Instantiate(prefabs[PlayerStorage.playerPrefab3], this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
