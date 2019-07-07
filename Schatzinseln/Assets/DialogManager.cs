using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogText;
    private Queue<string> saetze;

    // Start is called before the first frame update
    void Start()
    {
        //saetze = new Queue<string>();
    }
    public void StartDialog(Dialog dialog)
    {
        saetze = new Queue<string>();
        nameText.text = dialog.name;

        saetze.Clear();

        foreach (string satz in dialog.saetze)
        {
            saetze.Enqueue(satz);
        }
        DisplayNextSatz();
    }

    public void DisplayNextSatz()
    {
        if (saetze.Count == 0)
        {
            EndDialog();
            return;
        }

        string satz = saetze.Dequeue();
        dialogText.text = satz;
    }

    void EndDialog()
    {
        if (ButtonManager.lastScene.Equals("StoryEnde"))
        {
            SceneManager.LoadScene("ENDE");
        }
        else
        {
            ButtonManager.geleseneStories = ButtonManager.geleseneStories + 1;
            SceneManager.LoadScene(ButtonManager.lastScene);
            Debug.Log("Ende des Gesprächs");
        }
    }
}



