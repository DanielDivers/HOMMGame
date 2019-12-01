using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject unitsPanel;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            bool isActive = unitsPanel.activeSelf;
            unitsPanel.SetActive(!isActive);
        }
    }
}
