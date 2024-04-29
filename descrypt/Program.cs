using System;
using System.Text;

class Program
{
    static string Decrypt(string message)
    {
        string[] encryptedBits = message.Split(' ');
        byte[] encryptedBytes = new byte[encryptedBits.Length];
        for (int i = 0; i < encryptedBits.Length; i++)
        {
            encryptedBytes[i] = Convert.ToByte(encryptedBits[i], 2);
        }

        StringBuilder decryptedMessage = new StringBuilder();
        for (int i = 0; i < encryptedBytes.Length; i++)
        {
            byte b = (byte)(encryptedBytes[i] ^ 3); // ^ 3 inverte os dois últimos bits

            b = (byte)(((b & 0xF0) >> 4) | ((b & 0x0F) << 4));

            decryptedMessage.Append((char)b);
        }

        return decryptedMessage.ToString();
    }

    static void Main()
    {
  
        string message = "10010110 11110111 01010110 00000001 00010111 00100110 01010111 00000001 00010111 01110110 01010111 00110110 11110111 11010111 01010111 00000011";

        string decryptedMessage = Decrypt(message);

        Console.WriteLine(decryptedMessage);
    }
}
