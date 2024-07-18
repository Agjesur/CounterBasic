using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counterText;
    public InputField inputField;

    private void Start()
    {
        // Kay�tl� saya� de�erini y�kle
        int count = PlayerPrefs.GetInt("SavedCount", 0);
        UpdateCounterText(count);
    }

    public void IncrementCounter()
    {
        // InputField'den al�nan metni al
        string userInput = inputField.text;

        // Metni say�ya �evir ve saya� olarak kullan
        if (int.TryParse(userInput, out int count))
        {
            count++; // Saya� de�erini art�r
            UpdateCounterText(count);

            // Saya� de�erini kaydet
            PlayerPrefs.SetInt("SavedCount", count);
            PlayerPrefs.Save();
        }
        else
        {
            Debug.LogWarning("Ge�ersiz giri�! Say� giriniz.");
        }
    }

    private void UpdateCounterText(int count)
    {
        counterText.text = "Count: " + count.ToString();
    }
}