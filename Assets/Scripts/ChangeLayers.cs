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
    public GameObject Categories;
    public GameObject SwimmingPool;
    // Start is called before the first frame update
    public void Start()
    {
        EnterMenu.SetActive(true);
        RegMenu.SetActive(false);
        MainMenu.SetActive(false);
        ConditionMenu.SetActive(false);
        UserEnterMenu.SetActive(false);
        Categories.SetActive(false);
        SwimmingPool.SetActive(false);
    }

    public void ChangeLayer(GameObject nextLayer)
    {
        EnterMenu.SetActive(false);
        nextLayer.SetActive(true);
        EnterMenu = nextLayer;

    }

    public void PreviousLayer(GameObject preLayer)
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
