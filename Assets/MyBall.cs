using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //rigid.velocity = Vector3.right; //시작하자마자 오른쪽으로 이동
        
    }

    
    void FixedUpdate() //RigidBody 관련 코드는 FixedUpdate()에 작성할 것.
    {
        //rigid.velocity = new Vector3.forward(); : 속력 바꾸기

        //2. 힘을 가하기
        if(Input.GetButtonDown("Jump")){
            rigid.AddForce(Vector3.up * 25, ForceMode.Impulse); 
            //AddForce(Vec) : Vec의 방향과 크기로 힘을 줌
            //ForceMode : 힘을 주는 방식 (가속, 무게 반영)
            Debug.Log(rigid.velocity);
        }

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);

        //3. 회전력
        rigid.AddTorque(Vector3.back);
    }
}
