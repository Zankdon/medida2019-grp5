using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LexikonNav : MonoBehaviour
{
    public static int seite = 1;

    public void nextPage()
    {
        GameObject.Find("Add" + seite).SetActive(false);
        GameObject.Find("Erk" + seite).SetActive(false);
        seite = seite + 1;
        GameObject.Find("Canvas").transform.Find("Add" + seite).gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Erk" + seite).gameObject.SetActive(true);
        if (seite == 2)
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
        GameObject.Find("Erk" + seite).SetActive(false);
        seite = seite - 1;
        GameObject.Find("Canvas").transform.Find("Add" + seite).gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Erk" + seite).gameObject.SetActive(true);
        if (seite == 1)
        {
            GameObject.Find("ZurueckBtn").SetActive(false);
        }
        if(seite == 11)
        {
            GameObject.Find("Canvas").transform.Find("WeiterBtn").gameObject.SetActive(true);
        }
    }

    public void GoToAddition()
    {
        SceneManager.LoadScene("AdditionsLexikon");
    }

    public void nextPageAdd()
    {
        GameObject.Find("Div" + seite).SetActive(false);
        GameObject.Find("Erk" + seite).SetActive(false);
        seite = seite + 1;
        GameObject.Find("Canvas").transform.Find("Div" + seite).gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Erk" + seite).gameObject.SetActive(true);
        if (seite == 2)
        {
            GameObject.Find("Canvas").transform.Find("ZurueckBtn").gameObject.SetActive(true);
        }
        if (seite == 4)
        {
            GameObject.Find("WeiterBtn").SetActive(false);
        }
    }

    public void prevPageAdd()
    {
        GameObject.Find("Div" + seite).SetActive(false);
        GameObject.Find("Erk" + seite).SetActive(false);
        seite = seite - 1;
        GameObject.Find("Canvas").transform.Find("Div" + seite).gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Erk" + seite).gameObject.SetActive(true);
        if (seite == 1)
        {
            GameObject.Find("ZurueckBtn").SetActive(false);
        }
        if (seite == 3)
        {
            GameObject.Find("Canvas").transform.Find("WeiterBtn").gameObject.SetActive(true);
        }
    }

    public void GoToSubtraktion()
    {
        SceneManager.LoadScene("SubtraktionsLexikon");
    }

    public void nextPageSub()
    {
        GameObject.Find("Sub" + seite).SetActive(false);
        GameObject.Find("Erk" + seite).SetActive(false);
        seite = seite + 1;
        GameObject.Find("Canvas").transform.Find("Sub" + seite).gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Erk" + seite).gameObject.SetActive(true);
        if (seite == 2)
        {
            GameObject.Find("Canvas").transform.Find("ZurueckBtn").gameObject.SetActive(true);
        }
        if (seite == 5)
        {
            GameObject.Find("WeiterBtn").SetActive(false);
        }
    }

    public void prevPageSub()
    {
        GameObject.Find("Sub" + seite).SetActive(false);
        GameObject.Find("Erk" + seite).SetActive(false);
        seite = seite - 1;
        GameObject.Find("Canvas").transform.Find("Sub" + seite).gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Erk" + seite).gameObject.SetActive(true);
        if (seite == 1)
        {
            GameObject.Find("ZurueckBtn").SetActive(false);
        }
        if (seite == 4)
        {
            GameObject.Find("Canvas").transform.Find("WeiterBtn").gameObject.SetActive(true);
        }
    }

    public void GoToMultiplikation()
    {
        SceneManager.LoadScene("MultiplikationsLexikon");
    }

    public void nextPageMul()
    {
        GameObject.Find("Mul" + seite).SetActive(false);
        GameObject.Find("Erk" + seite).SetActive(false);
        seite = seite + 1;
        GameObject.Find("Canvas").transform.Find("Mul" + seite).gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Erk" + seite).gameObject.SetActive(true);
        if (seite == 2)
        {
            GameObject.Find("Canvas").transform.Find("ZurueckBtn").gameObject.SetActive(true);
        }
        if (seite == 7)
        {
            GameObject.Find("WeiterBtn").SetActive(false);
        }
    }

    public void prevPageMul()
    {
        GameObject.Find("Mul" + seite).SetActive(false);
        GameObject.Find("Erk" + seite).SetActive(false);
        seite = seite - 1;
        GameObject.Find("Canvas").transform.Find("Mul" + seite).gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Erk" + seite).gameObject.SetActive(true);
        if (seite == 1)
        {
            GameObject.Find("ZurueckBtn").SetActive(false);
        }
        if (seite == 6)
        {
            GameObject.Find("Canvas").transform.Find("WeiterBtn").gameObject.SetActive(true);
        }
    }

    public void GoToDivision()
    {
        SceneManager.LoadScene("DivisionsLexikon");
    }

    public void GoToLength()
    {
        SceneManager.LoadScene("Längenlexikon");
    }

    public void nextPageLength()
    {
        GameObject.Find("length" + seite).SetActive(false);
        seite = seite + 1;
        GameObject.Find("Canvas").transform.Find("length" + seite).gameObject.SetActive(true);
        if (seite == 2)
        {
            GameObject.Find("Canvas").transform.Find("ZurueckBtn").gameObject.SetActive(true);
        }
        if (seite == 4)
        {
            GameObject.Find("WeiterBtn").SetActive(false);
        }
    }

    public void prevPageLength()
    {
        GameObject.Find("length" + seite).SetActive(false);
        seite = seite - 1;
        GameObject.Find("Canvas").transform.Find("length" + seite).gameObject.SetActive(true);
        if (seite == 1)
        {
            GameObject.Find("ZurueckBtn").SetActive(false);
        }
        if (seite == 3)
        {
            GameObject.Find("Canvas").transform.Find("WeiterBtn").gameObject.SetActive(true);
        }
    }

    public void GoToGewicht()
    {
        SceneManager.LoadScene("Gewichtlexikon");
    }

    public void nextPageGewicht()
    {
        GameObject.Find("gewicht" + seite).SetActive(false);
        seite = seite + 1;
        GameObject.Find("Canvas").transform.Find("gewicht" + seite).gameObject.SetActive(true);
        if (seite == 2)
        {
            GameObject.Find("Canvas").transform.Find("ZurueckBtn").gameObject.SetActive(true);
        }
        if (seite == 2)
        {
            GameObject.Find("WeiterBtn").SetActive(false);
        }
    }

    public void prevPageGewicht()
    {
        GameObject.Find("gewicht" + seite).SetActive(false);
        seite = seite - 1;
        GameObject.Find("Canvas").transform.Find("gewicht" + seite).gameObject.SetActive(true);
        if (seite == 1)
        {
            GameObject.Find("ZurueckBtn").SetActive(false);
        }
        if (seite == 1)
        {
            GameObject.Find("Canvas").transform.Find("WeiterBtn").gameObject.SetActive(true);
        }
    }
}
