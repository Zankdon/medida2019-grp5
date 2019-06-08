using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    private void Start()
    {
        var muteBtn = GetComponent<UnityEngine.UI.Toggle>();
        if (AudioListener.volume == 1)
        {
            muteBtn.isOn = false;
        }
        else
        {
            muteBtn.isOn = true;
            musik();
        }
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
            AudioListener.volume = 0;
        else
            AudioListener.volume = 1;
    }
}