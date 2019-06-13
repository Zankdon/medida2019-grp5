using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public static string lastScene;
    public static int geleseneStories = 0;

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

    public void GoToLevelx(int x)
    {
        Slot.herzen = 3;
        Slot.richtig = 5;
        SceneManager.LoadScene("Level" + x);
    }

}
