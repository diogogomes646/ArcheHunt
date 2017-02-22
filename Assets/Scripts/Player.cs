using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool mLeft;
    private bool mRight;
    [SerializeField]
    private float playerSpeed;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (mLeft == true)
        {
            transform.Translate(playerSpeed * Vector2.left * Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = false;
        }

        if (mRight == true)
        {
            transform.Translate(playerSpeed * Vector2.right * Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = true;

        }

    }

    public void leftDown()
    {
        mLeft = true;
    }

    public void leftUp()
    {
        mLeft = false;
    }

    public void rightDown()
    {
        mRight = true;
    }

    public void rightUp()
    {
        mRight = false;
    }
}
