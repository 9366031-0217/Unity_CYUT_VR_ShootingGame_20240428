using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HpPlayer : HpSystem
{
    [SerializeField, Header("血條圖片")]
    private Image imgHp;
    [SerializeField, Header("血量文字")]
    private TMP_Text textHp;
    
    private string enemyAttackArea = "敵人攻擊";
    private float hpMax;

    private void Awake()
    {
        hpMax = hp;
        UPdateUI();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains(enemyAttackArea))
        {
            Damage(50);
        }
    }

    private void UPdateUI()
    {
        imgHp.fillAmount = hp / hpMax;
        textHp.text = $"血量{hp} / {hpMax}";
    }

    protected override void Damage(float damage)
    {
        if (hp <= 0) return;
        base.Damage(damage);
        UPdateUI();
    }
}
