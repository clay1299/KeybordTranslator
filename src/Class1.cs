using System.Text;

namespace KeybordTranslator
{
    public class Translator
    {
        private static Dictionary<char, char> dict = new Dictionary<char, char>
        {
            ['q'] = 'й',
            ['w'] = 'ц',
            ['e'] = 'у',
            ['r'] = 'к',
            ['t'] = 'е',
            ['y'] = 'н',
            ['u'] = 'г',
            ['i'] = 'ш',
            ['o'] = 'щ',
            ['p'] = 'з',
            ['['] = 'х',
            ['{'] = 'Х',
            [']'] = 'ъ',
            ['}'] = 'Ъ',
            ['a'] = 'ф',
            ['s'] = 'ы',
            ['d'] = 'в',
            ['f'] = 'а',
            ['g'] = 'п',
            ['h'] = 'р',
            ['j'] = 'о',
            ['k'] = 'л',
            ['l'] = 'д',
            [';'] = 'ж',
            [':'] = 'Ж',
            ['\''] = 'э',
            ['\"'] = 'Э',
            ['z'] = 'я',
            ['x'] = 'ч',
            ['c'] = 'с',
            ['v'] = 'м',
            ['b'] = 'и',
            ['n'] = 'т',
            ['m'] = 'ь',
            [','] = 'б',
            ['<'] = 'Б',
            ['.'] = 'ю',
            ['>'] = 'Ю',
            [' '] = ' ',
        };

        private static Dictionary<char, char> reverseDict;

        static Translator()
        {
            reverseDict = dict.ToDictionary(x => x.Value, x => x.Key);
        }

        public string En2Ru(string str)
        {
            var sb = new StringBuilder();

            foreach (char c in str)
            {
                bool isUpper = char.IsUpper(c);
                char lowerC = char.ToLower(c);

                if (dict.TryGetValue(lowerC, out char translatedChar))
                    sb.Append(isUpper ? char.ToUpper(translatedChar) : translatedChar);
                else
                    sb.Append(c);
            }

            return sb.ToString();
        }

        public string Ru2En(string str)
        {
            var sb = new StringBuilder();

            foreach (char c in str)
            {
                bool isUpper = char.IsUpper(c);
                char lowerC = char.ToLower(c);
                
                if (reverseDict.TryGetValue(lowerC, out char translatedChar))
                    sb.Append(isUpper ? char.ToUpper(translatedChar) : translatedChar);
                else
                    sb.Append(c);
            }

            return sb.ToString();
        }
    }
}