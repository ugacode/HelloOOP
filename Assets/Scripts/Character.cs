using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : Clickable
{
    public string DisplayName;
    public string Role;
    public string[] Skills;

    private void UpdateClickName()
    {
        string adjective = "brave";
        if (Role.ToLower() == "mage")
        {
            adjective = "wise";
        }
        ClickName = $"I am a {adjective} {Role}! I am known as sir {DisplayName} the {adjective}!\n";
        if (Skills != null && Skills.Length > 0)
        {
            if (Skills.Length > 1)
            {
                ClickName += $"I have many different skills: {string.Join(", ",Skills)}!\n";
            }
            else
            {
                ClickName += $"I don't need many skills. I am focused on my {Skills[0]}!\n";
            }
        }
        ClickName += "You may tremble in fear now." ;
    }

    void Start()
    {
        UpdateClickName();
    }

    void Update()
    {
        base.DetectClicks();
    }
}
