using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public GameObject player;
    private float fSpeed;
    private Vector2 dir;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        fSpeed = player.GetComponent<Player>().projSpeed;

        if (player.GetComponent<SpriteRenderer>().flipX == true)
        {
            dir = Vector2.right;
            GetComponent<SpriteRenderer>().flipX = true;        }
        else { dir = Vector2.left; }
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(fSpeed * dir * Time.deltaTime);

	}
}
