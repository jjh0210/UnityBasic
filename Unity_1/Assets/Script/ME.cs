using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class ME : MonoBehaviour
{
    // Start is called before the first frame update  
 
        public string Sung = "��";

        public string Name = "��ȣ";

        public string sex = "����";

        public int age = 33 + 1;

        public string MBTI;

        public string hobby = "����";

        public int birthdayMonth = 2;

        public int birthdayday = 10;

        private string job = "�л�";
        private string backsu;

        private int Height;
        private bool Real;

    private void Awake()
    {
        Height = UnityEngine.Random.Range(150, 200);
        Real = Height < 170;
        Selfintroduction();
        MBTI = "INFP";
        backsu = "���";
    }

    // �̸� �Ұ�
    private void OnEnable()
    {
        Debug.Log("�ݰ����ϴ� " + "���� �̸��� " + Sung + Name + " �Դϴ�");
    }

    //���� �Ұ�
    void Start()
    {
        Debug.Log("�� ���̴� " + age + "�� �Դϴ�.");
        Debug.Log("Ű�� " + Height + "cm �Դϴ� " + Real + "������");
        Debug.Log("������ " + MBTI + "�� ������ �Դϴ�.");
        Debug.Log("��̴� " + hobby + " �÷��̸� �ð��� �� ������ �մϴ�");
        Debug.Log("�� ������ " + birthdayMonth + "�� " + birthdayday + "�� �Դϴ�");
        Debug.Log("������ ���� " + job + " �Դϴ�." + backsu + " ��� ������.");
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
        Debug.Log("�̻� �ڱ�Ұ� ��!");

    }
}
