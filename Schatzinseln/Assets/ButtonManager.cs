using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void NewGameBtn()
    {
        SceneManager.LoadScene("Inselkarte1");
    }

    public void CloseGame()
    {
        Debug.Log("CLOSED");
        Application.Quit();
    }

    public void GoToInsel1()
    {
        SceneManager.LoadScene("Insel1");
    }

    public void GoToLevelx(int x)
    {
        SceneManager.LoadScene("Level" + x);
        Debug.Log(x);
    }
}
