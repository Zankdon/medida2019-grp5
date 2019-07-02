using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public static string lastScene;
    public static int nextTeillevel = 1;
    public static int geleseneStories = 0;
    public static int richtig = 5;
    public static int richtigWaage = 0;
    public static int inselKarte = 1;


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
        nextTeillevel = 1;
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

    public void goToStory3()
    {
        lastScene = "Inselkarte2";
        SceneManager.LoadScene("Story3");
    }

    public void GoToInsel2()
    {
        if (geleseneStories == 4)
        {
            lastScene = ("Insel2");
            SceneManager.LoadScene("Story4");
        }
        else
        {
            SceneManager.LoadScene("Insel2");
        }
    }

    public void GoToInsel3()
    {
        if (geleseneStories == 5)
        {
            lastScene = ("Insel3");
            SceneManager.LoadScene("Story5");
        }
        else
        {
            SceneManager.LoadScene("Insel3");
        }
    }

    public void GoToLevelx(int x)
    {
        if(nextTeillevel == 1)
        {
            Herzen.herzen = 3;
        }
        richtig = 5;
        if (x == 1)
        {
            GoToLevel1(1);
        }
        else if (x == 2)
        {
            lastScene = "Inselkarte2";
            GoToLevel2(1);
        }
        else if (x == 4)
        {
            GoToLevel4(1);
        }
        else
        {
            SceneManager.LoadScene("Level" + x);
        }
    }

    public static void GoToLevel1(int x)
    {
        if (x == 3)
        {
            richtig = 6;
        }
        else
        {
            richtig = 5;
        }
        int zufall = Random.Range(1, 3);
        Debug.Log("Level1." + x + "." + zufall);
        SceneManager.LoadScene("Level1." + x + "." + zufall);
    }

    public void GoToLevel2(int x)
    {
        int zufall = Random.Range(1, 3);
        Debug.Log(zufall);
        SceneManager.LoadScene("Level2." + x + "." + zufall);
    }

    public void GoToLevel3(int x)
    {
        SceneManager.LoadScene("Level3." + x);
    }

    public void GoToLevel4(int x)
    {
       
        Herzen.herzen = 3;
        richtigWaage = 0;
        int zufall = Random.Range(1, 3);
        Debug.Log(zufall);
        SceneManager.LoadScene("Level4." + x + "." + zufall);
    }
}
