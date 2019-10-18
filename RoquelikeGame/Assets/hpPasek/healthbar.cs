using UnityEngine.UI;
using UnityEngine;

public class healthbar : MonoBehaviour
{

    public Image pasek;
    public float filled;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject rycerz = GameObject.Find("rycerz");
        HPScript hpscript = rycerz.GetComponent<HPScript>();
        filled = (float)hpscript.hP;
        filled /= 100;
        pasek.fillAmount = filled;
    }
}
