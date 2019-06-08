using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler
{
    public static int herzen = 3;
    public static int richtig = 5;

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
                richtig = richtig - 1;
                if (richtig < 1)
                {
                    SceneManager.LoadScene("ENDE");
                }
                GameObject.Find("Canvas").transform.Find("Richtig").gameObject.SetActive(true);
                GameObject.Find("Canvas").transform.Find("Falsch").gameObject.SetActive(false);
            }
            else
            {
                Debug.Log("Falsch!");
                Debug.Log(herzen);
                if (herzen > 1)
                {
                    Debug.Log(GameObject.Find("herz" + herzen));
                    GameObject.Find("herz" + herzen).SetActive(false);
                    herzen = herzen - 1;
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
