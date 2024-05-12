using UnityEngine;

public class HpSystem : MonoBehaviour
{
    [SerializeField,Header("¦å¶q"),Range(0,500)]
    protected float hp;

    protected virtual void Damage(float damage)
    {
        hp -= damage;
        if (hp <= 0) Dead();

        print($"<color=#f69>{gameObject.name} ¦å¶q:{hp}</color>");

    }
    protected virtual void Dead()
    {
        print($"<color=#f33>{gameObject.name} ¦º¤`:</color>");
    }
}
