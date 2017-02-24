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

    // Use this for initialization
    void Start()
    {
        maxHealth = 50;
        eHealth = maxHealth;
        eStrenght = 10;

        eSpeed = 2.0f;
        eRange.Set(10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        checkHealth();
        chasePlayer();

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            GameObject.Find("Player").GetComponent<Player>().takeHealth(eStrenght);
          
        }
    }

    public void takeDamage(int damage)
    {
        eHealth -= damage;
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
        if (Vector2.Distance(player.transform.position, transform.position) <= eRange.x)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, eSpeed * Time.deltaTime);

        }
    }
}