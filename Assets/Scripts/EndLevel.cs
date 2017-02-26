using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public Vector3 StartPos;
    public GameObject Spawn;
    public GameObject StartPlane;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Player"))
        {
            Destroy(other.gameObject);
            StartPos = StartPlane.transform.position;
            Instantiate(Spawn, new Vector3(StartPos.x, StartPos.y + 2, StartPos.z), Quaternion.identity);
        }
    }
}
