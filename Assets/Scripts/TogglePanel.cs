using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePanel : MonoBehaviour
{
    public GameObject panel;

    public void togglepanel()
    {
        panel.SetActive(!panel.active);
    }
}
