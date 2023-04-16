using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health = 10;
    public Rigidbody2D rigidbody2D;
    public Slider slider;
    public PlayerOneCombat playerOneCombat;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        slider.value = health;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy")&& playerOneCombat.Attack == false)
        {
            Debug.Log("Test");
            health -= 1;
            if (health == 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        if (collision.CompareTag("FallZone"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
