using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    public int eHealth;
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

        eSpeed = 2.0f;
        eRange.Set(10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(player.transform.position, transform.position) <= eRange.x)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, eSpeed * Time.deltaTime);

        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            GameObject.Find("Player").GetComponent<Player>().health.CurrentValue -= 10;
          
        }

    
    }

    void UpdateHealth()
    {

    }
    public void takeDamage(int damage)
    {
        eHealth -= damage;
        UpdateHealth();
    }


}