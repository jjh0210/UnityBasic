using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class ME : MonoBehaviour
{
    // Start is called before the first frame update  
 
        public string Sung = "장";

        public string Name = "재호";

        public string sex = "남성";

        public int age = 33 + 1;

        public string MBTI;

        public string hobby = "게임";

        public int birthdayMonth = 2;

        public int birthdayday = 10;

        private string job = "학생";
        private string backsu;

        private int Height;
        private bool Real;

    private void Awake()
    {
        Height = UnityEngine.Random.Range(150, 200);
        Real = Height < 170;
        Selfintroduction();
        MBTI = "INFP";
        backsu = "백수";
    }

    // 이름 소개
    private void OnEnable()
    {
        Debug.Log("반갑습니다 " + "저의 이름은 " + Sung + Name + " 입니다");
    }

    //나이 소개
    void Start()
    {
        Debug.Log("제 나이는 " + age + "살 입니다.");
        Debug.Log("키는 " + Height + "cm 입니다 " + Real + "이지롱");
        Debug.Log("성격은 " + MBTI + "라서 내향인 입니다.");
        Debug.Log("취미는 " + hobby + " 플레이를 시간이 날 때마다 합니다");
        Debug.Log("제 생일은 " + birthdayMonth + "월 " + birthdayday + "일 입니다");
        Debug.Log("직업은 현재 " + job + " 입니다." + backsu + " 라고도 하지요.");
    }
    public void Selfintroduction()
        {
        }
    // Update is called once per frame
    void Update()
    {
    }
    private void OnDisable()
    {
        Debug.Log("이상 자기소개 끝!");

    }
}
