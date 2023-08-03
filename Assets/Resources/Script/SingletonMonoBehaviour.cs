using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    //�O������A�N�Z�X����邽�߂̃v���p�e�B
    public static T Instance
    {
        get
        {
            //�C���X�^���X���Ȃ����
            if (instance == null)
            {
                //�N���X�̌^���擾
                Type type = typeof(T);

                //�������g���C���X�^���X��
                instance = (T)FindObjectOfType(type);

                //�A�^�b�`����Ă��Ȃ���
                if (instance == null)
                {
                    Debug.LogError(type + " ���A�^�b�`���Ă���GameObject�����݂��܂���");
                }
            }

            return instance;
        }
    }

    virtual protected void Awake()
    {
        if (this != Instance)
        {
            Destroy(this);
            return;
        }
    }

}