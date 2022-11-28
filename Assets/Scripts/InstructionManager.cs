using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject instruction1;
    public GameObject instruction2;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 5f)
        {
            instruction1.SetActive(false);
            instruction2.SetActive(true);
        }
    }
}
