using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour {

    public DayLight _day;
    public bool isRaining;
    public GameObject _rainPrefab;

    public float rainTimer = 20f;

	// Use this for initialization
	void Start () {
        isRaining = false;
	}

    // Update is called once per frame
    void Update()
    {

        if ( (_day._time > 10) && !isRaining) { 
        int c = Random.Range(1, 10000);
        if (c == 10) {
            isRaining = true;
        }

    }

        if (isRaining)
        {
            StartRain();
        }
}

    void StartRain() {
        _rainPrefab.SetActive(true);
        rainTimer -= Time.deltaTime;
        if (rainTimer < 0) {
            isRaining = false;
            rainTimer = 20;
        }

    }
}
