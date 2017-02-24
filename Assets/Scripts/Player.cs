using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool mLeft;
    private bool mRight;
    public float projSpeed;
    [SerializeField]
    private int killCount;
    [SerializeField]
    private float playerSpeed;
    [SerializeField]
    private Stat health;
    [SerializeField]
    private Stat energy;
    [SerializeField]
    private Stat shield;

    public GameObject fireballPrefab;
    public Transform projSpawn;

    void Awake()
    {

        energy.Initialize();
        health.Initialize();
        shield.Initialize();

    }
    void Start()
    {


    }


    void Update()
    {
        UITest();
        playerMovement();

    }

    private void playerMovement()
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
            projSpawn.transform.position.Set(3.0f, 0, 0);
        }

    }

    private void UITest()
    {
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

    public void Fireball()
    {

        GameObject proj = Instantiate(fireballPrefab, projSpawn.position, projSpawn.rotation);
        Destroy(proj, 2.0f);
    }

    public Stat getHealth()
    {
        return health;
    }

    public Stat getShield()
    {
        return shield;
    }

    public Stat getEnergy()
    {
        return energy;
    }

    public void takeHealth(int damage)
    {
        health.CurrentValue -= damage;
    }

    public void takeShield(int damage)
    {
        shield.CurrentValue -= damage;
    }

    public void leftDown()
    {
        mLeft = true;
    }

    public void leftUp()
    {
        mLeft = false;
        projSpawn.transform.position.Set(-3.0f, 0, 0);
    }

    public void rightDown()
    {
        mRight = true;
        projSpawn.transform.position.Set(3.0f, 0, 0);
    }

    public void rightUp()
    {
        mRight = false;
    }

    public void addKill()
    {
        killCount++;
    }
}