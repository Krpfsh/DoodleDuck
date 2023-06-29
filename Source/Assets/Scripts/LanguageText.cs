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
        language = PlayerPrefs.GetInt("language", language); //загружаем язык
        textLine = GetComponent<TextMeshProUGUI>(); //обращаемся к компоненту
        textLine.text = "" + text[language]; //указываем какой текст будет отображаться, в зависимости отвыбранного языка
        textLine.font.tabSize = 2;
    }
}