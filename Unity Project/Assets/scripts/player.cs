using UnityEngine;

public class player : MonoBehaviour
{
    #region 欄位區域
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
    #endregion


    #region 方法區域

    /// <summary>
    /// 跑步方法
    /// </summary>
    /// <param name="direction">方向</param>
    private void Run(string direction)
    {
        print("跑步" + direction);
    }

    /// <summary>
    /// 跳躍方法
    /// </summary>
    private void Jump()
    {
        print("跳躍");
    }

    /// <summary>
    /// 攻擊方法
    /// </summary>
    private void Attack()
    {

    }

    /// <summary>
    /// 受傷方法
    /// </summary>
    /// <param name="dammage">傷害值</param>
    private void Hit(float dammage)
    {

    }

    /// <summary>
    /// 死亡方法
    /// </summary>
    private void Dead()
    {

    }

    /// <summary>
    /// 吃道具方法
    /// </summary>
    private void EatProp()
    {

    }

    /// <summary>
    /// 過關方法
    /// </summary>
    private void Pass()
    {

    }

    #endregion


}