using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTarget : MonoBehaviour
{

    [SerializeField][Range(-1.0f, 1.0f)]
    float X_Axis_RotationalSpeed = 0.0f;

    [SerializeField][Range(-1.0f, 1.0f)]
    float Y_Axis_RotationalSpeed = 0.0f;

    [SerializeField][Range(-1.0f, 1.0f)]
    float Z_Axis_RotationalSpeed = 0.0f;

    Vector3 targetAngles = Vector3.zero;

    //再生フラグ（初期値はtrue）
    bool m_IsPlaying = true;

    Vector3 m_InitialAngles = Vector3.zero;

    public bool IsPlaying{
        set{m_IsPlaying = value;}
        get{return m_IsPlaying;}
    }

    // Start is called before the first frame update
    void Start()
    {
        targetAngles = transform.eulerAngles;
        m_InitialAngles = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.IsPlaying){

            targetAngles.x = targetAngles.x + X_Axis_RotationalSpeed;
            targetAngles.y = targetAngles.y + Y_Axis_RotationalSpeed;
            targetAngles.z = targetAngles.z + Z_Axis_RotationalSpeed;

            transform.eulerAngles = targetAngles;
        }
    }

    //リセット
    public void Reset(){
        transform.eulerAngles = m_InitialAngles;
    }
}
