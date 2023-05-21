using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_Load : MonoBehaviour
{
    public GameObject[] dinos;
    public int SelectedInd = 0;
    // Start is called before the first frame update
    void OnEnable()
    {
        int ind = 0;
        foreach (GameObject d in dinos)
        {
            if (SelectedInd == ind)
            {
                d.SetActive(true);
            }
            else
            {
                d.SetActive(false);
            }
            ind++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
