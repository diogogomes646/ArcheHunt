using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class barManager : MonoBehaviour {

    [SerializeField]
    private float fillAmount;

    private float value;
    public GameObject fillBar;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        handleBar();
	}

    void handleBar()
    {
        fillBar.GetComponent<Image>().fillAmount = fillAmount;
    }

    public float health(float health, float minHealth, float maxHealth)
    {
        return (health - minHealth) / (maxHealth - minHealth);
    }

    public float Value
    {
        set
        {
            fillAmount = health(value, 0, 100);
        }
    }
}
