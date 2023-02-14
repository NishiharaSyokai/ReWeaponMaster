using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    //      �J�����̋���
    private const float Cameradistance = -10f;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = player.transform.position;

        //      z����-10�ɂ���
        cameraPos.z = Cameradistance;

        //      �J�����̈ʒu���v���C���[�Ɠ����ɂ���iZ���́[�P�O�Ƃ���j
        this.gameObject.transform.position = cameraPos;
    }
}
