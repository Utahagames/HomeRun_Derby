using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    //外部からアクセスされるためのプロパティ
    public static T Instance
    {
        get
        {
            //インスタンスがなければ
            if (instance == null)
            {
                //クラスの型を取得
                Type type = typeof(T);

                //自分自身をインスタンス化
                instance = (T)FindObjectOfType(type);

                //アタッチされていない時
                if (instance == null)
                {
                    Debug.LogError(type + " をアタッチしているGameObjectが存在しません");
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