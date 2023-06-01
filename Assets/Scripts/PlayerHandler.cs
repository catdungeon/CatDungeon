using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;

    public Animator animator;

    private int walk = 4;
    void Start()
    {
        
    }


    void Update()
    {
        // 按下A鍵
        if (Input.GetKey(KeyCode.A))
        {
            // 給角色速度
            rigidbody2D.velocity = new Vector2(-4, rigidbody2D.velocity.y);
            // 按A時，角色方向轉負x軸
            transform.localScale = new Vector3(-1, 1, 1);
            // int 2
            animator.SetBool("walk",true);
        }
        
        // 按下D鍵
        else if (Input.GetKey(KeyCode.D))
        {
            // 給角色速度
            rigidbody2D.velocity = new Vector2(4, rigidbody2D.velocity.y);
            // 按D時，角色方向轉正x軸
            transform.localScale = new Vector3(1, 1, 1);
            // int 2
            animator.SetBool("walk",true);
        }

        // 按下Shift鍵
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("run",true);
        }

    }
    
    
}
