using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//https://docs.unity3d.com/ScriptReference/UI.Button-onClick.html
public class ShortestPath : MonoBehaviour
{
    public Button path1, path2, path3;
    private GameObject imgCheck;
    // Start is called before the first frame update
    void Start()
    {
        imgCheck = GameObject.Find("imgCheck");
        imgCheck.SetActive(false);


        // path1 = GameObject.Find("btnPath1").GetComponent<Button>();
        // path2 = GameObject.Find("btnPath2").GetComponent<Button>();
        // path3 = GameObject.Find("btnPath3").GetComponent<Button>();


        path1.onClick.AddListener(() => EvaluatePath(1));
        path2.onClick.AddListener(() => EvaluatePath(2));
        path3.onClick.AddListener(() => EvaluatePath(3));
        

    }

    private int EvaluatePath(int btnNr)
    {
        // Debug.Log("nr: "+btnNr);
        int length = 0;
        switch (btnNr)
        {
            case 1:
                imgCheck.transform.position= path1.transform.position;
                imgCheck.SetActive(true);
                break;
            case 2:
                break;
            case 3:
                break;
        }

        return length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
