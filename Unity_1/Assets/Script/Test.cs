using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void OnEnable()
    {
        Debug.Log(Random.Range(1, 100));
        // 1 �̻� 100 �̸��� ������ ���� ����ڴ�.
        Debug.Log(Random.Range(1, 200));
        // 1 �̻� 200 �̸��� ������ ���� ����ڴ�.
    }
}