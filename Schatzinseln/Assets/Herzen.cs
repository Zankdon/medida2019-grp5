using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Herzen : MonoBehaviour
{
    public static int herzen = 3;
    // Start is called before the first frame update
    void Start()
    {
        int anzahlHerzen = herzen;
        while (anzahlHerzen > 0)
        {
            GameObject.Find("Canvas").transform.Find("herz" + anzahlHerzen).gameObject.SetActive(true);
            anzahlHerzen = anzahlHerzen - 1;
        }
    }

    public void machHerzKaputt()
    {
        if(herzen > 1)
        {
            AudioManager.instance.playWrong();
            GameObject.Find("herz" + herzen).SetActive(false);
            herzen = herzen - 1;
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}
