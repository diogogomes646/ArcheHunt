using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int eHealth;
    private int eStrenght;
    [SerializeField]
    private float eSpeed;
    private Vector2 eRange;

    public int maxHealth;

    public GameObject player;
    public GameObject gameManager;
    public GameObject healthBar;

    public BarScript HealthBar;

    bool canMove = true;

    // Use this for initialization
    void Start()
    {
        maxHealth = 50;
        eHealth = maxHealth;
        eStrenght = 10;

        eSpeed = 2.0f;
        eRange.Set(40, 10);
        HealthBar = healthBar.GetComponent<BarScript>();
        HealthBar.Init(eHealth);
        //HealthBar.MaxValue = eHealth;// must be set before value
        //HealthBar.Value = eHealth;
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        //checkHealth();
        chasePlayer();

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            GameObject.Find("Player").GetComponent<Player>().takeHealth(eStrenght);
          
        }
    }
    
    private void OnCollisionStay(Collision collision)
    {
        canMove = false;
    }
    private void OnCollisionExit(Collision collision)
    {
        canMove = true;
    }

    public void takeDamage(int damage)
    {
        eHealth -= damage;
        checkHealth();
        //update bar
        HealthBar.Value = eHealth;
    }

    void checkHealth()
    {
        if (eHealth <= 0)
        {
            player.GetComponent<Player>().addKill();
            Destroy(this.gameObject);
        }
    }

    private void chasePlayer()
    {
        if (canMove)
        {
            if (Vector2.Distance(player.transform.position, transform.position) <= eRange.x)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.transform.position, eSpeed * Time.deltaTime);
            }
        }
    }
}