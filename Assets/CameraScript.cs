using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate() {
        Rigidbody rb  = this.GetComponent<Rigidbody>();
 
float moveSpeed = 3f;
    // カメラの方向から、X-Z平面の単位ベクトルを取得
    Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
 
    // 方向キーの入力値とカメラの向きから、移動方向を決定
    Vector3 moveForward = cameraForward * Input.GetAxisRaw("Vertical") + Camera.main.transform.right * Input.GetAxisRaw("Horizontal");
 
    // 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
    rb.velocity = moveForward * moveSpeed + new Vector3(0, rb.velocity.y, 0);
 
    // キャラクターの向きを進行方向に
    if (moveForward != Vector3.zero) {
        transform.rotation = Quaternion.LookRotation(moveForward);
    }
}
}
