using System;
using System.Collections.Generic;
using System.Text;

namespace LuhnValidator
{
    public class IdCardValidator
    {
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

        public bool ValidateCreditCard(string cardNumbers)
        {
            string card = default;

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