using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gacha : MonoBehaviour
{
    string[] characterList = new string[10];

    void Start()
    {
        characterList[0] = "�ź���";
        characterList[1] = "������";
        characterList[2] = "�����";
        characterList[3] = "��踻";
        characterList[4] = "ȣ����";
        characterList[5] = "����";
        characterList[6] = "�罿";
        characterList[7] = "�ϸ�";
        characterList[8] = "Ļ�ŷ�";
        characterList[9] = "�䳢";
    }

    // selectNumber�� ���� � �̱����� ����
    public void Index(int selectNumber)
    {
        for (int i = 0; i < 10; i++)
        {
            int randomValue = Random.Range(1, 101); // �ݺ����� ���ο� ������

            switch (selectNumber)
            {
                case 0:
                    if (randomValue <= 10)
                        Debug.Log(characterList[4] + " �� �̾Ҵ�!");
                    else if (randomValue <= 30)
                        Debug.Log(characterList[6] + " �� �̾Ҵ�!");
                    else
                        Debug.Log(characterList[9] + " �� �̾Ҵ�!");
                    break;

                case 1:
                    if (randomValue <= 10)
                        Debug.Log(characterList[5] + " �� �̾Ҵ�!");
                    else if (randomValue <= 30)
                        Debug.Log(characterList[3] + " �� �̾Ҵ�!");
                    else
                        Debug.Log(characterList[7] + " �� �̾Ҵ�!");
                    break;

                case 2:
                    if (randomValue <= 10)
                        Debug.Log(characterList[2] + " �� �̾Ҵ�!");
                    else if (randomValue <= 30)
                        Debug.Log(characterList[8] + " �� �̾Ҵ�!");
                    else
                        Debug.Log(characterList[7] + " �� �̾Ҵ�!");
                    break;

                case 3:
                    if (randomValue <= 10)
                        Debug.Log(characterList[1] + " �� �̾Ҵ�!");
                    else if (randomValue <= 30)
                        Debug.Log(characterList[9] + " �� �̾Ҵ�!");
                    else
                        Debug.Log(characterList[0] + " �� �̾Ҵ�!");
                    break;
            }
        }
    }
}