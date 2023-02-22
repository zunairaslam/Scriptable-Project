using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;
    public TMP_Text nameText;
    public TMP_Text descriptionText;

    public Image artWork;

    public TMP_Text manaText;
    public TMP_Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;
        artWork.sprite = card.artwork;
        manaText.text = card.manaCost.ToString();
        healthText.text = card.health.ToString();

    }

    // Update is called once per frame

}
