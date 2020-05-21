using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    public GameObject Target;
    public float timer= 0f;
    public Text warningText;


    public float shootTimer = 0f;
    public Text shootTimerText;
    


    void Action()
    {
        if (timer <= 3.0f)
            timer += Time.deltaTime;
        else
        {
            Target.transform.localScale = new Vector3(2, 1, 1);
            warningText.text = "Atire !";
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Action();
    }
}
