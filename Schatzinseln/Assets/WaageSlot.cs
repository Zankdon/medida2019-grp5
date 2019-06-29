using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WaageSlot : MonoBehaviour, IDropHandler
{

    public GameObject item
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    #region IDropHandler implementation
    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            Debug.Log(DragHandler.draggedItem.transform);
            Debug.Log(transform);
            if (DragHandler.draggedItem.transform.name.Equals(transform.name))
            {
                DragHandler.draggedItem.transform.SetParent(transform);
                Debug.Log("Richtig!");
                AudioManager.instance.playRight();
                ButtonManager.richtig = ButtonManager.richtig - 1;
                if (ButtonManager.richtig < 1)
                {
                    int zufall = Random.Range(1, 3);
                    Debug.Log(zufall);
                    SceneManager.LoadScene("Level4." + 2 + "." + zufall);
                }
                GameObject.Find("Canvas").transform.Find("Richtig").gameObject.SetActive(true);
                GameObject.Find("Canvas").transform.Find("Falsch").gameObject.SetActive(false);
            }
            else
            {
                Debug.Log("Falsch!");
                AudioManager.instance.playWrong();
                if (Herzen.herzen > 1)
                {
                    Debug.Log(GameObject.Find("herz" + Herzen.herzen));
                    GameObject.Find("herz" + Herzen.herzen).SetActive(false);
                    Herzen.herzen = Herzen.herzen - 1;
                    GameObject.Find("Canvas").transform.Find("Richtig").gameObject.SetActive(false);
                    GameObject.Find("Canvas").transform.Find("Falsch").gameObject.SetActive(true);
                }
                else
                {
                    SceneManager.LoadScene("GameOver");
                }
            }
            // ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x, y) => x.HasChanged());
        }
    }
    #endregion
}
