using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLayers : MonoBehaviour
{
    public GameObject[] Layers;
    int prevLayer;
    public int currentIndex;

    // Start is called before the first frame update
    public void Start()
    {
       
    }

    public void OffLayers()
    {
        foreach (GameObject allLayers in Layers)
        {
            allLayers.SetActive(false);
        }
    }
    public void ChangeLayer(int index)
    {
        OffLayers();
        Layers[index].SetActive(true);
        prevLayer = currentIndex;
        currentIndex = index;
    }

    public void PreviousLayer()
    {
       ChangeLayer(prevLayer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
