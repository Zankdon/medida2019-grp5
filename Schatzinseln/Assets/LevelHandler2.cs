using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelHandler2 : MonoBehaviour
{
    public static bool isLevel2Completed = false;
    void Start()
    {
        if (isLevel2Completed)
        {
            GameObject.Find("Canvas").transform.Find("Level2.2Btn").gameObject.SetActive(true);
            GameObject.Find("Level2.1Btn").SetActive(false);
        }
    }

    public static void level2IsCompleted()
    {
        isLevel2Completed = true;
    }
}
