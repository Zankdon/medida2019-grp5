using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public static string lastScene;
    public static int geleseneStories = 0;
    public static int richtig = 5;

    public void NewGameBtn()
    {
        if(geleseneStories == 0)
        {
            lastScene = ("Inselkarte1");
            SceneManager.LoadScene("Story0");
        }
        else
        {
            SceneManager.LoadScene("Inselkarte1");
        }
    }

    public void CloseGame()
    {
        Debug.Log("CLOSED");
        Application.Quit();
    }

    public void GoToInsel1()
    {
        if (geleseneStories == 1)
        {
            lastScene = ("Insel1");
            SceneManager.LoadScene("Story1");
        }
        else
        {
            SceneManager.LoadScene("Insel1");
        }

    }

    public void GoToInsel2()
    {
        if (geleseneStories == 2)
        {
            lastScene = ("Insel2");
            SceneManager.LoadScene("Story2");
        }
        else
        {
            SceneManager.LoadScene("Insel2");
        }
    }

    public void GoToLevelx(int x)
    {
        Herzen.herzen = 3;
        richtig = 5;
        if (x == 2)
        {
            GoToLevel2(1);
        }
        else
        {
            SceneManager.LoadScene("Level" + x);
        }
    }

    public void GoToLevel2(int x)
    {
        int zufall = Random.Range(1, 3);
        Debug.Log(zufall);
        SceneManager.LoadScene("Level2." + x + "." + zufall);
    }

}
