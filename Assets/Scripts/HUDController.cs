using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    private string previousLog = "";
    public static HUDController instance;
    void Awake() {
        instance = this;
    }
    public Text motesText, healthLevelsText, turnTrackerText, logText;
    public Button inventoryButton, charmsButton, statsButton;
    public GameObject inventoryObject, charmsObject, statsObject, actionsObject;

    public void logAction(string action) {
        logText.text = previousLog + "\n" + action;
        previousLog = action;
    }

}
