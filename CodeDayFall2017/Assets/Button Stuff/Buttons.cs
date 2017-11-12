using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Button myButton;
    public GameObject entitiyForInsert;
    public Transform spawn;

    void Start()
    {
        Button btn = myButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);                                                                                                                                                                                                                                                                                          
    }
    void TaskOnClick()
    {
        Instantiate(entitiyForInsert, spawn.position, spawn.rotation);
        Debug.Log("You have clicked the button!");
        //spawn the spikes/other stuff
        //passes the info to the secondary button class which then takes input from the user to decide spawn location
        //Instantiate(spikes <-- decided within this class, object.location <-- decided within second  class -->, object.rotation);
    }
}