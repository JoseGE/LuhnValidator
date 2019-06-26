using System;
using System.Collections.Generic;

namespace LuhnValidator
{
    public class IdCardValidator
    {
        //My private dict
        private readonly Dictionary<string, int> countries;

        public IdCardValidator()
        {
            countries = new Dictionary<string, int>()
            {
                { "DO", 11 },
                { "NI", 11 },
                { "US", 11 },
                { "FR", 9 },
            };
        }

        public bool ValidateIdCard(string card)
        {
            int sum = Convert.ToInt32(card.Substring(card.Length - 1));
            int digits = card.Length;
            int parity = digits % 2;

            for (int i = 0; i < digits - 1; i++)
            {
                int digit = Convert.ToInt32(card[i].ToString());

                if (i % 2 == parity)
                    digit = digit * 2;
                if (digit > 9)
                    digit = digit - 9;

                sum += digit;
            }

            return sum % 10 == 0;
        }

        public bool ValidateIdCard(string cardNumber, string countryISO)
        {
            var isValidCountryISO = countries.TryGetValue(countryISO, out int idCardLenght);

            if (!isValidCountryISO)
                return false;

            string card = "";

            foreach (var character in cardNumber)
                if (int.TryParse(character.ToString(), out int isNumber))
                    card += character.ToString();

            if (card.Length != idCardLenght)
                return false;

            int sum = Convert.ToInt32(card.Substring(card.Length - 1));
            int digits = card.Length;
            int parity = digits % 2;

            for (int i = 0; i < digits - 1; i++)
            {
                int digit = Convert.ToInt32(card[i].ToString());

                if (i % 2 == parity)
                    digit = digit * 2;
                if (digit > 9)
                    digit = digit - 9;

                sum += digit;
            }

            return sum % 10 == 0;
        }


        public bool ValidateCreditCard(string cardNumbers)
        {
            string card = "";

            foreach(var character in cardNumbers)
                if (int.TryParse(character.ToString(), out int isNumber))
                    card += character.ToString();

            if (card.Length != 16)
                return false;

            int sum = Convert.ToInt32(card.Substring(card.Length - 1));
            int digits = card.Length;
            int parity = digits % 2;

            for (int i = 0; i < digits - 1; i++)
            {
                int digit = Convert.ToInt32(card[i].ToString());

                if (i % 2 == parity)
                    digit = digit * 2;
                if (digit > 9)
                    digit = digit - 9;

                sum += digit;
            }

            return sum % 10 == 0;
        }
    }
}