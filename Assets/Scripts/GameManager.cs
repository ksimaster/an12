using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ImGif;
using TMPro;


public class GameManager : MonoBehaviour
{
    public GameObject [] places;
    //private FixedGif fixGif;
    public GifData [] data;
    public TMP_Text title;

    private string[] joke = {
                            "��������� �������� �� ������",
                             "� ������ �������� ������!",
                             "� � ���� ���� ������!",
                             "��� �� �������?",
                             "���! ��������!",
                             "���� �� ����!",
                             "������! ���������� �������?",
                             "� � ��� ������ ����!",
                             "��� ����� �����������",
                             "��� �� ������?",
                             "� �� ��������!",
                             "�� ������?",
                             "��� ��� ��������?",
                             "�� ����� � ���, � ���� ���!",
                             "����� � ���������!",
                             "�� ������! �����!",
                             "������ �� �����!",
                             "�� �������� ������ ������ �������������!",
                             "��� ������ ����� �����",
                             "� �� ��� �������?",
                             "�� �� ����� ��� ���������!",
                             "��� ������ ������!",
                             "�����! �� ������� ����� ��� ������!",
                             "� ������! �� ���� �� ������...",
                             "����� ���������� ������ ������ ��� �������",
                             "� �� ����� ��������?",
                             "� ��� ������?",
                             "�������? ��� �������!",
                             "�� �����! ���  ����� ��������! � ����!",
                             "������ ������ �����?",
                             "��������� ������!",
                             "������ � ���� �� ���� ������?",
                             "��! �� ����� ��������!",
                             "������ ������?",
                             "������? ���!",
                             "� ����, � ��� �� �������!",
                             "������� ���� ��� �����������!",
                             "����� ������� ��� ���������?",
                             "������ ��� ����� ��������!",
                             "��� �������!",
                             "����� �������� � ����� � �����������!",
                             "� ��� ���� ����� � ���������!",
                             "� � ���� ������ ������! ��������?",
                             "����� ������� ���! ����������� ��� �������� ������!",
                             "�� ����� ������� ��� ������!",
                             "�� �������, ����� ��������!",
                             "������������� � ���!",
                             "��� ������� ������� �� ����!",
                             "�! � ��� � ��!",
                             "����� ������!",
                             "����!",
                             "��� ��? ��� ���� �� �����!",
                             "�����������, � ���������",
                             "���? � �� ����?",
                             "����� �����������!",
                             "� ���� ����!",
                             "� ������ ������ �����������!",
                             "����� �� 300?",
                             "� ����� ��� ������� ���� ������?",
                             "���� ����! ��������� ���������, ������ ����?",
                             "� � ����������...",
                             "��� ����� ������! � ������!",
                             "����� �� ��������� ���������!",
                             "�� ����� �������!",
                             "������ ������� � ��������, ����� ����, ��� ������...",
                             "� � ����! ����!",
                             "� � �� ��������� �����������!",
                             "� ���� ������� �� ������, �� ��������...",
                             "�������, � ������ �� ��������!",
                             "� ����� ���� ������� ���� �� ���� �����������!",
                             "� �����, ������ �� ���?",
                             "���������! � ���������!",
                             "��� �� ����?",
                             "����� ���-�� ������������ ���������!",
                             "� �����, �� ������ ���� �� ����������?",
                             "����� �� ������, � ����!",
                             "����� ������� ��� � ������ ���!",
                             "��! ��� ��� � ���!",
                             "� � ���� �������� ������!",
                             "������� �������������!",
                             "� ������ �����!",
                             "�� �������? ���� � ���� ������...",
                             "����� ���� ����������, ��� ���������� ��������������",
                             "� �����, ������ �������� �� ���? ����� ���� � �������?",
                             "� ���� ���� �����! �� ������ ������!",
                             "� ���� ����� �������� ������!",
                             "��� ���� ��������? �������!",
                             "� �������� �������, � ����... ��� ������?",
                             "����� �� ��������",
                             "� ���� ����� �������!",
                             "������� �� �������?",
                             "������ ������� �������, ���������� ���� �����! �����!",
                             "����� ������� ���������",
                             "������! ���� ����! ������!",
                             "�������-������",
                             "� �����, ������ �� ���! � ���� ���-��� ����!",
                             "����� ������� ������� �� �������� ���������",
                             "��! ��������!",
                             "�� ���� ��������?",
                             "� ������? ��� ��?",
                             "��������! ��������! ��������!"




    };
    private int count = 0;
    private SpriteArray _sprites;

    void Start()
    {
        
        Debug.Log("���������� ����� " + joke.Length);
        for (int i = 0; i < places.Length; i++)
        {
            places[i].GetComponent<FixedGif>().data = data[i];
            _sprites = GifUtility.Load(data[i]);
            places[i].GetComponent<FixedGif>()._sprites = _sprites;
        }
        count = PlayerPrefs.GetInt("Count");
        foreach (GameObject place in places)
        {
            place.SetActive(false);
        }
        places[(places.Length - 1) - count].SetActive(true);
        title.text = joke[(joke.Length - 1) - count];
        
        /*
        fixGif = place.GetComponent<FixedGif>();
        fixGif.data = data[count];
        _sprites = GifUtility.Load(data[count]);
        fixGif._sprites = _sprites;
        */
    }

    public void NextGif()
    {
        places[(places.Length - 1) - count].SetActive(false);
        count += 1;
        if (count >= data.Length) count = 0;
        PlayerPrefs.SetInt("Count", count);
        places[(places.Length - 1) - count].SetActive(true);
        title.text = joke[(joke.Length - 1) - count];
        Debug.Log(count);
        // place.GetComponent<FixedGif>().
        /*
        Destroy(place.GetComponent<FixedGif>());
        place.AddComponent<FixedGif>();
        place.GetComponent<FixedGif>().enabled = true;
        place.GetComponent<FixedGif>().data = data[count];
        _sprites = GifUtility.Load(data[count]);
        place.GetComponent<FixedGif>()._sprites = _sprites;
        */
    }

    public void BackGif()
    {
        places[(places.Length - 1) - count].SetActive(false);
        count -= 1;
        if (count < 0) count = data.Length - 1;
        PlayerPrefs.SetInt("Count", count);
        places[(places.Length - 1) - count].SetActive(true);
        title.text = joke[(joke.Length - 1) - count];
        Debug.Log(count);
        // place.GetComponent<FixedGif>().
        /*
        Destroy(place.GetComponent<FixedGif>());
        place.AddComponent<FixedGif>();
        place.GetComponent<FixedGif>().enabled = true;
        place.GetComponent<FixedGif>().data = data[count];
        _sprites = GifUtility.Load(data[count]);
        place.GetComponent<FixedGif>()._sprites = _sprites;
        */
    }
}
