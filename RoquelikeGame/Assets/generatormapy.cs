using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatormapy : MonoBehaviour
{
    public int width;
    public int height;
    public List<GameObject> tablicaMap;
    public GameObject kraniecPionowy;
    public GameObject kraniecPoziomy;
  

    // Start is called before the first frame update
    void Start()
    {
   
        for (int i = 0; i < height; i++)
        {   
        
                Instantiate(kraniecPionowy, new Vector3(-42f, 32.5f * i, 0f), Quaternion.identity);

            for (int j = 0; j < width; j++)
            {   
		if (i == 0)
               	 Instantiate(kraniecPoziomy, new Vector3(62.5f * j, (width-1) * 32.5f + 29.5f, 0f), Quaternion.identity);

                int randomNumber = Random.Range(0, tablicaMap.Count);
                Instantiate(tablicaMap[randomNumber], new Vector3(62.5f * j, 32.5f * i, 0f), Quaternion.identity);
                Questnemager.AddQuests(tablicaMap[randomNumber].GetComponent<QuestList>().list);
               
		if (i == height - 1)
               	 Instantiate(kraniecPoziomy, new Vector3(62.5f * j, -27f, 0f), Quaternion.identity);

            }
            Instantiate(kraniecPionowy, new Vector3((width-1) * 62.5f + 44.5f, 32.5f * i, 0f), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}