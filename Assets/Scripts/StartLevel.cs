using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    public Vector3 StartPos;

    public GameObject Spawn;
    public GameObject StartPlane;
    void Start()
    {
        StartPos = StartPlane.transform.position;

       // Instantiate(Spawn, new Vector3(StartPos.x, StartPos.y + 2, StartPos.z), Quaternion.identity);
    }

}
