using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yandex.Translator;

namespace ShareX.UploadersLib.OtherServices
{
    public class YandexTranslator
    { 
        private IYandexTranslator translator;
        IEnumerable<ITranslationPair> translationPairs;

        public YandexTranslator()
        {
            translator = Yandex.Translator.Yandex.Translator(api => api
                .ApiKey(APIKeys.YandexAPIKey)
                .Format(ApiDataFormat.Json));
            translationPairs = translator.TranslationPairs();
        }

        public string Translate(string text, Languages2 fromLanguage, Languages2 toLanguage, out bool success)
        {
            if (translationPairs.Any(item => item.FromLanguage.Equals(fromLanguage.ToString()) && item.ToLanguage.Equals(toLanguage.ToString())))
            {
                var translationPair = translationPairs.FirstOrDefault(item => item.FromLanguage.Equals(fromLanguage.ToString()) && item.ToLanguage.Equals(toLanguage.ToString()));
                var translation = translator.Translate(translationPair.ToString(), text);
                success = true;
                return translation.Text;
            }
            success = false;
            return string.Empty;
        }
    }
}
