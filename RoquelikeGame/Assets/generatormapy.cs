using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatormapy : MonoBehaviour
{
    public int width;
    public int height;
    public List<GameObject> tablicaMap;
    // Start is called before the first frame update
    void Start()
    {
        
        for(int i=0;i<height;i++)
            for (int j = 0; j < width; j++)
                Instantiate(tablicaMap[Random.Range(0, 2)],new Vector3(62.5f*j,32.5f*i,0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
