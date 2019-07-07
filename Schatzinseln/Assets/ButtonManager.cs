using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public static string lastScene;
    public static int nextTeillevel = 1;
    public static int nextTeillevelWaage = 1;
    public static int nextTeillevelZeit = 1;
    public static int geleseneStories = 0;
    public static int richtig = 5;
    public static int richtigWaage = 3;
    public static int richtigZeit = 2;
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

    public void GoToInselkartex(int x)
    {
        if (x == 1)

        {
            SceneManager.LoadScene("Inselkarte1");
        }
        else if (x == 2)

        {
            SceneManager.LoadScene("Inselkarte2");
        }
        else if (x == 3)

        {
            SceneManager.LoadScene("Inselkarte3");
        }

        else if (x == 4)

        {
            SceneManager.LoadScene("Inselkarte4");
        }
    }

    public void GoToLexikonx(int x)
    {
        if (x == 1)

        {
            SceneManager.LoadScene("Insel1Lexikon");
        }
        else if (x == 2)

        {
            SceneManager.LoadScene("Insel2Lexikon");
        }
        else if (x == 3)

        {
            SceneManager.LoadScene("Insel3Lexikon");
        }

        else if (x == 4)

        {
            SceneManager.LoadScene("Insel4Lexikon");
        }
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
        geleseneStories = geleseneStories - 1;
        lastScene = "Inselkarte2";
        SceneManager.LoadScene("Story3");
    }

    public void goToStory5()
    {
        geleseneStories = geleseneStories - 1;
        lastScene = "Inselkarte2";
        SceneManager.LoadScene("StoryNachBruecken");
    }

    public void GoToInsel2()
    {
        nextTeillevelWaage = 1;
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

    public void GoToInsel4()
    {
        nextTeillevelZeit = 1;
        if (geleseneStories == 7)
        {
            lastScene = ("Insel4");
            SceneManager.LoadScene("Story7");
        }
        else
        {
            SceneManager.LoadScene("Insel4");
        }
    }

    public void GoToLevelx(int x)
    {
      
        if(nextTeillevel == 1)
        {
            Herzen.herzen = 3;
        }
        if (nextTeillevelWaage == 1)
        {
            Herzen.herzen = 3;
        }
        if (nextTeillevelZeit == 1)
        {
            Herzen.herzen = 3;
        }
        richtig = 5;
        richtigWaage = 3;
        richtigZeit = 2;

        if (x == 1)
        {

            if (geleseneStories == 2)
            {
                int zufall = Random.Range(1, 3);
                lastScene = "Level1.1." + zufall;
                SceneManager.LoadScene("Story1.1");
            }
            else
            {
                GoToLevel1(1);
            }
        }
        else if (x == 2)
        {
            Debug.Log(geleseneStories);
            if (geleseneStories == 3)
            {
                int zufall = Random.Range(1, 3);
                lastScene = "Level2.1." + zufall;
                SceneManager.LoadScene("Story2.1");
            }
            else
            {
                lastScene = "Inselkarte2";
                GoToLevel2(1);
            }
        }
        else if (x == 4)
        {
            Debug.Log(geleseneStories);
            if (geleseneStories == 5)
            {
                int zufall = Random.Range(1, 3);
                lastScene = "Level4.1." + zufall;
                SceneManager.LoadScene("Story6");
            }
        }
        else if (x == 5)
        {
            GoToLevel5(1);
        }
        else if (x == 6)
        {
            GoToLevel6(1);
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

    public static void GoToLevel4(int x)
    {

        richtigWaage = 3;
        int zufall = Random.Range(1, 3);
        Debug.Log("Level4." + x + "." + zufall);
        SceneManager.LoadScene("Level4." + x + "." + zufall);
    }
    
    public static void GoToLevel5(int x)
    {
        richtigZeit = 2;
        int zufall = Random.Range(1, 3);
        Debug.Log("Level5." + x + "." + zufall);
        SceneManager.LoadScene("Level5." + x + "." + zufall);
    }
    public void GoToLevel6(int x)
    {
        int zufall = Random.Range(1, 3);
        Debug.Log(zufall);
        SceneManager.LoadScene("Level6." + x + "." + zufall);
    }

}
