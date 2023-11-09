using System;
using System.Numerics;

public static class DiffieHellman
{
    /// <summary>
    /// Generates a private key.
    /// </summary>
    /// <param name="primeP">A prime number.</param>
    /// <returns>A random BigInteger that is greater than 1 and less than primeP.</returns>
    public static BigInteger PrivateKey(BigInteger primeP) 
    {
        Random random = new Random();
        byte[] bytes = new byte[primeP.ToByteArray().Length];
        BigInteger result;

        do
        {
            random.NextBytes(bytes);
            result = new BigInteger(bytes);
        } while (result <= 1 || result >= primeP);

        return result;
    }

    /// <summary>
    /// Calculates the public key.
    /// </summary>
    /// <param name="primeP">A prime number.</param>
    /// <param name="primeG">A primitive root modulo primeP.</param>
    /// <param name="privateKey">The private key.</param>
    /// <returns>primeG raised to the power of privateKey modulo primeP.</returns>
    public static BigInteger PublicKey(BigInteger primeP, BigInteger primeG, BigInteger privateKey) => BigInteger.ModPow(primeG, privateKey, primeP);

    /// <summary>
    /// Calculates the shared secret key.
    /// </summary>
    /// <param name="primeP">A prime number.</param>
    /// <param name="publicKey">The public key.</param>
    /// <param name="privateKey">The private key.</param>
    /// <returns>publicKey raised to the power of privateKey modulo primeP.</returns>
    public static BigInteger Secret(BigInteger primeP, BigInteger publicKey, BigInteger privateKey) => BigInteger.ModPow(publicKey, privateKey, primeP);
}
