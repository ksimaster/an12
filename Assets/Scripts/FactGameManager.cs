using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ImGif;
using TMPro;


public class FactGameManager : MonoBehaviour
{
    //public GameObject [] places;
    //private FixedGif fixGif;
    //public GifData [] data;
    public TMP_Text title;

    private string[] facts = {
                             "��� � �������, ����� ����� ������ ��� ���, ��� �� ����� ������ ��� ������ �� ����� ��� ������",
                             "� ������� ����� ����� ������ ����� ������� ���, ������� �� ����������",
                             "���������������� �������� ������������ ����� ���� ����� ������� � �� ������� ������ ����, ��� ������� ��������������� � ����������� �����-�������",
                             "� 1970-� ����� ������������ ����� ������� ��������, ������ ������������ ���� �����������",
                             "�������� ������ ���������� �� �������� ������ �����, � ������ �������, ���, ��� ������������ ����� ������������� ��������� ���������� �����",
                             "� ������� �� ������������ ������ �����, ���������������, � ��������, ��� ��������� ������, ������� ����� ������������ ����� ���������� �� ������������ � �������� ���������",
                             "���������� �������� ������� � ������ ����� ���������, � ����� ��������� ������� ���� ������ �������� ������",
                             "����� ��������� ��������, ������� ������ ����� � ���� ��������",
                             "���� �������� ��������� ���� � ����� ���������, ��� ���� ������� �����",
                             "������� ����� ����� �������� � �������� �� ����������, ��������� �������� ����� ������� ���������",
                             "���� �� �������� ������������ ������� ����� � ������������� ������� ����� ����������",
                             "��� � � ����� ������ ���� �������������, ������������ ������� ����� ���������� ������ ��������� ����������",
                             "������ � �����, ��������������� � ������������ ����������� � �������, ���������� �����, ����������� ������������ ������� ��� ���� ������������ ������������ ����� ������� ������ � ����� ������� �����",
                             "������� ����� �����-�������� �������� ���� ���������� ������������� � ������� ���������� � ������ �� ������ ��� �����������",
                             "�������� ����� � ����� ������������ ��� ���������� ������������ ������ � ������������ ����������, ������������ ��� ������� ���� �����",
                             "����� ������ �������� �� ��������� ������������ �������, � ��� ������������ ������������� �� ���� ����� ������� ��������",
                             "������� ����� ������ �������� �� �������������� ���������� �����������, � ��� ����������� ����� ������ ������ ������ ����������� � �������� ����������� �����������, ���������� ����������� �������� �������",
                             "������� ������ �������� ������������� ������ ���������� �� 8 �� 12 ������ � �������, �� ����� ����������� ������������ ������ ����� ��������� � �������� 24 ����� � �������",
                             "��������� �����, ��� �������, ��� �������, ������������ ����� ��������, ������������ ������� ������ ����� � ���������� ��� �����",
                             "��������� �����, ��� ������, ������������ ����� ����������� �� �� �����, ��� � ��������� ��������, ������ ����� ����������� ����� �������� ��������, ����� ��������� ������",
                             "���� ������ �������� � ��������� ������� �� ���������� �������, �������� ��� ��������������� ����������, �� ������ ������ ������� ������� �� ����� ���������, ��� �������� ��������� ��� �������� � ���������� ��� ������������� �������",
                             "�������� � ����� �������� �����, ������������������ ����� ���� ������, ������ ������, ������ �������� ������ � ��������� �������",
                             "� ���� ����� ���� � �������� ����������������� ����� ��� ��������� ��������� ����������� ���������� �� �������������� ��������� �������",
                             "� ���� ��������� � �������� �������� ������������. ����������� ����� ������������ ����� �� ��������� ������ ����� � ����� ����������� ����� ����� ��������������",
                             "�������� ��������� ������� ����� �������� ����������, �� ������ ������, ���������� ������� � ������� � �����, ������������ ��������� �����, ������������ ���������� � ������������������� ����� � �����",
                             "� ����������� ������� � ��� �������� ������������������ ��������� �������� ��������������� ������ � ������������ ���������� ���������",
                             "������, � ����� ��������� ���������� ������, �������� �������� �� ������������ ������� ����������� ��� �������� �����",
                             "���� � ���� ����� ��� �����, �������� ������������ �������� �������� ����� ����������� ����",
                             "� ������� �� ����� ����������� ������, ���� �� ���������� ����������� ��������� ��������, ������������, � ����������� �� �������� ������� ���������, ��������� �� ������� ������������� ����������� ����� � ������ �� ����� ���������",
                             "�������� ���������� ������ � ���� �������� ������������� ��������� ������� �� �������",
                             "��� ��, ��� � � ������ � ������� �����, ����������� ����� � ����� ��� �������� ������� �� ������� �����",
                             "����� �������� ���� ��� ��� ������������ �����������, ������������� � ������, ��������� � �����������"
    };
    private int countFact = 0;
    private SpriteArray _sprites;

    void Start()
    {
        Debug.Log("���������� ������ " + facts.Length);
        countFact = PlayerPrefs.GetInt("CountFact");
        title.text = facts[countFact];
    }

    public void NextFact()
    {
        countFact += 1;
        if (countFact >= facts.Length) countFact = 0;
        PlayerPrefs.SetInt("CountFact", countFact);
        title.text = facts[countFact];
        Debug.Log(countFact);
    }

    public void BackFact()
    {
        countFact -= 1;
        if (countFact < 0) countFact = facts.Length - 1;
        PlayerPrefs.SetInt("CountFact", countFact);
        title.text = facts[countFact];
        Debug.Log(countFact);
    }
}
