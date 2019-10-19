using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseAndResume : MonoBehaviour
{
    public bool pauseAndResumeBool;
    // Start is called before the first frame update
    void Start()
    {
        pauseAndResumeBool = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            onPause();

        }
    }
    public void onPause()
    {
        pauseAndResumeBool = !pauseAndResumeBool;
        if (!pauseAndResumeBool)
        {
            Time.timeScale = 1;
        }
        else if (pauseAndResumeBool)
        {
            Time.timeScale = 0;
        }


    } 
}
