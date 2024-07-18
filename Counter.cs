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
        // Kayýtlý sayaç deðerini yükle
        int count = PlayerPrefs.GetInt("SavedCount", 0);
        UpdateCounterText(count);
    }

    public void IncrementCounter()
    {
        // InputField'den alýnan metni al
        string userInput = inputField.text;

        // Metni sayýya çevir ve sayaç olarak kullan
        if (int.TryParse(userInput, out int count))
        {
            count++; // Sayaç deðerini artýr
            UpdateCounterText(count);

            // Sayaç deðerini kaydet
            PlayerPrefs.SetInt("SavedCount", count);
            PlayerPrefs.Save();
        }
        else
        {
            Debug.LogWarning("Geçersiz giriþ! Sayý giriniz.");
        }
    }

    private void UpdateCounterText(int count)
    {
        counterText.text = "Count: " + count.ToString();
    }
}