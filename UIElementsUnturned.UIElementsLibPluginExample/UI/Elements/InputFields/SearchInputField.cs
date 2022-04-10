﻿using UIElementsLib.Core.Player;
using UIElementsLib.Core.UI.InputField;

namespace UIElementsLibPluginExample.UI.Elements.InputFields
{
    /// <summary>
    /// One more example, better check CloseUIButton.
    /// </summary>
    public sealed class SearchInputField : IInputField
    {
        public string ChildObjectName => "SearchInputField";



        void IInputField.OnEnterInput(UPlayer executor, string text)
        {
            // executor is unturnedplayer who called it
            // text - the text which player enter in input field

            Rocket.Core.Logging.Logger.Log("Executor Name: " + executor.Player.CharacterName);
            Rocket.Core.Logging.Logger.Log("Wrote in inputfield next text: " + text);
        }
    }
}
