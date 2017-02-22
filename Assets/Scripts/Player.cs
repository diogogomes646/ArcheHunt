using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class Player : MonoBehaviour
{
    private bool mLeft;
    private bool mRight;
    [SerializeField]
    private float playerSpeed;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
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

    void Fireball()
    {
        
        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
   
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.right * 6;

        Destroy(bullet, 2.0f);
        
        
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

    public void Fireb()
    {
        Fireball();
    }
}
