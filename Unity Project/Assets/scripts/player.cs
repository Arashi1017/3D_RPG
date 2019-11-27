using UnityEngine;

public class player : MonoBehaviour
{
    [Header("動畫參數名稱")]
    public string parRun = "跑步開關";
    public string parJump = "跳躍開關";
    public string parAttack = "攻擊觸發";
    public string parHit = "受傷觸發";
    public string parDead = "死亡開關";

    [Header("道具數")]
    public int countNeed;
    public int countCurrent;
    
    [Header("生命")]
    public bool isDead;
    [Range(0,100)]
    public float HP;

}
