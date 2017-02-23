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

    private int maxHealth;

    public GameObject player;
    public GameObject gameManager;

    // Use this for initialization
    void Start()
    {
        maxHealth = 10;
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
    public void takeDamage(int damage)
    {
        eHealth -= damage;
    }
}