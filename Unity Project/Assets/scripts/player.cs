﻿using UnityEngine;

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

    public Animator ani;
    #endregion


    #region 方法區域

    /// <summary>
    /// 跑步方法
    /// </summary>
    /// <param name="direction">方向</param>
    private void Run()
    {
       // print("水平 " +Input.GetAxis("Horizontal")); //A、D、左、右
       // print("垂直 " +Input.GetAxis("Vertical")); //W、S、上、下

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        ani.SetBool("跑步開關", h != 0 || v != 0);
    }

    /// <summary>
    /// 跳躍方法
    /// </summary>
    private void Jump()
    {
        ani.SetBool("跳躍開關", Input.GetKeyDown(KeyCode.Space));
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
           // print("跳躍動畫");
           // ani.SetBool("跳躍開關", true);
       // }
       // else if (Input.GetKeyUp(KeyCode.Space))
        //{
            //ani.SetBool("跳躍開關", false);
       // }
    }

    /// <summary>
    /// 攻擊方法
    /// </summary>
    private void Attack()
    {
       if (Input.GetKeyDown(KeyCode.Mouse0))
       {
            print("攻擊動畫");
            ani.SetTrigger("攻擊觸發");
        }
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


    private void Update()
    {
        Run();
        Jump();
        Attack();
    }
}