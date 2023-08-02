using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDrawing : MonoBehaviour
{
    [SerializeField] GameObject TargetMark;

    public Vector3 Target_position;

    // Start is called before the first frame update
    void Start()
    {
        DrawingTarget();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DrawingTarget()
    {
        float rndX = Random.Range(-1.5f, 1.5f);
        float rndY = Random.Range(-1.5f, 1.5f);

        // �{�[���}�[�N�����ʒu
        Vector3 pos = new Vector3(rndX, rndY, 0.0f);
        // �{�[���}�[�N���w��ʒu�ɐ���
        Instantiate(TargetMark, pos, Quaternion.identity);

        Target_position = pos;
    }
}
