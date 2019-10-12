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
    //private int widthPom;
    //private int heightPom;

    // Start is called before the first frame update
    void Start()
    {
        //if (height % 2 == 0)
        //    heightPom = (height / 2 * 32);
        //else
        //   heightPom = height / 2 * 32 + 32;

        //if (width % 2 == 0)
        //    widthPom = (width / 2 * 62);
        //else
        //    widthPom = width / 2 * 62 + 30;


        for (int i = 0; i < height; i++)
        {   
        
                Instantiate(kraniecPionowy, new Vector3(-80f, 32.5f * i, 0f), Quaternion.identity);

            for (int j = 0; j < width; j++)
            {
                Instantiate(kraniecPoziomy, new Vector3(62.5f * j, (width-1) * 32.5f + 68f, 0f), Quaternion.identity);

                int randomNumber = Random.Range(0, tablicaMap.Count);
                Instantiate(tablicaMap[randomNumber], new Vector3(62.5f * j, 32.5f * i, 0f), Quaternion.identity);
                Questnemager.AddQuests(tablicaMap[randomNumber].GetComponent<QuestList>().list);
                //do
                //{
                //    Instantiate(kraniecPoziomy, new Vector3(32.5f * j, 32.5f + (height / 2.0f * 32.5f), 0f), Quaternion.identity);
                //}  while (i < 1);
                Instantiate(kraniecPoziomy, new Vector3(62.5f * j, -66f, 0f), Quaternion.identity);

            }
            Instantiate(kraniecPionowy, new Vector3((width-1) * 62.5f + 73.5f, 32.5f * i, 0f), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}