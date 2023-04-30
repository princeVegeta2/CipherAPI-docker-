using System.Text.RegularExpressions;
namespace CipherAPI.Models
{
    public class Cipher
    {
        public string ROT13(string input)
        {
            string alphabet1 = "ABCDEFGHIJKLM";
            string alphabet2 = "NOPQRSTUVWXYZ";
            string output = "";

            for(int i = 0; i < input.Length; i++)
            {
                Regex regex = new Regex("[^a-zA-Z]");
                if (!regex.IsMatch(input[i].ToString()))
                {
                    if (alphabet1.Contains(input[i]) || alphabet1.Contains(char.ToUpper(input[i])))
                    {
                        for(int j = 0; j < alphabet1.Length; j++)
                        {
                            if (input[i] == alphabet1[j])
                            {
                                output = output + alphabet2[j];
                            }
                            else if(input[i] == char.ToLower(alphabet1[j]))
                            {
                                output = output + char.ToLower(alphabet2[j]);
                            }
                        }
                    }else if (alphabet2.Contains(input[i]) || alphabet2.Contains(char.ToUpper(input[i])))
                    {
                        for (int k = 0; k < alphabet2.Length; k++)
                        {
                            if(input[i] == alphabet2[k])
                            {
                                output = output + alphabet1[k];
                            }else if(input[i] == char.ToLower(alphabet2[k]))
                            {
                                output = output + char.ToLower(alphabet1[k]);
                            }
                        }
                    }
                }
                else
                {
                    output = output + input[i];
                }
            }
            return output;
        }

        public string ROT16(string input)
        {
            string alphabet1 = "АБВГДЕЖЗИЙКЛМНОП";
            string alphabet2 = "РСТУФХЦЧШЩЪЫЬЭЮЯ";
            string output = "";

            Regex regex = new Regex("[^а-яА-Я]");

            for (int i = 0; i < input.Length; i++)
            {
                if (!regex.IsMatch(input[i].ToString()))
                {
                    if (alphabet1.Contains(input[i]) || alphabet1.Contains(char.ToUpper(input[i])))
                    {

                        for (int j = 0; j < alphabet1.Length; j++)
                        {
                            if (input[i] == alphabet1[j])
                            {
                                output = output + alphabet2[j];
                            }
                            else if (input[i] == char.ToLower(alphabet1[j]))
                            {
                                output = output + char.ToLower(alphabet2[j]);
                            }
                        }

                    }
                    else if (alphabet2.Contains(input[i]) || alphabet2.Contains(char.ToUpper(input[i])))
                    {
                        for (int k = 0; k < alphabet2.Length; k++)
                        {
                            if (input[i] == alphabet2[k])
                            {
                                output = output + alphabet1[k];
                            }
                            else if (input[i] == char.ToLower(alphabet2[k]))
                            {
                                output = output + char.ToLower(alphabet1[k]);
                            }
                        }
                    }
                }
                else
                {
                    output = output + input[i];
                }
            }
            return output;
        }
    }
}
