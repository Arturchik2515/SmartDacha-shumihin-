using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLayers : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject RegMenu;
    public GameObject EnterMenu;
    public GameObject ConditionMenu;
    public GameObject UserEnterMenu;
    // Start is called before the first frame update
    public void Start()
    {
        EnterMenu.SetActive(true);
        UserEnterMenu.SetActive(false);
        MainMenu.SetActive(false);
        RegMenu.SetActive(false);
        ConditionMenu.SetActive(false);
            
    }

    public void ChangeLayer(GameObject nextLayer)
    {
        EnterMenu.SetActive(false);
        nextLayer.SetActive(true);
        EnterMenu = nextLayer;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
