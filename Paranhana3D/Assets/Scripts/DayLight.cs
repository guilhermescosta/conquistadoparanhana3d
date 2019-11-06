using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayLight : MonoBehaviour {

    public Light lt;

    public float t;

    public Color color1 = new Color(255f / 255f, 152 / 255f, 2 / 255f);  // laranja claro
    public Color color2 = Color.black;

    public Camera cam;

    public float _time;
    public int day;


    // Use this for initialization
    void Start () {
        cam.clearFlags = CameraClearFlags.SolidColor;
        day = 0;
        _time = 6;
       
    }
	
	// Update is called once per frame
	void Update () {
        t = Mathf.PingPong(Time.time, 60f)/ 60f;

        _time += Time.deltaTime;

        

        if (_time>120f ) {
            _time = 0;
            day++;
        }

    
        //Debug.Log(day);
        
        lt.color = Color.Lerp(Color.white, Color.black, t);
       

        t = Mathf.PingPong(Time.time, 60f) / 60f;


        cam.backgroundColor = Color.Lerp(color1, color2, t);
       
    }
}
