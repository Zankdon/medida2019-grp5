using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DontDestroy : MonoBehaviour
{
    private void Start()
    {
        var muteBtn = FindObjectOfType<Toggle>();
        Debug.Log("Er denkt vol ist:" + AudioListener.volume);
        if (AudioListener.volume == 1)
        {
            muteBtn.isOn = false;
        }
        else
        {
            muteBtn.isOn = true;
            musik();
        }
        Debug.Log("true?" + muteBtn.isOn);
    }

    private void Awake()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Musik");
        if (objects.Length > 1)
            Destroy(this.gameObject);
        if(this.gameObject.CompareTag("Musik"))
            DontDestroyOnLoad(this.gameObject);
    }

    public void musik()
    {
        if (AudioListener.volume == 1)
        {
            AudioListener.volume = 0;
            Debug.Log("Vol jetzt:" + AudioListener.volume);
        }
        else
            AudioListener.volume = 1;
    }
}