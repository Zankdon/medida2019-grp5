using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LexikonNav : MonoBehaviour
{
    public static int seite = 1;

    public void nextPage()
    {
        
         GameObject.Find("Add" + seite).SetActive(false);
         seite = seite + 1;
         GameObject.Find("Canvas").transform.Find("Add" + seite).gameObject.SetActive(true);
         if(seite == 2)
         {
             GameObject.Find("Canvas").transform.Find("ZurueckBtn").gameObject.SetActive(true);
         }
         if(seite == 12)
         {
             GameObject.Find("WeiterBtn").SetActive(false);
         }

    }
    public void prevPage()
    {
        GameObject.Find("Add" + seite).SetActive(false);
        seite = seite - 1;
        GameObject.Find("Canvas").transform.Find("Add" + seite).gameObject.SetActive(true);
        if(seite == 1)
        {
            GameObject.Find("ZurueckBtn").SetActive(false);
        }
        if(seite == 11)
        {
            GameObject.Find("Canvas").transform.Find("WeiterBtn").gameObject.SetActive(true);
        }
    }
}
