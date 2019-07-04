using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelHandler : MonoBehaviour
{
    public static bool isLevel1Completed = false;
    void Start()
    {
        if (isLevel1Completed)
        {
            GameObject.Find("Canvas").transform.Find("Level2Btn").gameObject.SetActive(true);
            GameObject.Find("Level1Btn").SetActive(false);
        }
    }

    public static void level1IsCompleted()
    {
        isLevel1Completed = true;
    }
}
