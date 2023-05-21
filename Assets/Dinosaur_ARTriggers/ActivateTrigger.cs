using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTrigger : MonoBehaviour
{
    public AR_Load arloader;
    public int SelectInd = 0;
    public GameObject indicator;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            arloader.SelectedInd = SelectInd;
            indicator.SetActive(true);
        }
    }
}
