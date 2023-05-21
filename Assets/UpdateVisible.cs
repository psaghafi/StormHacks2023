using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UpdateVisible : MonoBehaviour

{
    public TouchController tc;
    float timePass = 0;

    int activate = 0;

    // Use this for initialization

    void Start()

    {

        StartCoroutine(DelayedControl());

    }



    void OnDestroy()

    {

        StopCoroutine(DelayedControl());

    }



    void OnWillRenderObject()

    {

        timePass += Time.deltaTime;



        if (timePass > 0.5f)

        {

            timePass = 0.0f;

            // print(gameObject.name + " is being rendered by " + Camera.current.name + " at " + Time.time);



            if (Camera.current.name == "Zappar Camera Rear(Clone)" || Camera.current.name == "Zappar Camera Background")

            {

                //GameManager.Instance.ARBeeVisible = true;
                tc.inView = true;

                activate = 0;

            }

        }

    }



    IEnumerator DelayedControl()

    {

        while (true)

        {

            activate++;

            if (activate > 1)

            {

                // GameManager.Instance.ARBeeVisible = false;
                tc.inView = false;

            }



            yield return new WaitForSeconds(1f);

        }



    }

}


