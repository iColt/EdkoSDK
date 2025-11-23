using EdkoSKD.Common.Cryptography;
using System.Text;

namespace EdkoSDK.Cryptography.Basic;

public static class Ceazar
{
    public static string Encrypt(string plaintext, int offset)
    {
        return Process(plaintext, offset, EncryptionAction.Encrypt);
    }

    public static string Decrypt(string plaintext, int offset)
    {
        return Process(plaintext, offset, EncryptionAction.Decrypt);
    }

    private static string Process(string plaintext, int offset, EncryptionAction action)
    {
        if (plaintext == null)
        {
            throw new ArgumentNullException(nameof(plaintext), "Should not be null");
        }

        int offsetByMod = offset % 26;

        char lastCharLower = 'z';
        char firstCharLower = 'a';
        char firstCharUpper = 'A';
        char lastCharUpper = 'Z';
        char spaceChar = ' ';

        byte[] asciiBytes = Encoding.ASCII.GetBytes(plaintext);
        byte[] encriptedByteArray = new byte[asciiBytes.Length];

        int i = 0;
        foreach (byte @byte in asciiBytes)
        {
            if (@byte == spaceChar 
                || @byte > lastCharLower 
                || @byte < firstCharUpper 
                || (@byte > lastCharUpper && @byte < firstCharLower))
            {
                encriptedByteArray[i] = @byte;
                i++;
                continue;
            }

            int byteWithOffset = 0;
            if (@byte >= firstCharUpper && @byte <= lastCharUpper)
            {
                byteWithOffset = action == EncryptionAction.Encrypt ?
               CalculateEncryptionChar(offsetByMod, lastCharUpper, firstCharUpper, @byte) :
               CalculateDecryptionChar(offsetByMod, lastCharUpper, firstCharUpper, @byte);
            } else
            {
                byteWithOffset = action == EncryptionAction.Encrypt ?
                CalculateEncryptionChar(offsetByMod, lastCharLower, firstCharLower, @byte) :
                CalculateDecryptionChar(offsetByMod, lastCharLower, firstCharLower, @byte);
            }
           
            encriptedByteArray[i] = (byte)byteWithOffset;
            i++;
        }

        return Encoding.UTF8.GetString(encriptedByteArray);
    }

    private static int CalculateEncryptionChar(int offsetByMod, char lastChar, char firstChar, byte @byte)
    {
        
        var byteWithOffset = @byte + offsetByMod;
        if (byteWithOffset > lastChar)
        {
            byteWithOffset = firstChar + (byteWithOffset - lastChar) - 1;
        }

        return byteWithOffset;
    }

    private static int CalculateDecryptionChar(int offsetByMod, char lastChar, char firstChar, byte @byte)
    {
        var byteWithOffset = @byte - offsetByMod;
        if (byteWithOffset < firstChar)
        {
            byteWithOffset = lastChar - (firstChar - byteWithOffset) + 1;
        }

        return byteWithOffset;
    }
}
