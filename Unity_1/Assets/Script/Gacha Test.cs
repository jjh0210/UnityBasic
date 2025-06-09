using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaTest : MonoBehaviour
{

    int randomvalue; // 랜덤 확률 정의
    string[] characterList = new string[10];


    // Start is called before the first frame update
    void Start() // 캐릭터 정의
    {
        randomvalue = Random.Range(1, 101);

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

    public void Tiger()
    {
        for (int i = 0; i < 10; i++)
        {
            int randomValue = Random.Range(1, 101); // 반복마다 새 랜덤값 생성

            if (randomValue <= 10)
            {
                Debug.Log(characterList[4] + " 을 뽑았다!"); // 호랑이
            }
            else if (randomValue <= 30)
            {
                Debug.Log(characterList[6] + " 을 뽑았다!"); // 사슴
            }
            else
            {
                Debug.Log(characterList[9] + " 를 뽑았다!"); // 토끼
            }
        }
    }
}
