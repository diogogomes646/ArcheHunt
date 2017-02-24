using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool mLeft;
    private bool mRight;
    [SerializeField]
    private float playerSpeed;
    public float projSpeed;
    public GameObject fireballPrefab;
    public Transform projSpawn;



    [SerializeField]
    public Stat health;

    [SerializeField]
    private Stat energy;

    [SerializeField]
    private Stat shield;


    void Awake()
    {

        energy.Initialize();
        health.Initialize();
        shield.Initialize();

    }


    void Start ()
    {
		

	}
	

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

        if (Input.GetKeyDown(KeyCode.W))
        {
            health.CurrentValue += 10;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            health.CurrentValue -= 10;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            energy.CurrentValue -= 10;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            energy.CurrentValue += 10;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            shield.CurrentValue -= 10;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            shield.CurrentValue += 10;
        }

    }

    void Fireball()
    {

        GameObject proj = Instantiate(fireballPrefab, projSpawn.position, projSpawn.rotation);
        Destroy(proj, 2.0f);
        
        
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
