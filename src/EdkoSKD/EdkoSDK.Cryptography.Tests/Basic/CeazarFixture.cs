using EdkoSDK.Cryptography.Basic;

namespace EdkoSDK.Cryptography.Tests.Basic;

[TestFixture]
internal sealed class CeazarFixture
{
    public static IEnumerable<TestCaseData> CipherTestCases()
    {
        // P: Plaintext, O: Offset, C: Expected Ciphertext
        yield return new TestCaseData("A", 27, "B"); // Offset > 26 (27 mod 26 = 1)
        yield return new TestCaseData("B", -1, "A"); // Negative offset (B - 1 = A)
        yield return new TestCaseData("aBc XyZ", 5, "fGh CdE");
        yield return new TestCaseData("Encryption", 5, "Jshwduynts");
        yield return new TestCaseData("HELLO", 3, "KHOOR");
        yield return new TestCaseData("zebra", 1, "afcsb");
        yield return new TestCaseData("WORLD", 26, "WORLD"); // Offset 26 should result in the same text;
        yield return new TestCaseData("Test with spaces and Punctuation!", 1, "Uftu xjui tqbdft boe Qvoduvbujpo!"); // Non-alphabetic characters are unchanged
       
    }

    // --- Encrypt Tests ---

    [Test, TestCaseSource(nameof(CipherTestCases))]
    public void Encrypt_Should_ReturnCorrectCiphertext(string plaintext, int offset, string expectedCiphertext)
    {
        // Act
        string actualCiphertext = Ceazar.Encrypt(plaintext, offset);

        // Assert
        Assert.That(actualCiphertext, Is.EqualTo(expectedCiphertext));
    }

    // --- Decrypt Tests ---

    [Test, TestCaseSource(nameof(CipherTestCases))]
    public void Decrypt_Should_ReturnOriginalPlaintext(string expectedPlaintext, int offset, string ciphertext)
    {
        // Act
        string actualPlaintext = Ceazar.Decrypt(ciphertext, offset);

        // Assert
        Assert.That(actualPlaintext, Is.EqualTo(expectedPlaintext));
    }

    // --- Consistency Test (Encrypt then Decrypt) ---

    // This test ensures that the round trip (Encrypt followed by Decrypt) always returns the original string.
    [Test, TestCaseSource(nameof(CipherTestCases))]
    public void EncryptThenDecrypt_Should_ReturnOriginalPlaintext(string plaintext, int offset, string expectedCiphertext)
    {
        // Arrange (plaintext and offset are provided by the TestCaseSource)

        // Act
        string ciphertext = Ceazar.Encrypt(plaintext, offset);
        string decryptedPlaintext = Ceazar.Decrypt(ciphertext, offset);

        // Assert
        Assert.That(ciphertext, Is.EqualTo(expectedCiphertext), "Ciphertext mismatch during Encrypt phase.");
        Assert.That(decryptedPlaintext, Is.EqualTo(plaintext), "Round-trip Decrypt should match original Plaintext.");
    }

    // --- Edge Case Tests ---

    [Test]
    [TestCase("")] // Empty string
    [TestCase(" ")] // String with only space
    [TestCase("12345!@#$")] // String with only non-alphabetic characters
    public void Encrypt_WithEmptyOrNonAlphaString_Should_ReturnOriginalString(string input)
    {
        // Act
        string result = Ceazar.Encrypt(input, 13); // Use an arbitrary offset

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    [TestCase(0, "ABC", "ABC")] // Offset 0
    [TestCase(26, "ABC", "ABC")] // Offset 26
    [TestCase(52, "ABC", "ABC")] // Offset 52 (2 * 26)
    public void Encrypt_WithZeroOrMultipleOf26Offset_Should_ReturnOriginalString(int offset, string plaintext, string expectedCiphertext)
    {
        // Act
        string result = Ceazar.Encrypt(plaintext, offset);

        // Assert
        Assert.That(result, Is.EqualTo(expectedCiphertext));
    }
}
