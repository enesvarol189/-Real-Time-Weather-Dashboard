﻿using System.Collections.Immutable;

namespace ClimaDash.Models
{
    public static class SupportedLanguages
    {
        public static ImmutableDictionary<string, string> Languages { get; } = new Dictionary<string, string>
        {
            { "af", "Afrikaans" },
            { "al", "Albanian" },
            { "ar", "Arabic" },
            { "az", "Azerbaijani" },
            { "bg", "Bulgarian" },
            { "ca", "Catalan" },
            { "cz", "Czech" },
            { "da", "Danish" },
            { "de", "German" },
            { "el", "Greek" },
            { "en", "English" },
            { "eu", "Basque" },
            { "fa", "Persian" },
            { "fi", "Finnish" },
            { "fr", "French" },
            { "gl", "Galician" },
            { "he", "Hebrew" },
            { "hi", "Hindi" },
            { "hr", "Croatian" },
            { "hu", "Hungarian" },
            { "id", "Indonesian" },
            { "it", "Italian" },
            { "ja", "Japanese" },
            { "kr", "Korean" },
            { "la", "Latvian" },
            { "lt", "Lithuanian" },
            { "mk", "Macedonian" },
            { "no", "Norwegian" },
            { "nl", "Dutch" },
            { "pl", "Polish" },
            { "pt", "Portuguese" },
            { "pt_br", "Português Brasil" },
            { "ro", "Romanian" },
            { "ru", "Russian" },
            { "sv", "Swedish" },
            { "sk", "Slovak" },
            { "sl", "Slovenian" },
            { "es", "Spanish" },
            { "sr", "Serbian" },
            { "th", "Thai" },
            { "tr", "Turkish" },
            { "ua", "Ukrainian" },
            { "vi", "Vietnamese" },
            { "zh_cn", "Chinese Simplified" },
            { "zh_tw", "Chinese Traditional" },
            { "zu", "Zulu" }
        }.ToImmutableDictionary();
    }
}