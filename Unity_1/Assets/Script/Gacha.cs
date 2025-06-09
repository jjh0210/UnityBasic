using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gacha : MonoBehaviour
{
    string[] characterList = new string[10];

    void Start()
    {
        characterList[0] = "거북이";
        characterList[1] = "강아지";
        characterList[2] = "고양이";
        characterList[3] = "얼룩말";
        characterList[4] = "호랑이";
        characterList[5] = "사자";
        characterList[6] = "사슴";
        characterList[7] = "하마";
        characterList[8] = "캥거루";
        characterList[9] = "토끼";
    }

    // selectNumber에 따라 어떤 뽑기인지 선택
    public void Index(int selectNumber)
    {
        for (int i = 0; i < 10; i++)
        {
            int randomValue = Random.Range(1, 101); // 반복마다 새로운 랜덤값

            switch (selectNumber)
            {
                case 0:
                    if (randomValue <= 10)
                        Debug.Log(characterList[4] + " 을 뽑았다!");
                    else if (randomValue <= 30)
                        Debug.Log(characterList[6] + " 을 뽑았다!");
                    else
                        Debug.Log(characterList[9] + " 를 뽑았다!");
                    break;

                case 1:
                    if (randomValue <= 10)
                        Debug.Log(characterList[5] + " 을 뽑았다!");
                    else if (randomValue <= 30)
                        Debug.Log(characterList[3] + " 을 뽑았다!");
                    else
                        Debug.Log(characterList[7] + " 를 뽑았다!");
                    break;

                case 2:
                    if (randomValue <= 10)
                        Debug.Log(characterList[2] + " 을 뽑았다!");
                    else if (randomValue <= 30)
                        Debug.Log(characterList[8] + " 을 뽑았다!");
                    else
                        Debug.Log(characterList[7] + " 를 뽑았다!");
                    break;

                case 3:
                    if (randomValue <= 10)
                        Debug.Log(characterList[1] + " 을 뽑았다!");
                    else if (randomValue <= 30)
                        Debug.Log(characterList[9] + " 을 뽑았다!");
                    else
                        Debug.Log(characterList[0] + " 를 뽑았다!");
                    break;
            }
        }
    }
}