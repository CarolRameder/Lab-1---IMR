using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeliSoldierAni : MonoBehaviour
{
    public float Distance;
    private float dist = 20;

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Distance = Vector3.Distance(Camera.main.transform.position, transform.position);
        if (Distance <= dist)
        {
            GetComponent<Animator>().SetBool("targetIsClose", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("targetIsClose", false);
        }
    }
}
