using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LanguageText : MonoBehaviour
{
    public int language;
    public string[] text;
    private TextMeshProUGUI textLine;

    void Update()
    {
        language = PlayerPrefs.GetInt("language", language); //��������� ����
        textLine = GetComponent<TextMeshProUGUI>(); //���������� � ����������
        textLine.text = "" + text[language]; //��������� ����� ����� ����� ������������, � ����������� ������������ �����
        textLine.font.tabSize = 2;
    }
}