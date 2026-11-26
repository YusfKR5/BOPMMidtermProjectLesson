using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public bool isDead;
    public Animator anim;

    public Image HPBar;
    public TMP_Text HPText;
    public GameObject VictoryPanel;
    public GameObject ButtonPanel;
    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        HPBar.fillAmount = health/maxHealth;
        HPText.text = health.ToString();
    }
    public void Hurt(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            health = 0;
            isDead = true;
            anim.Play("Death");
            Destroy(gameObject, 2.5f);
        }
        else
        {
            anim.Play("Hurt");
        }
    }
    public void ReturnToIdle()
    {
        anim.Play("Idle");
    }
    public void SetVictoryScreen()
    {
        VictoryPanel.SetActive(true);
        ButtonPanel.SetActive(false);
    }
}
