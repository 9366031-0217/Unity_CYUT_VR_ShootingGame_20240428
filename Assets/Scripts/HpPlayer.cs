using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HpPlayer : HpSystem
{
    [SerializeField, Header("����Ϥ�")]
    private Image imgHp;
    [SerializeField, Header("��q��r")]
    private TMP_Text textHp;
    
    private string enemyAttackArea = "�ĤH����";
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
        textHp.text = $"��q{hp} / {hpMax}";
    }

    protected override void Damage(float damage)
    {
        if (hp <= 0) return;
        base.Damage(damage);
        UPdateUI();
    }
}
