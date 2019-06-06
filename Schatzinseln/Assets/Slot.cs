using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
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
            if(DragHandler.draggedItem.transform.name.Equals(transform.name))
            {
                DragHandler.draggedItem.transform.SetParent(transform);
                Debug.Log("Richtig!");
            }
            else
            {
                Debug.Log("Falsch!");
            }
            // ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x, y) => x.HasChanged());
        }
    }
    #endregion
}
