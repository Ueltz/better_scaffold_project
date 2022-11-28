using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject instruction1;
    public float time_before;
    public GameObject instruction2;

    void Start() {
        time_before = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time - time_before > 10f)
        {
            instruction1.SetActive(false);
            instruction2.SetActive(true);
        }
    }
}
