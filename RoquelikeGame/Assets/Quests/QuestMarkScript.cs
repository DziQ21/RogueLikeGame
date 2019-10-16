using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestMarkScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    private float deltaY;
    public float maxDelta=0.3f;
    public void setTarget(GameObject a)
    {
        target = a;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position;
        deltaY = (deltaY + 0.2f);
        if (deltaY > maxDelta)
            deltaY -= maxDelta;
        // += (float)deltaY;
        transform.position = transform.position + new Vector3(0, deltaY);
    }
}
