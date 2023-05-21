using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public bool inView;
    public GameObject indicator;
    public Zappar.ZapparInstantTrackingTarget Tracker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!inView && Input.touchCount > 0)
        {
            Tracker.UserHasPlaced = false;
        }

        if (!inView && !indicator.activeSelf)
        {
            indicator.SetActive(true);
        }
    }
}
